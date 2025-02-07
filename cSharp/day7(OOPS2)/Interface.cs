using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS;

namespace task7
{
    interface IHospitalOperations
    {
        void AdmitPatient(Patient patient);
        void DischargePatient(Patient patient);
        void DisplayPatients();
    }
    class HospitalManager : IHospitalOperations
    {
        public List<Patient> PatientNameList = new List<Patient> { };

        PatientStatus pat = new PatientStatus();

        void IHospitalOperations.AdmitPatient(Patient patient)
        {

            //PatientNameList.Add(patient);
            pat.AdmitPatient(patient);

            //Console.WriteLine($"Patient {patient.Name} admitted successfully.");

        }
        void IHospitalOperations.DischargePatient(Patient patient)
        {
            PatientNameList.Remove(patient);
            Console.WriteLine($"Patient {patient.Name} discharged successfully.");
        }
        void IHospitalOperations.DisplayPatients()
        {
            foreach (Patient patient in PatientNameList)
            {
                Console.WriteLine(patient.Name);
            }
        }
    }
}
