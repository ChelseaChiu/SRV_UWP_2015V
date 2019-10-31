using SRV_UWP_2015V.WCFClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV_UWP_2015V.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; }
        public string Phone { get; }
        public string Address { get; }
        public string DOB { get; }
        public string UserID { get; set; }
        public string Password { get; set; }

        public bool Login(string inUserId)
        {
            var success = Proxy.Login(inUserId);
            
            if (success.Result == true)
            {
                return success.Result;
            }
            else return false;
        }
        public Qualification SelectQualification(Qualification selectedItem)
        {
            Qualification mySelectedItem = selectedItem;
            //TODO
            return mySelectedItem;
        }

        public Student GetStudentById(string studentId)
        {
            Student student = new Student();
            var s = Proxy.GetStudentById(studentId);
            if (s != null)
            {
                student.UserID = s.Result.StudentID;
                student.FirstName = s.Result.GivenName;
                student.LastName = s.Result.LastName;
                return student;
            }

            else return null;


        }
    }
}
