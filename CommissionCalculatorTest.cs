using System;

class CommissionCalculatorTest
{
    static void Main()
    {
        CommissionCalculator commissionCalculator = new CommissionCalculator();


        int soldItemCounter = 1;

        decimal total = 0;

        double commission = 0.09;

        decimal wage = 200;


        while(true)
        {
            Console.Write($"Please enter the value of sold item {soldItemCounter} or -1 to quit: ");
            decimal commissionCalculatortheSoldItem = decimal.Parse(Console.ReadLine());
            commissionCalculator.SetSoldItem(commissionCalculatortheSoldItem);


            ++soldItemCounter;

            total = (decimal)(commissionCalculator.GetSoldItem() + total);

            decimal totalToPay = total * (decimal)commission + wage;


            if (commissionCalculatortheSoldItem == -1)
            {
                Console.WriteLine($"\nThe total value of the sold item(s) is: {total}");
                Console.WriteLine($"\nThe weekly salary with commission is: {totalToPay}\n");
                break;
            }

        }

        Console.WriteLine("\nThank you and see you soon!");

    }
}

