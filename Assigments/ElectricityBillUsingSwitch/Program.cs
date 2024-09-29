public class ElectricityBillUsingSwitch
{
    static void Main()
    {
        Console.Write("Enter the number of electricity units consumed: ");
        int units = Convert.ToInt32(Console.ReadLine());

        decimal totalAmount = ElectricityBill.CalculateBill(units);

        Console.WriteLine($"Total amount due: Rs {totalAmount}");
    }

    
}