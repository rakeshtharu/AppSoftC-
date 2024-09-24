public class ElectricityBill{
public static decimal CalculateBill(int units)
    {
        decimal amount = 0;

        switch (units)
        {
            case <= 20:
                amount = 100;
                break;
            case <= 25:
                amount = 100 + (units - 20) * 5;
                break;
            case <= 50:
                amount = 100 + 25 * 5 + (units - 25) * 10;
                break;
            default:
                amount = 2000;
                break;
        }

        return amount;
    }

}