using SRV_UWP_2015V.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV_UWP_2015V.Viewmodels
{
    public class DetailsViewModel 
    {
        public Student Student = new Student();

        public List<Qualification> Qualifications;

        public DetailsViewModel(string studentId)
        {
            // parameter studentId passed from prevoius page
            this.Student = User.GetStudentById(studentId);
            this.Qualifications = new List<Qualification>(Qualification.GetQualificationList(Student.UserID).ToList().OrderBy(q => q.QualName));
        }
    }
}
