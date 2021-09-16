using System;

/*
Author: J-Zach Loke
Class: CMPS-378
Due Date: 09/16/2021
Description:
    This program determines the most efficient way (least amount of coins) to dispense change from a transaction.
    Has an option on whether or not to 50c coins should be dispensed.
*/

namespace Assignment1
{
    class ChangeCalculator
    {
        static void Main(string[] args)
        {
            // collect inputs of the user
            Console.WriteLine("This program will determine the least amount of coins to dispense as change from a purchase.");
            Console.Write("Enter the product price without the \"$\": ");
            var price = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter the amount the customer paid without the \"$\": ");
            var paid = Convert.ToSingle(Console.ReadLine());
            Console.Write("Should we use 50c coins (y/n)? ");
            var use_50c = Console.ReadLine();

            price = (paid - price) % 1;    // don't hand out coins when bills can be used
            if (price > 0) {   // if the customer did not give exact change
                Console.WriteLine($"After handing out dollar bills, the value of the change is ${price}");  // show the value of the change needed to be dispensed

                // determine the amount of each denomination of coin to be used
                int fifties = 0;
                if (use_50c == "y") {
                    fifties = CalcCoinAmt(0.5F, ref price);
                }
                int quarters = CalcCoinAmt(0.25F, ref price);
                int dimes = CalcCoinAmt(0.1F, ref price);
                int nickels = CalcCoinAmt(0.05F, ref price);
                int pennies = CalcCoinAmt(0.01F, ref price);

                // output results
                Console.WriteLine("The change that should be dispensed is:");
                Console.WriteLine($"\t50c    : {fifties}");
                Console.WriteLine($"\tquarter: {quarters}");
                Console.WriteLine($"\tdime   : {dimes}");
                Console.WriteLine($"\tnickel : {nickels}");
                Console.WriteLine($"\tpenny  : {pennies}");
            }
            else if (price < 0) { // if the customer did not give enough money to make the purchas
                Console.WriteLine("Customer did not give enough money to pay for this transaction.");
            }
            else {  // if the customer gave out exact change
                Console.WriteLine("Customer has given exact change and no coins need to be dispensed.");
            }
            Console.ReadKey();
        }

        static int CalcCoinAmt(float coinValue, ref float price)
        {
            /* Calculates the maximum amount of one coin type that can be used without going over the price
            and also lowers the price for every coin used.

            Args:
                coinValue (float): the value of the coin denomination (ie. quarters should be 0.25f)
                price (ref float): the price to calculate up to

            Returns:
                coinCount (int): the number of coins used
            */
            int coinCount = 0;
            while (price >= coinValue) {
                coinCount++;
                price -= coinValue;
            }
            return coinCount;
        }
    }
}