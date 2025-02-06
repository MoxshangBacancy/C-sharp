using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
        public partial class PatientStatus
        {
            public void ScheduleAppointment()
            {
                Console.WriteLine("Your appointment is booked for {0}", DateTime.Now);

            }
            public void DisplayPatients()
            {
                foreach (string patient in PatientNameList)
                {
                    Console.WriteLine(patient);
                }
            }
         }
}
