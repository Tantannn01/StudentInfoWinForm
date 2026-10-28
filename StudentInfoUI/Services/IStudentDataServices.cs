using StudentInfoUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoUI.Services
{
    public interface IStudentDataServices
    {
        // READ
        Task<List<StudentModel>> GetAllStudentsAsync();
        Task<StudentModel> GetStudentByIdAsync(int id);
        Task<List<StudentModel>> SearchStudentsAsync(string search);

        // DROPDOWN DATA
        Task<List<AcadLevelModel>> GetAcadLevelsAsync();
        Task<List<SectionModel>> GetSectionsAsync();

        // CREATE, UPDATE, DELETE
        Task<int> AddStudentAsync(StudentModel student);
        Task UpdateStudentAsync(StudentModel student);
        Task DeleteStudentAsync(int id);
    }
}
