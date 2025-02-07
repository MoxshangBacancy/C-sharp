using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS;

namespace task7
{
 
   public partial class PatientStatus
        {
            public List<Patient> PatientNameList = new List<Patient> { };
            public void AdmitPatient(Patient PatientName)
            {
                PatientNameList.Add(PatientName);

                Console.WriteLine($"Patient {PatientName} admitted successfully.");
            }
            public void DischargePatient(Patient PatientName)
            {
                PatientNameList.Remove(PatientName);
                Console.WriteLine($"Patient {PatientName} discharged successfully.");
            }
        }

}
