using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS;

namespace task7
{
 
   partial class PatientStatus
        {
            public List<string> PatientNameList = new List<string> { };
            public void AdmitPatient(string PatientName)
            {
                PatientNameList.Add(PatientName);

                Console.WriteLine($"Patient {PatientName} admitted successfully.");
            }
            public void DischargePatient(string PatientName)
            {
                PatientNameList.Remove(PatientName);
                Console.WriteLine($"Patient {PatientName} discharged successfully.");
            }
        }
}
