using CollegeManagement;
// Student.PrintHeader();
// var student1 = new Student("Rakesh Tharu",24, new DateTime(2000,03,14), 'M');
// student1.PrintDetails();

// var student2 = new Student("Ashish Chy", 25, new DateTime(1998,05,22),'M');
// student2.PrintDetails();

// var student = new Student("Hello World", 22, new DateTime(2001,12,12), 'M');
// student.PrintDetails();


// Methods m = new();
// m.SayHello();
// m.SayHello("Hii !");

// var av = m.GetAverage(23,45,67,324324,234234,3433);
// var (Sum, Average) = m.GetResult(23,34,34,3434);

// Generics g = new();
// g.Print<decimal>(234.234234m);
// g.Print<string>("Hello");

//Using IF/ELse
// ElectricityBill eb = new();
// eb.Main();


//UsingSwitchCase
// ElectricityBillUsingSwitch ebs = new();
// ebs.Main();

// Student.PrintHeader();

// var student = new Student("Sita Bond", 68, new DateTime(1990, 1, 11), 'F');
// student.Resume = "";
// student.PrintDetails();

// var student3 = new Student("James Bond", 67, new DateTime(1990, 1, 11), 'F');
// student3.PrintDetails();

// var student4 = new Student("Rakeesh Bond", 798, new DateTime(2000, 1, 11), 'M');
// student4.PrintDetails();

// Teacher.PrintHeader();
// var teacher1 = new Teacher("Rakeesh Rana", "MS Computer Science", new DateTime(2000, 1, 11), 'M');
// teacher1.PrintDetails();
// var teacher2 = new Teacher("Rakeesh Rana", "MS Computer Science", new DateTime(2000, 1, 11), 'M');
// teacher2.PrintDetails();

// Admin.PrintHeader();
// var admin1 = new Admin("Iron man", "Administrator", new DateTime(1998, 09, 11), 'M');
// admin1.PrintDetails();
// var admin2 = new Admin("Loki", "Lab Assistant", new DateTime(1990, 12, 11), 'M');
// admin2.PrintDetails();

FileAndFolderHandler f1 = new();
//f1.CreateFile();
f1.ReadFile();

//f1.CreateFolder("TestFolder");
f1.ReadCsv();

// dotnet new console -n appname