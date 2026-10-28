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

namespace StudentInfoUI
{
    public partial class Form1 : Form
    {
        private readonly IStudentDataServices _studentDataServices;
        private List<AcadLevelModel> _student = new List<AcadLevelModel>();
        public StudentModel _selectedStudent;
        public Form1(IStudentDataServices studentDataServices)
        {
            InitializeComponent();
            _studentDataServices = studentDataServices;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var acadLevels = await _studentDataServices.GetAcadLevelsAsync();
            var sections = await _studentDataServices.GetSectionsAsync();
            var students = await _studentDataServices.GetAllStudentsAsync();

            PopulateAcadLevelDropdown(acadLevels);
            PopulateSectionDropdown(sections);
            DisplayStudent(students.FirstOrDefault());

        }

        private void PopulateAcadLevelDropdown(List<AcadLevelModel> acadLevels)
        {
            cmbAcadLevel.DataSource = acadLevels;
            cmbAcadLevel.DisplayMember = "Name";
            cmbAcadLevel.ValueMember = "Id";
        }

        private void PopulateSectionDropdown(List<SectionModel> sections)
        {
            cmbSection.DataSource = sections;
            cmbSection.DisplayMember = "Name";
            cmbSection.ValueMember = "Id";
        }

        private void DisplayStudent(StudentModel student)
        {
            txt_Lastname.Text = student.Lastname;
            txt_Firstname.Text = student.Firstname;
            txt_Middlename.Text = student.Middlename;
            cmbGender.SelectedItem = student.Gender;
            cmbAcadLevel.SelectedValue = student.AcadLevelId;
            cmbSection.SelectedValue = student.SectionId;
            txt_Email.Text = student.Email;
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
            txt_Lastname.Enabled = enable;
            txt_Firstname.Enabled = enable;
            txt_Middlename.Enabled = enable;
            cmbGender.Enabled = enable;
            cmbAcadLevel.Enabled = enable;
            cmbSection.Enabled = enable;
            txt_Email.Enabled = enable;
        }
        private void NormalizeStudentModel(StudentModel student)
        {
            student.Lastname = student.Lastname?.Trim();
            student.Firstname = student.Firstname?.Trim();
            student.Middlename = student.Middlename?.Trim();
            student.Gender = student.Gender?.Trim();
            student.Email = student.Email?.Trim();
        }

        private async Task AddNewStudent()
        {
            try
            {
                var student = new StudentModel
                {
                    Lastname = txt_Lastname.Text,
                    Firstname = txt_Firstname.Text,
                    Middlename = txt_Middlename.Text,
                    Gender = cmbGender.SelectedItem.ToString(),
                    AcadLevelId = (int)cmbAcadLevel.SelectedValue,
                    SectionId = (int)cmbSection.SelectedValue,
                    Email = txt_Email.Text
                };
                NormalizeStudentModel(student);
                await _studentDataServices.AddStudentAsync(student);
                MessageBox.Show($"{student.Firstname} {student.Lastname} added successfully.");
                var students = await _studentDataServices.GetAllStudentsAsync();
                DisplayStudent(students.FirstOrDefault());
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

                _selectedStudent.Lastname = txt_Lastname.Text;
                _selectedStudent.Firstname = txt_Firstname.Text;
                _selectedStudent.Middlename = txt_Middlename.Text;
                _selectedStudent.Gender = genderCode;
                _selectedStudent.AcadLevelId = (int)cmbAcadLevel.SelectedValue;
                _selectedStudent.SectionId = (int)cmbSection.SelectedValue;
                _selectedStudent.Email = txt_Email.Text;
                NormalizeStudentModel(_selectedStudent);
                await _studentDataServices.UpdateStudentAsync(_selectedStudent);
                MessageBox.Show($"{_selectedStudent.Firstname} {_selectedStudent.Lastname} updated successfully.");
                var students = await _studentDataServices.GetAllStudentsAsync();
                DisplayStudent(students.FirstOrDefault());
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while updating the student.");
            }
        }


        private string NiormalizeGender(string gender)
        {
            return gender == "M" ? "Male" :
              gender == "F" ? "Female" : gender == "T" ? "Transformer" : null;
        }

        private string NormalizeGender(string gender)
        {
            return gender == "M" ? "Male" :
                   gender == "F" ? "Female" :
                   gender == "T" ? "Transformer" : null;
        }

    }



}

