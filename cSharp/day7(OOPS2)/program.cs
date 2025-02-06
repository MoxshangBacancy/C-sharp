using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using HMS;
using task7;
class program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        Patient patient = new Patient();
        Doctor doctor = new Doctor();
        HospitalManager admin = new HospitalManager();
        MedicalRecordDatabase medicalRecordDatabase = new MedicalRecordDatabase();
        PatientStatus patientStatus = new PatientStatus();

       //User Details Input
        Console.WriteLine("Enter your name and age (e.g., John 25):");
        string input = Console.ReadLine(); 

        string[] parts = input.Split(' '); 
        string name = parts[0]; 

        if (parts.Length >= 2) 
        {
            if (int.TryParse(parts[1], out int age))
            {
                patient.DisplayInfo(name, age);
            }
            else
            {
                Console.WriteLine("Invalid age. Please enter a valid number.");
            }
       }
        else
        {
            Console.WriteLine("Invalid input format. Please enter both name and age.");
        }

       // Switch Case.
        Console.WriteLine("Select Panel:" + " Press 1 for Patient Panel, 2 for Doctor Panel, 3 for Admin Panel, 4 for service type, 5 for partial class methods");
        string choice = Console.ReadLine();
        int number = int.Parse(choice); 
        switch(number){
            case 1:
                Console.WriteLine("welcome to Patient Panel");
                Console.WriteLine("How are you feeling");
                string symptoms = Console.ReadLine();
                patient.GetSymptoms(symptoms);
                break;
            case 2:
                Console.WriteLine("Welcome to Doctor Panel");

                doctor.ScheduleAppointment(name);
                doctor.ScheduleAppointment(name, DateTime.Now);
                break;
            case 3:
                Console.WriteLine("Welcome to Admin Panel");
                admin.AdmitPatient(patient);
                admin.DischargePatient(patient);       
                admin.DisplayPatients();
                break;
            case 4:
                person.GetServiceType();
                person.PrintHospitalPolicy();
                medicalRecordDatabase.LogMedicalRecord(name, "Fever");
                break;
            case 5:
                patientStatus.AdmitPatient(name);
                patientStatus.DischargePatient(name);
                patientStatus.ScheduleAppointment();
                patientStatus.DisplayPatients();
                break;
            default:
                Console.WriteLine("Please select a choice");
                break;
        }
    }

}
