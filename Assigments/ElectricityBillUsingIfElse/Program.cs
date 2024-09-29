 Console.WriteLine("Enter the number of Units consumed : ");
        //int units = int.Parse(Console.ReadLine());
       int units = Convert.ToInt32(Console.ReadLine());

        decimal totalAmount = ElectricityBill.CalculateBill(units);

        Console.WriteLine($"Total amount of bill is Rs. {totalAmount}");