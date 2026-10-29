using StudentInfoUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoUI
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress
                    = new Uri(" https://studentinfoapi-c574.onrender.com/api/students");
                httpClient.Timeout = TimeSpan.FromSeconds(30);

                IStudentDataServices studentDataServices = new StudentAPIService(httpClient);
                Application.Run(new Form1(studentDataServices));
            }

        }
    }
}
