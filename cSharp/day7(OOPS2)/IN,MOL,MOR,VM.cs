using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task7;

namespace HMS
{
    class Person: HospitalService
    {
        public string Name;
        public int Age;
        public Person()
        {
            Console.WriteLine("Person Constructor called using base keyword in child class");
        }
        public virtual void DisplayInfo(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public override void GetServiceType()
        {
            Console.WriteLine("Choose 1 for general service and 2 for special service");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("General Service");
                    break;
                case 2:
                    Console.WriteLine("Special Service");
                    break;
                default:
                    Console.WriteLine("Choose a service");
                    break;
            }
        }

    }
    
    class Patient : Person
    {
        private string Symptoms;
        public Patient(): base()
        {
            
        }
        public override void DisplayInfo(string Name, int Age).
        {
            base.DisplayInfo(Name, Age);
            //this.Name = Name;
            //this.Age = Age;
            Console.WriteLine("Name is {0} and Age is {1}",Name,Age);
        }
        public void GetSymptoms(string Symptoms)
        {
            this.Symptoms = Symptoms.Trim();
        }
    }
    
    class Doctor : Person
    {
        private string Department;
        public Doctor() : base()
        {

        }
        public override void DisplayInfo(string Name, int Age)
        {
            base.DisplayInfo(Name, Age);
            //this.Name = Name;
            //this.Age = Age;
            Console.WriteLine("Name is {0} and Age is {1}", Name, Age);
        }

        public void ScheduleAppointment(string patientName)
        {
            Console.WriteLine("Patient Name is {0}", patientName);
        }
        public void ScheduleAppointment(string patientName, DateTime appointmentDate)
        {
            Console.WriteLine("Appointment made for {0}, the time and date is {1}", patientName, appointmentDate);
        
        }

    }

}
