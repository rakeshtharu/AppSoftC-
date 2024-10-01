          using PeopleManagement;

                          

            // Step 1: Parse the CSV file
            var parser = new CSVParser();
            List<Person> people = parser.ParseCsv();

            // Step 2: Generate reports
            var report = new PeopleReport();
            report.SaveMales(people);
            report.SaveFemales(people);
            report.SaveDotComUsers(people);

            Console.WriteLine("Reports generated successfully.");