Console.WriteLine("\n\n\n\n\n\n");
Dentist dentist = new Dentist("Dr. Jhatka", 45, "Nepal", "Orthodontist");
dentist.DisplayInfo();
dentist.PrescribeMedicine();
dentist.Treat();

Console.WriteLine("============================\n\n");

Patient patient = new Patient("Iron Man", 55, "New York", "Infection");
patient.DisplayInfo();
patient.PrescribeMedicine();
patient.Treat();

Console.WriteLine("============================\n\n");

CriticalPatient criticalPatient = new CriticalPatient("Doctor Strange", 60, "Florida Miami", "Multiple Fracture", "ICU");
criticalPatient.DisplayInfo();

Console.WriteLine("==============================\n\n");

Admin admin = new Admin("Rakesh Tharu", 40, "Dhangadhi", "IT");
admin.DisplayInfo();


