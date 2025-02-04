    using System;


    public class Patient
    {
        public int PatientID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        private string Disease { get; set; }

        public void GetDisease(string disease){ Console.WriteLine(disease); }

        public void GetPatientDetails()
        {
            Console.Write(PatientID+",");
            Console.Write(Name+",");
            Console.Write(Age);
            Console.WriteLine("");

        }

        public Patient(int id, string name, int age) { 
            PatientID = id;
            Name = name;
            Age = age;
        }

        ~Patient()
        {
            Console.WriteLine("Patient is Discharged");
        }

    }
    public class Doctor
    {
        public string Name { get; set; }
    }
    namespace task6
    {
        class program
        {
            public static void Main(String[] args)
            {
                Doctor doc = new Doctor();
                Console.WriteLine("Doctors Added: ");
                Console.WriteLine(doc.Name = "Doc1");
                Console.WriteLine(doc.Name = "Doc2");
                Console.WriteLine(doc.Name = "Doc3");


                Console.WriteLine("Patients Added: ");
                Patient Pat1 = new Patient(101, "Pat1", 31);
                Pat1.GetPatientDetails();
                Patient Pat2 = new Patient(102, "Pat2", 32);
                Pat2.GetPatientDetails();
                Patient Pat3 = new Patient(103, "Pat3", 33);
                Pat3.GetPatientDetails();
                Patient Pat4 = new Patient(104, "Pat4", 34);
                Pat4.GetPatientDetails();
                Patient Pat5 = new Patient(105, "Pat5", 35);
                Pat5.GetPatientDetails();

                Console.WriteLine("Patients Disease: ");
                Pat1.GetDisease("Xyz");




            }

        }
    }
