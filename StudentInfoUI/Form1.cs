using StudentInfoUI.Model;
using StudentInfoUI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace StudentInfoUI
{
    public enum State
    {
        View,
        Add,
        Update
    }

    public partial class Form1 : Form
    {
        private State _currentState = State.View;
        private readonly IStudentDataServices _studentDataServices;
        private List<StudentModel> _students = new List<StudentModel>();
        private StudentModel _selectedStudent;

        public Form1(IStudentDataServices studentDataServices)
        {

            _studentDataServices = studentDataServices;
            InitializeComponent();
        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            var acadLevels = await _studentDataServices.GetAcadLevelsAsync();
            var sections = await _studentDataServices.GetSectionsAsync();
            var students = await _studentDataServices.GetAllStudentsAsync();

            PopulateAcadLevelDropdown(acadLevels);
            PopulateSectionDropdown(sections);
            DisplayStudents(students);

            ResetButtons();
            EnableFields(false);
        }


        private async void txt_search_TextChanged_1(object sender, EventArgs e)
        {
            var search = txt_search.Text.Trim();
            var results = await SearchStudentsAsync(search);
            DisplayStudents(results);
        }


        private void dataGridView_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < _students.Count)
            {
                _selectedStudent = _students[e.RowIndex];
                DisplayStudent(_selectedStudent);

                ResetButtons();
                btn_Update.Visible = true;
                btn_Delete.Visible = true;
                EnableFields(false);
                _currentState = State.View;
            }
        }
        //------------------------------BUTTON HANDLERS---------------------------------//

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ClearFields();
            ResetButtons();
            btn_Save.Visible = true;
            btn_Cancel.Visible = true;
            EnableFields(true);
            _currentState = State.Add;
        }


        private void btn_Update_Click(object sender, EventArgs e)
        {
            ResetButtons();
            btn_Save.Visible = true;
            btn_Cancel.Visible = true;
            EnableFields(true);
            _currentState = State.Update;
        }


        private async void btn_Save_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            if (_currentState == State.Add) await AddNewStudent();
            else if (_currentState == State.Update) await EditStudent();

            ResetButtons();
            _currentState = State.View;
            EnableFields(false);
        }

        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            ResetButtons();
            _currentState = State.View;

            var confirmResult
                = MessageBox.Show("Are you sure to delete this student?",
                "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                ResetButtons();
                ClearFields();
                return;
            }

            await DeleteStudent();
        }


        private async void btn_Cancel_Click(
            object sender, EventArgs e)
        {
            ResetButtons();
            ClearFields();
        }

        private void PopulateAcadLevelDropdown(
            List<AcadLevelModel> acadLevels)
        {
            cmbAcadLevel.DataSource = acadLevels;
            cmbAcadLevel.DisplayMember = "Name";
            cmbAcadLevel.ValueMember = "Id";
        }


        private void PopulateSectionDropdown(
            List<SectionModel> sections)
        {
            cmbSection.DataSource = sections;
            cmbSection.DisplayMember = "Name";
            cmbSection.ValueMember = "Id";
        }


        private void DisplayStudents(List<StudentModel> students)
        {
            _students = students;
            dataGridView.Rows.Clear();

            foreach (var student in _students)
            {
                dataGridView.Rows.Add(
                    student.Id,
                    student.Lastname,
                    student.Firstname,
                    student.Middlename,
                    NormalizeGender(student.Gender),
                    student.AcadLevelName,
                    student.SectionName,
                    student.Email
                    );
            }

        }


        private async Task<List<StudentModel>> SearchStudentsAsync(string search)
        {
            return await _studentDataServices
                .SearchStudentsAsync(search);
        }

        private void DisplayStudent(StudentModel student)
        {
            txt_LastName.Text = student.Lastname;
            txt_FirstName.Text = student.Firstname;
            txt_MiddleName.Text = student.Middlename;
            cmbGender.Text = NormalizeGender(student.Gender);
            cmbAcadLevel.SelectedValue = student.AcadLevelId;
            cmbSection.SelectedValue = student.SectionId;
            txt_Email.Text = student.Email;
        }


        private async Task AddNewStudent()
        {
            try
            {
                var student = new StudentModel
                {
                    Lastname = txt_LastName.Text,
                    Firstname = txt_FirstName.Text,
                    Middlename = txt_MiddleName.Text,
                    Gender = cmbGender.SelectedItem.ToString(),
                    AcadLevelId = (int)cmbAcadLevel.SelectedValue,
                    SectionId = (int)cmbSection.SelectedValue,
                    Email = txt_Email.Text
                };
                NormalizeStudentModel(student);
                await _studentDataServices.AddStudentAsync(student);
                MessageBox.Show($"{student.Firstname} {student.Lastname} added successfully.");
                var students = await _studentDataServices.GetAllStudentsAsync();
                DisplayStudents(students);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while adding the student.");
            }
        }


        private async Task EditStudent()
        {
            try
            {
                if (_selectedStudent == null)
                {
                    MessageBox.Show("No student selected for update.");
                    return;
                }

                var genderCode = !string.IsNullOrEmpty(cmbGender.Text)
                        ? cmbGender.Text.Substring(0, 1).ToUpper()
                        : "";

                _selectedStudent.Lastname = txt_LastName.Text;
                _selectedStudent.Firstname = txt_FirstName.Text;
                _selectedStudent.Middlename = txt_MiddleName.Text;
                _selectedStudent.Gender = genderCode;
                _selectedStudent.AcadLevelId = (int)cmbAcadLevel.SelectedValue;
                _selectedStudent.SectionId = (int)cmbSection.SelectedValue;
                _selectedStudent.Email = txt_Email.Text;
                NormalizeStudentModel(_selectedStudent);
                await _studentDataServices.UpdateStudentAsync(_selectedStudent);
                MessageBox.Show($"{_selectedStudent.Firstname} {_selectedStudent.Lastname} updated successfully.");
                var students = await _studentDataServices.GetAllStudentsAsync();
                DisplayStudents(students);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while updating the student.");
            }
        }


        private async Task DeleteStudent()
        {
            try
            {
                var id = _selectedStudent.Id;
                await _studentDataServices.DeleteStudentAsync(id);
                MessageBox.Show("Successfully remove student");
                var students = await _studentDataServices.GetAllStudentsAsync();
                DisplayStudents(students);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while removing the student.");
            }
        }


        private void ResetButtons()
        {
            btn_Add.Visible = true;
            btn_Update.Visible = false;
            btn_Delete.Visible = false;
            btn_Save.Visible = false;
            btn_Cancel.Visible = false;
        }


        private void EnableFields(bool enable)
        {
            txt_LastName.Enabled = enable;
            txt_FirstName.Enabled = enable;
            txt_MiddleName.Enabled = enable;
            cmbGender.Enabled = enable;
            cmbAcadLevel.Enabled = enable;
            cmbSection.Enabled = enable;
            txt_Email.Enabled = enable;
        }


        private void ClearFields()
        {
            txt_LastName.Text = string.Empty;
            txt_FirstName.Text = string.Empty;
            txt_MiddleName.Text = string.Empty;
            cmbGender.SelectedIndex = -1;
            cmbAcadLevel.SelectedIndex = -1;
            cmbSection.SelectedIndex = -1;
            txt_Email.Text = string.Empty;
        }

        private void NormalizeStudentModel(StudentModel student)
        {
            student.Lastname = student.Lastname?.Trim();
            student.Firstname = student.Firstname?.Trim();
            student.Middlename = student.Middlename?.Trim();
            student.Gender = student.Gender?.Trim()[0].ToString();
            student.Email = student.Email?.Trim();
        }


        private string NormalizeGender(string gender)
        {
            return gender == "M" ? "Male" :
              gender == "F" ? "Female" : gender == "T" ? "Transformer" : null;
        }





        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txt_LastName.Text) ||
                string.IsNullOrWhiteSpace(txt_FirstName.Text) ||
                string.IsNullOrWhiteSpace(txt_MiddleName.Text) ||
                string.IsNullOrWhiteSpace(txt_Email.Text) ||
                cmbGender.SelectedIndex < 0 ||
                cmbAcadLevel.SelectedIndex < 0 ||
                cmbSection.SelectedIndex < 0)
            {
                MessageBox.Show("Please fill in all required fields.",
                                "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
