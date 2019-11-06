using SRV_UWP_2015V.WCFClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV_UWP_2015V.Models
{
    public class Competency 
    {
      //  public string completionStatus;
       
        public string SubjectCode { get; set; }
        public string TafeCode { get; set; }
        public string NationalCode { get; set; }
        public string SubjectName { get; set; }
        public string TrainingPakckageUsage { get; set; }
        public string Results { get; set; }

        public string StudyPlan { get; set; }
        public string CompetencyName { get; set; }

        public static List<Competency> GetCompetencyList(string studentID, string qualificationID)
        {
                List<Competency> compList = new List<Competency>();
                var cl = Proxy.GetCompetencyList(studentID,qualificationID);
                if (cl != null)
                {
                    for (int i = 0; i < cl.Result.Count; i++)
                    {
                    Competency comp = new Competency();
                    comp.TafeCode = cl.Result[i].TafeCode;
                    comp.NationalCode = cl.Result[i].NationalCode;
                    comp.CompetencyName = cl.Result[i].CompetencyName;
                    comp.SubjectCode = cl.Result[i].SubjectCode;
                    comp.TrainingPakckageUsage = cl.Result[i].TrainingPakckageUsage;
                    comp.StudyPlan = cl.Result[i].StudyPlan;
                    comp.Results = cl.Result[i].Results;
                    if (comp.Results == "PA")
                    {
                        comp.BackColor = "LightBlue";
                    }
                    else { comp.BackColor = "White"; }

                    compList.Add(comp);
                    }
                    return compList;
                }

                else { return null; }
                
        }

      /*  public bool UpdateToDB(string studentID, string qualificationID, string competencyID, string status, string comments)
        {

            DBConnection dbCon = new DBConnection();
            if (dbCon.IsConnect())
            {
                string query1 = String.Format("update student_competency set Completion_Status='{0}' where StudentID ='{1}' and QualificationID = '{2}' and CompetencyID_Tafe = '{3}'", status, studentID, qualificationID, competencyID);
                string query2 = String.Format("update student_competency set ResultComment = '{0}' where StudentID ='{1}' and QualificationID = '{2}' and CompetencyID_Tafe = '{3}'", comments, studentID, qualificationID, competencyID);
                var cmd1 = new MySqlCommand(query1, dbCon.Connection);
                var cmd2 = new MySqlCommand(query2, dbCon.Connection);
                try
                {
                    var c1 = cmd1.ExecuteNonQuery();
                    var c2 = cmd2.ExecuteNonQuery();

                    return true;

                }
                catch (Exception)
                {

                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        */
        public string BackColor
        { get; set; }
    }
}
