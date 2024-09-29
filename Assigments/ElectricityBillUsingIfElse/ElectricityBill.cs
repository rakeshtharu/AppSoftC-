public class ElectricityBill {

public int units;
public static decimal CalculateBill(int units)
{
    decimal amount = 0;
    if (units >= 1 && units <=20)
    {
        amount = 100;
    }
    else if(units >= 21 && units <=25){
       // amount = 5*units;
       amount = 100 +(units-20) *5;
    }
    else if(units >= 26 && units <=50){
        // amount = 10*units;
         amount = 100 + 25 * 5 + (units - 25) * 10;
    }
    else{
        amount = 5000;
    }
    return amount;
    
}
}