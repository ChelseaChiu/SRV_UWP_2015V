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
        public async static Task<bool> Login(string id)
        {
            proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
            bool success = await proxy.LoginAsync(id);

                if (success)
                {
                    return success;
                }
                else return false;
        }

        public async static Task<Student> GetStudentById(string id)
        {
            proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
            Student s = await proxy.GetStudentByIdAsync(id);
            return s;

        }


        public async static Task<List<Qualification>> GetQualificationList(string studentId)
        {
            proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
            List<Qualification> qualList = await proxy.GetQualificationListAsync(studentId);

            return qualList;               

        }

        public async static Task<List<Student>> GetStudentList()
        {
            proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
            List<Student> students = await proxy.GetStudentsAsync();
            return students;
        }

        public async static Task<List<Competency>> GetCompetencyList(string studentId, string qualId)
        {
            proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
            List<Competency> cs = await proxy.GetCompetencyListAsync(studentId, qualId);
            return cs;
        }
    }
}
