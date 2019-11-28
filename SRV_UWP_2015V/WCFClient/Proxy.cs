using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRV_UWP_2015V.ServiceRef;

namespace SRV_UWP_2015V.WCFClient
{
    public class Proxy
    {
        private static StudentServiceClient proxy = null;
        public bool Login(string id)
        {
            proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
            return proxy.LoginAsync(id).Result;
           
        }

        public Student GetStudentById(string id)
        {
            proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
            return proxy.GetStudentByIdAsync(id).Result;

        }


        public List<Qualification> GetQualificationList(string studentId)
        {
            proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
            var qs = proxy.GetQualificationListAsync(studentId).Result;
            List<Qualification> qualifications = new List<Qualification>();
            foreach (var q in qs)
            {
                qualifications.Add(q);
            }
            return qualifications;
        }

        public List<Student> GetStudentList()
        {
            proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
            var ss = proxy.GetStudentsAsync().Result;
            List<Student> students = new List<Student>();
            foreach (var s in ss)
            {
                students.Add(s);
            }
            return students;
        }

        public List<Competency> GetCompetencyList(string studentId, string qualId)
        {
            proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
            var cs = proxy.GetCompetencyListAsync(studentId, qualId).Result;
            List<Competency> competencies = new List<Competency>();
            foreach (var c in cs)
            {
                competencies.Add(c);
            }
            return competencies;
        }
        public List<Competency> GetNotPassedCompetencyList(string studentId, string qualId)
        {
            proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
            var cs = proxy.GetNotPassedCompetenciesAsync(studentId, qualId).Result;
            List<Competency> competencies = new List<Competency>();
            foreach (var c in cs)
            {
                competencies.Add(c);
            }
            return competencies;
        }

    }
}
