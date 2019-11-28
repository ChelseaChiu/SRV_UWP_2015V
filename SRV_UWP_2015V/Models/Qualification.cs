using SRV_UWP_2015V.WCFClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV_UWP_2015V.Models
{
    public class Qualification
    {
        public string QualCode { get; set; }
        public string NationalQualCode { get; set; }
        public string TafeQualCode { get; set; }
        public string QualName { get; set; }
        public int TotalUnits { get; set; }
        public int CoreUnits { get; set; }
        public int ElectedUnits { get; set; }
        public int ReqListedElectedUnits { get; set; }
        public string CompletionStatus { get; set; }

        public int DoneC { get; set; }
        public int DoneE { get; set; }
        public int DoneLE { get; set; }
        public int DoneTotal { get; set; }

        //public static bool IsCompleted(Qualification sQual)
        //{
        //    int core = sQual.CoreUnits;
        //    int elective = sQual.ElectedUnits;
        //    int listedE = sQual.ReqListedElectedUnits;
        //    int total = sQual.TotalUnits;
        //    int afterCore = total - sQual.DoneC;
        //    if (sQual.DoneC < core)
        //    {
        //        return false;
        //    }
        //    else if (sQual.DoneE + sQual.DoneLE < afterCore)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }

        //}
        //public static List<Qualification> GetQualificationList(string studentID)
        //{
        //    List<Qualification> qualificationList = new List<Qualification>();
        //    var qs = Proxy.GetQualificationList(studentID);
        //    if (qs!=null)
        //    {
        //        for (int i = 0; i <qs.Result.Count ; i++)
        //        {
        //            Qualification qualification = new Qualification();
        //            qualification.QualCode = qs.Result[i].QualCode;
        //            qualification.QualName = qs.Result[i].QualName;
        //            qualification.TafeQualCode = qs.Result[i].TafeQualCode;
        //            qualification.NationalQualCode = qs.Result[i].NationalQualCode;
        //            qualification.CoreUnits = qs.Result[i].CoreUnits;
        //            qualification.ElectedUnits = qs.Result[i].ElectedUnits;
        //            qualification.ReqListedElectedUnits = qs.Result[i].ReqListedElectedUnits;
        //            qualification.DoneC = qs.Result[i].DoneC;
        //            qualification.DoneE = qs.Result[i].DoneE;
        //            qualification.DoneLE = qs.Result[i].DoneLE;
        //            qualification.DoneTotal = qs.Result[i].DoneTotal;
        //            qualificationList.Add(qualification);
        //        }
        //        return qualificationList;
        //    }
            
        //    else { return null; }
        //}

        public List<Competency> Competencies { get; set; }


    }
}
