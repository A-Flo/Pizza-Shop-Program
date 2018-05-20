using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class PizzaProgram
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Welcome to Audra's Pizza Joint!");
                Console.WriteLine("Would you like to order a Pizza?");
                string inputStr = Console.ReadLine();

                double smallPrice = 8.50;
                double medPrice = 9.50;
                double lgPrice = 10.50;
                double extraLgPrice = 11.50;

                Console.WriteLine("Great! We have many varieties! Here is our menu:");
                Console.WriteLine();
                Console.WriteLine("1. Small Cheese Pizza               $" + "{0:0.00}", smallPrice);
                Console.WriteLine("2. Medium Cheese Pizza              $" + "{0:0.00}", medPrice);
                Console.WriteLine("3. Large Cheese Pizza               $" + "{0:0.00}", lgPrice);
                Console.WriteLine("4. Extra Large Cheese Pizza         $" + "{0:0.00}", extraLgPrice);
                Console.WriteLine();
                Console.WriteLine("What Size Pizza Would You Like? Enter the number associated with the size.");
                string inputStr2 =  Console.ReadLine();
                int myInt = int.Parse(inputStr2);
      
                double smallTopPrice = 1.25;
                double medTopPrice = 2.00;
                double lgTopPrice = 2.75;
                double extraLgTopPrice = 3.50;

                Console.WriteLine("Costs for Each Additional Ingredient:");
                Console.WriteLine();
                Console.WriteLine("1. Small Pizza                      $" + "{0:0.00}", smallTopPrice);
                Console.WriteLine("2. Medium Pizza                     $" + "{0:0.00}", medTopPrice);
                Console.WriteLine("3. Large Pizza                      $" + "{0:0.00}", lgTopPrice);
                Console.WriteLine("4. Extra Large Pizza                $" + "{0:0.00}", extraLgTopPrice);
                Console.WriteLine();
                Console.WriteLine("Ingredients: (1 - Pepperoni, 2 - Sausage, 3 - Onions, 4 - Peppers, 5 - Mushrooms)");
                Console.WriteLine("How Many Ingredients would you like (0 - 5)?");
                string inputStr3 = Console.ReadLine();
                Console.WriteLine("Please provide the ingredient codes:");
                string inputStr4 = Console.ReadLine();
                int myInt2 = int.Parse(inputStr3);

                double pizzaPrice = myInt;
                double pizzaTopPrice = myInt2;
                double total = 0;
                double tax = 0;
                double totalPrice = 0;
                string pizzaSizeName = " ";

                if (myInt == 1){
                pizzaPrice = smallPrice;
                pizzaTopPrice = smallTopPrice * myInt2;
                pizzaSizeName = "Small";
              
                }
                else if (myInt == 2){
                pizzaPrice = medPrice;
                pizzaTopPrice = medTopPrice * myInt2;
                pizzaSizeName = "Medium";
            }
                else if (myInt == 3){
                pizzaPrice = lgPrice;
                pizzaTopPrice = lgTopPrice * myInt2;
                pizzaSizeName = "Large";

            }
                else if (myInt == 4){
                pizzaPrice = extraLgPrice;
                pizzaTopPrice = extraLgTopPrice * 2;
                pizzaSizeName = "Extra Large";
            }
     
                total = pizzaPrice + pizzaTopPrice;
                tax = 0.085 * total;
                totalPrice = total + tax;

                System.DateTime currentTime = System.DateTime.Now;
                System.TimeSpan waitingTime = new System.TimeSpan(0, 0, 25, 0);
                System.DateTime pickupAt = currentTime.Add(waitingTime);

                Console.WriteLine();
                Console.WriteLine("Here is your pizza order details.");
                Console.WriteLine("Thanks for your business!");
                Console.WriteLine();
                Console.WriteLine("You can pick it up in 25 minutes!");
                Console.WriteLine("Time Ordered: " + string.Format("{0:hh:mm:ss tt}", currentTime) + "          Pick Up At: " + string.Format("{0:hh:mm:ss tt}", pickupAt));
                Console.WriteLine("Size:                        " + pizzaSizeName);
                Console.WriteLine("Ingredients:                 " + inputStr3);
                Console.WriteLine("Pizza Price:                 $" + "{0:0.00}", total);
                Console.WriteLine("Tax:                         $" + "{0:0.00}", tax);
                Console.WriteLine("Total Price:                 $" + "{0:0.00}", totalPrice);
                Console.WriteLine("                             Have a great day!");
                string inputStr5 = Console.ReadLine();
            }
        }
    }

