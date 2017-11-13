using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace CoffteaZonePos
{

  
    class Program
    {
        // All Required Containers Goes In here
        public static int globalCategoryNumber;
        public static int quantity;
        public static string Answer;
        public static int OrderNumberVal  = 0;
        public static bool OrderNumberConfirm = false;
        public static string[] OrdersName = new string[20];
        public static int[] OrdersNumber = new int[20];
        public static double totalOrder;
        public static double[] OrdersPrice = new double[20];
        public static int orderCount = 0;
        public static int AddIdentifier;
        public static int OrderMax;
        public static string StarterTitle = "Starter\t\t\t\t\t\t\tPrice";
        public static string[] Starter = new string[5] {
            "1.Hash Brown ( 2 pcs )", "2.Chicharap",
            "3.Achara" , "4.Kimchi", "5.Fries"

        };
        public static double[] StarterPrices = new double[5] {
            50.00 , 50.00 , 50.00 ,
            60.00 , 60.00
        };

        public static string PizzaTitle = "PIZZA\t\t\t\t\t\t\tPrice";
        public static string[] Pizza = new string[5] { 
            "6.Hawaiian" , "7.Pepperoni" , "8.Margherita" ,
            "9.Three Cheese" , "10.All Meat Lovers"
        };
        public static double[] PizzaPrices = new double[5] { 
           250.00 , 250.00 , 250.00,
           250.00 , 280.00
        };

        public static string MainCourseTitle = "MAIN COURSE\t\t\t\t\t\tPrice";
        public static string[] MainCourse = new string[5] { 
            "11.Tapsilog" , "12.Tocilog" , 
            "13.Noksilog" , "14.Chicken BBQ",
            "15.Buttered Garlic Chicken"
        };
        public static double[] MainCoursePrices = new double[5] {
            80.00 , 80.00 , 
            99.00 , 88.00 ,
            120.00
        };

        public static string BurgerAndSandwichesTitle = "BURGER'S AND SANDWICHES\t\t\t\t\tPrice";
        public static string[] BurgerAndSandwiches = new string[5] { 
            "16.Chicken Sandwich" , "17.Ham and Egg Sandwich" ,
            "18.German Franks Hotdog"  ,"19.Angus Beef Hotdog" , 
            "20.Cheese Burger"
        };
        public static double[] BurgerAndSandwichesPrices = new double[5] {
            70.00 , 70.00 , 
            80.00 , 80.00 , 
            100.00
        };

        public static string PlatterTitle = "Platter \t\t\t\t\t\tPrice";
        public static string[] Platter = new string[5] { 
            "21.Pancit Guisado" , "22.Pancit Canton" , 
            "23.Sizzling Tofu" , "24.Sizzling Tofu"  ,
            "25.Chop Suey"
        };
        public static double[] PlatterPrice = new double[5] { 
            150.00 , 150.00 , 
            120.00 , 150.00 , 
            150.00
        };

        public static string HotDrinksTitle = "Hot Drinks\t\t\t\t\t\tPrice";
        public static string[] HotDrinks = new string[5] { 
            "26.Brewed Coffee" , "27.Café Americano" , 
            "28.Café Latte"  , "29.Cappucino" ,
            "30.Café Mocha"
        };
        public static double[] HotDrinksPrices = new double[5] {
            55.00 , 70.00 , 
            80.00 , 80.00 ,
            90.00
        };

        public static string IcedCoffeeTitle = "Iced Coffee\t\t\t\t\t\tPrice";
        public static string[] IcedCoffee = new string[5] {
            "31.Iced Americano" , "32.Iced Latte" ,
            "33.Iced Mocha" , "34.Iced White Mocha" ,
            "35.Iced Caramel"
        };
        public static double[] IcedCoffeePrices = new double[5] { 
            70.00 , 80.00 , 
            90.00 , 90.00 , 
            90.00
        };
        // this Pause method will pause all neccesary 
        public static void Pause(int checkforExit)
        {
            // 1 is for exit the program
            // 2 is for pausing the program
            if (checkforExit == 1)
            {
                Console.WriteLine("Press Any Key to Exit the Program....");
                Console.ReadKey();
            }
            else if (checkforExit == 2)
            {
                Console.WriteLine("Press any key to Continue....");
                Console.ReadKey();
            }
        }
        public static void Delete()
        {
            Console.WriteLine("Hello World");
            Console.ReadKey();
        }
        public static void checkForOrderCount(int orderCountMax) {
            // check the reach capacity of 20 orders
            Console.WriteLine("your order is now: " + orderCountMax);
            
            if (orderCountMax == 20)
            {
                Console.WriteLine("You Reach Maximum of 20 Orders...");
                Console.WriteLine("Please Replace your Orders Or Delete Your Orders");
                Console.WriteLine("1.Delete your orders");
                Console.WriteLine("2. Update your orders");
                Console.Write("Select What do you want in your order:");
                OrderMax = Convert.ToInt32(Console.ReadLine());
                    
                // call the update function to replace or update the orders
                if (OrderMax == 1)
                {
                    Console.Clear();
                    Update();
                    // delete orders individually or all
                } else if (OrderMax == 2) {
                    Console.Clear();
                    Delete();
                }
            }
        }
        public static void AddProcessOrder()
        {
            while (true)
            { 
                
         
                if (AddIdentifier == 1) {
                    //checkForOrderCount(orderCount);
                    if (OrderNumberConfirm == false)
                    {

                        EatRepeat:
                        EatRepeatTwo:
                        ConfirmReapeat:
                        Console.Write("please Choose You Want to Eat:");
                        OrderNumberVal = Convert.ToInt32(Console.ReadLine());
                        if (OrderNumberVal.GetType() == typeof(Int32) || OrderNumberVal.GetType() == typeof(int))
                        {
                            OrderNumberConfirm = true;
                            if(OrderNumberVal == 1) {
                                OrdersName[orderCount] = Starter[0];
                                OrdersPrice[orderCount] = StarterPrices[0];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;   
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                } else if (orderCount < 20){
                                    checkForOrderCount(orderCount);
                                }
                            } else if (OrderNumberVal == 2) {
                                OrdersName[orderCount] = Starter[1];
                                OrdersPrice[orderCount] = StarterPrices[1];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            } else if (OrderNumberVal == 3) {
                                OrdersName[orderCount] = Starter[2];
                                OrdersPrice[orderCount] = StarterPrices[2];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            } else if (OrderNumberVal == 4) {
                                OrdersName[orderCount] = Starter[3];
                                OrdersPrice[orderCount] = StarterPrices[3];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 5) {
                                OrdersName[orderCount] = Starter[4];
                                OrdersPrice[orderCount] = StarterPrices[4];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else
                            {
                                Console.WriteLine("invalid Input Please Try Again");
                                //Pause(2);
                                goto EatRepeatTwo;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong Input");
                            Pause(2);
                            goto EatRepeat;
                        }
                       if (OrderNumberConfirm == true)
                        {

                        RepeatAgain:
                            OrderNumberConfirm = false;
                            Console.WriteLine("1. yes");
                            Console.WriteLine("2. no");
                            Console.Write("you want to add another order:");
                          
                            OrderNumberVal = Convert.ToInt32(Console.ReadLine());
                            if (OrderNumberVal == 1) {
                             
                                goto ConfirmReapeat;
                            }
                            else if (OrderNumberVal == 2)
                            {
                                // ouput the total of the orders
                                int iii;
                                for (iii = 0; iii < OrdersPrice.Length; iii++)
                                {
                                    totalOrder += OrdersPrice[iii];
                                }
                                Console.Write("The total is:" + totalOrder);
                                Console.WriteLine();
                                Console.WriteLine("1. Update the particular order");
                                Console.WriteLine("2. Delete the all the order or particular order");
                                Console.WriteLine("3. Add another Order in Main Menu:");
                                Console.WriteLine("4. Get The Receipt");
                            repeatAgainTwo:
                                Console.Write("What do you want: ");

                                OrderNumberVal = Convert.ToInt32(Console.ReadLine());
                                if (OrderNumberVal == 1)
                                {
                                    Console.Clear();
                                    Update();
                                    break;
                                }
                                else if (OrderNumberVal == 2)
                                {
                                    Console.Clear();
                                    Delete();
                                    break;
                                }
                                else if (OrderNumberVal == 3)
                                {
                                    Console.Clear();
                                    Add();

                                    break;
                                }
                                else if (OrderNumberVal == 4)
                                {
                                    Console.Clear();
                                    PrintReceipt();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("invalid input please repeat again!");
                                    goto repeatAgainTwo;
                                }
                                // check if they are not the same;
                            } else if (OrderNumberVal !=  1 && OrderNumberVal != 2) {
                   
                                Console.WriteLine("invalid Input");
                                goto RepeatAgain;
                            }
                            
                        }
                        else
                        {

                        }
                    }
                }
                else if (AddIdentifier == 2)
                {
                    //checkForOrderCount(orderCount);
                    if (OrderNumberConfirm == false)
                    {

                    EatRepeat:
                    EatRepeatTwo:
                    ConfirmReapeat:
                        Console.Write("please Choose You Want to Eat:");
                        OrderNumberVal = Convert.ToInt32(Console.ReadLine());
                        if (OrderNumberVal.GetType() == typeof(Int32) || OrderNumberVal.GetType() == typeof(int))
                        {
                            OrderNumberConfirm = true;
                            if (OrderNumberVal == 6)
                            {
                                OrdersName[orderCount] = Pizza[0];
                                OrdersPrice[orderCount] =  PizzaPrices[0];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 7)
                            {
                                OrdersName[orderCount] = Pizza[1];
                                OrdersPrice[orderCount] = PizzaPrices[1];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 8)
                            {
                                OrdersName[orderCount] = Pizza[2];
                                OrdersPrice[orderCount] = PizzaPrices[2];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 9)
                            {
                                OrdersName[orderCount] = Pizza[3];
                                OrdersPrice[orderCount] = PizzaPrices[3];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 10)
                            {
                                OrdersName[orderCount] = Pizza[4];
                                OrdersPrice[orderCount] = PizzaPrices[4];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else
                            {
                                Console.WriteLine("invalid Input Please Try Again");
                                //Pause(2);
                                goto EatRepeatTwo;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong Input");
                            Pause(2);
                            goto EatRepeat;
                        }
                        if (OrderNumberConfirm == true)
                        {

                        RepeatAgain:
                            OrderNumberConfirm = false;
                            Console.WriteLine("1. yes");
                            Console.WriteLine("2. no");
                            Console.Write("you want to add another order:");

                            OrderNumberVal = Convert.ToInt32(Console.ReadLine());
                            if (OrderNumberVal == 1)
                            {

                                goto ConfirmReapeat;
                            }
                            else if (OrderNumberVal == 2)
                            {
                                // ouput the total of the orders
                                int iii;
                                for (iii = 0; iii < OrdersPrice.Length; iii++)
                                {
                                    totalOrder += OrdersPrice[iii];
                                }
                                Console.Write("The total is:" + totalOrder);
                                Console.WriteLine();
                                Console.WriteLine("1. Update the particular order");
                                Console.WriteLine("2. Delete the all the order or particular order");
                                Console.WriteLine("3. Add another Order in Main Menu:");
                                Console.WriteLine("4. Get The Receipt");
                            repeatAgainTwo:
                                Console.Write("What do you want: ");

                                OrderNumberVal = Convert.ToInt32(Console.ReadLine());
                                if (OrderNumberVal == 1)
                                {
                                    Console.Clear();
                                    Update();
                                    break;
                                }
                                else if (OrderNumberVal == 2)
                                {
                                    Console.Clear();
                                    Delete();
                                    break;
                                }
                                else if (OrderNumberVal == 3)
                                {
                                    Console.Clear();
                                    Add();

                                    break;
                                }
                                else if (OrderNumberVal == 4)
                                {
                                    Console.Clear();
                                    PrintReceipt();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("invalid input please repeat again!");
                                    goto repeatAgainTwo;
                                }
                                // check if they are not the same;
                            }
                            else if (OrderNumberVal != 1 && OrderNumberVal != 2)
                            {

                                Console.WriteLine("invalid Input");
                                goto RepeatAgain;
                            }
                            
                        }
                        else
                        {

                        }
                    }
                }

                else if (AddIdentifier == 3)
                {
                    //checkForOrderCount(orderCount);
                    if (OrderNumberConfirm == false)
                    {

                    EatRepeat:
                    EatRepeatTwo:
                    ConfirmReapeat:
                        Console.Write("please Choose You Want to Eat:");
                        OrderNumberVal = Convert.ToInt32(Console.ReadLine());
                        if (OrderNumberVal.GetType() == typeof(Int32) || OrderNumberVal.GetType() == typeof(int))
                        {
                            OrderNumberConfirm = true;
                            if (OrderNumberVal == 11)
                            {
                                OrdersName[orderCount] = MainCourse[0];
                                OrdersPrice[orderCount] = MainCoursePrices[0];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 12)
                            {
                                OrdersName[orderCount] = MainCourse[1];
                                OrdersPrice[orderCount] = MainCoursePrices[1];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 13)
                            {
                                OrdersName[orderCount] = MainCourse[2];
                                OrdersPrice[orderCount] = MainCoursePrices[2];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 14)
                            {
                                OrdersName[orderCount] = MainCourse[3];
                                OrdersPrice[orderCount] = MainCoursePrices[3];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 15)
                            {
                                OrdersName[orderCount] = MainCourse[4];
                                OrdersPrice[orderCount] = MainCoursePrices[4];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else
                            {
                                Console.WriteLine("invalid Input Please Try Again");
                                //Pause(2);
                                goto EatRepeatTwo;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong Input");
                            Pause(2);
                            goto EatRepeat;
                        }
                        if (OrderNumberConfirm == true)
                        {

                        RepeatAgain:
                            OrderNumberConfirm = false;
                            Console.WriteLine("1. yes");
                            Console.WriteLine("2. no");
                            Console.Write("you want to add another order:");

                            OrderNumberVal = Convert.ToInt32(Console.ReadLine());
                            if (OrderNumberVal == 1)
                            {

                                goto ConfirmReapeat;
                            }
                            else if (OrderNumberVal == 2)
                            {
                                // ouput the total of the orders
                                int iii;
                                for (iii = 0; iii < OrdersPrice.Length; iii++)
                                {
                                    totalOrder += OrdersPrice[iii];
                                }
                                Console.Write("The total is:" + totalOrder);
                                Console.WriteLine();
                                Console.WriteLine("1. Update the particular order");
                                Console.WriteLine("2. Delete the all the order or particular order");
                                Console.WriteLine("3. Add another Order in Main Menu:");
                                Console.WriteLine("4. Get The Receipt");
                            repeatAgainTwo:
                                Console.Write("What do you want: ");

                                OrderNumberVal = Convert.ToInt32(Console.ReadLine());
                                if (OrderNumberVal == 1)
                                {
                                    Console.Clear();
                                    Update();
                                    break;
                                }
                                else if (OrderNumberVal == 2)
                                {
                                    Console.Clear();
                                    Delete();
                                    break;
                                }
                                else if (OrderNumberVal == 3)
                                {
                                    Console.Clear();
                                    Add();

                                    break;
                                }
                                else if (OrderNumberVal == 4)
                                {
                                    Console.Clear();
                                    PrintReceipt();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("invalid input please repeat again!");
                                    goto repeatAgainTwo;
                                }
                                // check if they are not the same;
                            }
                            else if (OrderNumberVal != 1 && OrderNumberVal != 2)
                            {

                                Console.WriteLine("invalid Input");
                                goto RepeatAgain;
                            }

                        }
                        else
                        {

                        }
                    }
                }

                else if (AddIdentifier == 4)
                {
                    //checkForOrderCount(orderCount);
                    if (OrderNumberConfirm == false)
                    {

                    EatRepeat:
                    EatRepeatTwo:
                    ConfirmReapeat:
                        Console.Write("please Choose You Want to Eat:");
                        OrderNumberVal = Convert.ToInt32(Console.ReadLine());
                        if (OrderNumberVal.GetType() == typeof(Int32) || OrderNumberVal.GetType() == typeof(int))
                        {
                            OrderNumberConfirm = true;
                            if (OrderNumberVal == 16)
                            {
                                OrdersName[orderCount] = BurgerAndSandwiches[0];
                                OrdersPrice[orderCount] = BurgerAndSandwichesPrices[0];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 17)
                            {
                                OrdersName[orderCount] = BurgerAndSandwiches[1];
                                OrdersPrice[orderCount] = BurgerAndSandwichesPrices[1];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 18)
                            {
                                OrdersName[orderCount] = BurgerAndSandwiches[2];
                                OrdersPrice[orderCount] = BurgerAndSandwichesPrices[2];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 19)
                            {
                                OrdersName[orderCount] = BurgerAndSandwiches[3];
                                OrdersPrice[orderCount] = BurgerAndSandwichesPrices[3];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 20)
                            {
                                OrdersName[orderCount] = BurgerAndSandwiches[4];
                                OrdersPrice[orderCount] = BurgerAndSandwichesPrices[4];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else
                            {
                                Console.WriteLine("invalid Input Please Try Again");
                                //Pause(2);
                                goto EatRepeatTwo;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong Input");
                            Pause(2);
                            goto EatRepeat;
                        }
                        if (OrderNumberConfirm == true)
                        {

                        RepeatAgain:
                            OrderNumberConfirm = false;
                            Console.WriteLine("1. yes");
                            Console.WriteLine("2. no");
                            Console.Write("you want to add another order:");

                            OrderNumberVal = Convert.ToInt32(Console.ReadLine());
                            if (OrderNumberVal == 1)
                            {

                                goto ConfirmReapeat;
                            }
                            else if (OrderNumberVal == 2)
                            {
                                // ouput the total of the orders
                                int iii;
                                for (iii = 0; iii < OrdersPrice.Length; iii++)
                                {
                                    totalOrder += OrdersPrice[iii];
                                }
                                Console.Write("The total is:" + totalOrder);
                                Console.WriteLine();
                                Console.WriteLine("1. Update the particular order");
                                Console.WriteLine("2. Delete the all the order or particular order");
                                Console.WriteLine("3. Add another Order in Main Menu:");
                                Console.WriteLine("4. Get The Receipt");
                            repeatAgainTwo:
                                Console.Write("What do you want: ");

                                OrderNumberVal = Convert.ToInt32(Console.ReadLine());
                                if (OrderNumberVal == 1)
                                {
                                    Console.Clear();
                                    Update();
                                    break;
                                }
                                else if (OrderNumberVal == 2)
                                {
                                    Console.Clear();
                                    Delete();
                                    break;
                                }
                                else if (OrderNumberVal == 3)
                                {
                                    Console.Clear();
                                    Add();

                                    break;
                                }
                                else if (OrderNumberVal == 4)
                                {
                                    Console.Clear();
                                    PrintReceipt();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("invalid input please repeat again!");
                                    goto repeatAgainTwo;
                                }
                                // check if they are not the same;
                            }
                            else if (OrderNumberVal != 1 && OrderNumberVal != 2)
                            {

                                Console.WriteLine("invalid Input");
                                goto RepeatAgain;
                            }

                        }
                        else
                        {

                        }
                    }
                }

                else if (AddIdentifier == 5)
                {
                    //checkForOrderCount(orderCount);
                    if (OrderNumberConfirm == false)
                    {

                    EatRepeat:
                    EatRepeatTwo:
                    ConfirmReapeat:
                        Console.Write("please Choose You Want to Eat:");
                        OrderNumberVal = Convert.ToInt32(Console.ReadLine());
                        if (OrderNumberVal.GetType() == typeof(Int32) || OrderNumberVal.GetType() == typeof(int))
                        {
                            OrderNumberConfirm = true;
                            if (OrderNumberVal == 21)
                            {
                                OrdersName[orderCount] = Platter[0];
                                OrdersPrice[orderCount] = PlatterPrice[0];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 22)
                            {
                                OrdersName[orderCount] = Platter[1];
                                OrdersPrice[orderCount] = PlatterPrice[1];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 23)
                            {
                                OrdersName[orderCount] = Platter[2];
                                OrdersPrice[orderCount] = PlatterPrice[2];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 24)
                            {
                                OrdersName[orderCount] = Platter[3];
                                OrdersPrice[orderCount] = PlatterPrice[3];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 25)
                            {
                                OrdersName[orderCount] = Platter[4];
                                OrdersPrice[orderCount] = PlatterPrice[4];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else
                            {
                                Console.WriteLine("invalid Input Please Try Again");
                                //Pause(2);
                                goto EatRepeatTwo;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong Input");
                            Pause(2);
                            goto EatRepeat;
                        }
                        if (OrderNumberConfirm == true)
                        {

                        RepeatAgain:
                            OrderNumberConfirm = false;
                            Console.WriteLine("1. yes");
                            Console.WriteLine("2. no");
                            Console.Write("you want to add another order:");

                            OrderNumberVal = Convert.ToInt32(Console.ReadLine());
                            if (OrderNumberVal == 1)
                            {

                                goto ConfirmReapeat;
                            }
                            else if (OrderNumberVal == 2)
                            {
                                // ouput the total of the orders
                                int iii;
                                for (iii = 0; iii < OrdersPrice.Length; iii++)
                                {
                                    totalOrder += OrdersPrice[iii];
                                }
                                Console.Write("The total is:" + totalOrder);
                                Console.WriteLine();
                                Console.WriteLine("1. Update the particular order");
                                Console.WriteLine("2. Delete the all the order or particular order");
                                Console.WriteLine("3. Add another Order in Main Menu:");
                                Console.WriteLine("4. Get The Receipt");
                            repeatAgainTwo:
                                Console.Write("What do you want: ");

                                OrderNumberVal = Convert.ToInt32(Console.ReadLine());
                                if (OrderNumberVal == 1)
                                {
                                    Console.Clear();
                                    Update();
                                    break;
                                }
                                else if (OrderNumberVal == 2)
                                {
                                    Console.Clear();
                                    Delete();
                                    break;
                                }
                                else if (OrderNumberVal == 3)
                                {
                                    Console.Clear();
                                    Add();

                                    break;
                                }
                                else if (OrderNumberVal == 4)
                                {
                                    Console.Clear();
                                    PrintReceipt();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("invalid input please repeat again!");
                                    goto repeatAgainTwo;
                                }
                                // check if they are not the same;
                            }
                            else if (OrderNumberVal != 1 && OrderNumberVal != 2)
                            {

                                Console.WriteLine("invalid Input");
                                goto RepeatAgain;
                            }

                        }
                        else
                        {

                        }
                    }
                }
                else if (AddIdentifier == 6)
                {
                    //checkForOrderCount(orderCount);
                    if (OrderNumberConfirm == false)
                    {

                    EatRepeat:
                    EatRepeatTwo:
                    ConfirmReapeat:
                        Console.Write("please Choose You Want to Eat:");
                        OrderNumberVal = Convert.ToInt32(Console.ReadLine());
                        if (OrderNumberVal.GetType() == typeof(Int32) || OrderNumberVal.GetType() == typeof(int))
                        {
                            OrderNumberConfirm = true;
                            if (OrderNumberVal == 26)
                            {
                                OrdersName[orderCount] = HotDrinks[0];
                                OrdersPrice[orderCount] = HotDrinksPrices[0];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 27)
                            {
                                OrdersName[orderCount] = HotDrinks[1];
                                OrdersPrice[orderCount] = HotDrinksPrices[1];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 28)
                            {
                                OrdersName[orderCount] = HotDrinks[2];
                                OrdersPrice[orderCount] = HotDrinksPrices[2];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 29)
                            {
                                OrdersName[orderCount] = HotDrinks[3];
                                OrdersPrice[orderCount] = HotDrinksPrices[3];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 30)
                            {
                                OrdersName[orderCount] = HotDrinks[4];
                                OrdersPrice[orderCount] = HotDrinksPrices[4];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else
                            {
                                Console.WriteLine("invalid Input Please Try Again");
                                //Pause(2);
                                goto EatRepeatTwo;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong Input");
                            Pause(2);
                            goto EatRepeat;
                        }
                        if (OrderNumberConfirm == true)
                        {

                        RepeatAgain:
                            OrderNumberConfirm = false;
                            Console.WriteLine("1. yes");
                            Console.WriteLine("2. no");
                            Console.Write("you want to add another order:");

                            OrderNumberVal = Convert.ToInt32(Console.ReadLine());
                            if (OrderNumberVal == 1)
                            {

                                goto ConfirmReapeat;
                            }
                            else if (OrderNumberVal == 2)
                            {
                                // ouput the total of the orders
                                int iii;
                                for (iii = 0; iii < OrdersPrice.Length; iii++)
                                {
                                    totalOrder += OrdersPrice[iii];
                                }
                                Console.Write("The total is:" + totalOrder);
                                Console.WriteLine();
                                Console.WriteLine("1. Update the particular order");
                                Console.WriteLine("2. Delete the all the order or particular order");
                                Console.WriteLine("3. Add another Order in Main Menu:");
                                Console.WriteLine("4. Get The Receipt");
                            repeatAgainTwo:
                                Console.Write("What do you want: ");

                                OrderNumberVal = Convert.ToInt32(Console.ReadLine());
                                if (OrderNumberVal == 1)
                                {
                                    Console.Clear();
                                    Update();
                                    break;
                                }
                                else if (OrderNumberVal == 2)
                                {
                                    Console.Clear();
                                    Delete();
                                    break;
                                }
                                else if (OrderNumberVal == 3)
                                {
                                    Console.Clear();
                                    Add();

                                    break;
                                }
                                else if (OrderNumberVal == 4)
                                {
                                    Console.Clear();
                                    PrintReceipt();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("invalid input please repeat again!");
                                    goto repeatAgainTwo;
                                }
                                // check if they are not the same;
                            }
                            else if (OrderNumberVal != 1 && OrderNumberVal != 2)
                            {

                                Console.WriteLine("invalid Input");
                                goto RepeatAgain;
                            }

                        }
                        else
                        {

                        }
                    }
                }
                else if (AddIdentifier == 7)
                {
                    //checkForOrderCount(orderCount);
                    if (OrderNumberConfirm == false)
                    {

                    EatRepeat:
                    EatRepeatTwo:
                    ConfirmReapeat:
                        Console.Write("please Choose You Want to Eat:");
                        OrderNumberVal = Convert.ToInt32(Console.ReadLine());
                        if (OrderNumberVal.GetType() == typeof(Int32) || OrderNumberVal.GetType() == typeof(int))
                        {
                            OrderNumberConfirm = true;
                            if (OrderNumberVal == 31)
                            {
                                OrdersName[orderCount] = IcedCoffee[0];
                                OrdersPrice[orderCount] = IcedCoffeePrices[0];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 32)
                            {
                                OrdersName[orderCount] = IcedCoffee[1];
                                OrdersPrice[orderCount] = IcedCoffeePrices[1];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 33)
                            {
                                OrdersName[orderCount] = IcedCoffee[2];
                                OrdersPrice[orderCount] = IcedCoffeePrices[2];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 34)
                            {
                                OrdersName[orderCount] = IcedCoffee[3];
                                OrdersPrice[orderCount] = IcedCoffeePrices[3];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else if (OrderNumberVal == 35)
                            {
                                OrdersName[orderCount] = IcedCoffee[4];
                                OrdersPrice[orderCount] = IcedCoffeePrices[4];
                                Console.WriteLine("you ordered:" + OrdersName[orderCount]);
                                Console.WriteLine("The price of that product is:" + OrdersPrice[orderCount]);
                                orderCount++;
                                if (orderCount >= 20)
                                {
                                    checkForOrderCount(orderCount);
                                    break;
                                }
                                else if (orderCount < 20)
                                {
                                    checkForOrderCount(orderCount);
                                }
                            }
                            else
                            {
                                Console.WriteLine("invalid Input Please Try Again");
                                //Pause(2);
                                goto EatRepeatTwo;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong Input");
                            Pause(2);
                            goto EatRepeat;
                        }
                        if (OrderNumberConfirm == true)
                        {

                        RepeatAgain:
                            OrderNumberConfirm = false;
                            Console.WriteLine("1. yes");
                            Console.WriteLine("2. no");
                            Console.Write("you want to add another order:");

                            OrderNumberVal = Convert.ToInt32(Console.ReadLine());
                            if (OrderNumberVal == 1)
                            {

                                goto ConfirmReapeat;
                            }
                            else if (OrderNumberVal == 2)
                            {
                                // ouput the total of the orders
                                int iii;
                                for (iii = 0; iii < OrdersPrice.Length; iii++)
                                {
                                    totalOrder += OrdersPrice[iii];
                                }
                                Console.Write("The total is:" + totalOrder);
                                Console.WriteLine();
                                Console.WriteLine("1. Update the particular order");
                                Console.WriteLine("2. Delete the all the order or particular order");
                                Console.WriteLine("3. Add another Order in Main Menu:");
                                Console.WriteLine("4. Get The Receipt");
                            repeatAgainTwo:
                                Console.Write("What do you want: ");

                                OrderNumberVal = Convert.ToInt32(Console.ReadLine());
                                if (OrderNumberVal == 1)
                                {
                                    Console.Clear();
                                    Update();
                                    break;
                                }
                                else if (OrderNumberVal == 2)
                                {
                                    Console.Clear();
                                    Delete();
                                    break;
                                }
                                else if (OrderNumberVal == 3)
                                {
                                    Console.Clear();
                                    Add();

                                    break;
                                } else if (OrderNumberVal == 4) {
                                    Console.Clear();
                                    PrintReceipt();
                                    break;

                                }
                                else
                                {
                                    Console.WriteLine("invalid input please repeat again!");
                                    goto repeatAgainTwo;
                                }
                                // check if they are not the same;
                            }
                            else if (OrderNumberVal != 1 && OrderNumberVal != 2)
                            {

                                Console.WriteLine("invalid Input");
                                goto RepeatAgain;
                            }

                        }
                        else
                        {

                        }
                    }
                }
            }
            
        }
        public static void AddProccessMenu(int OrderCategory)
        {
            int addInitializer = 0;
            // for Starter Menu List
            Console.Clear();
         
            if (OrderCategory == 1)
            {
                AddIdentifier = 1;
                Console.WriteLine("\t\t\tCofftea Zone Starter Menu");
                Console.Write("\n\n\n");
                Console.WriteLine(StarterTitle);
                for(addInitializer = 0 ; addInitializer < 5 ; addInitializer++) {

                    if (addInitializer == 0)
                    {
                        Console.WriteLine(Starter[addInitializer] + "\t\t\t\t\t" + StarterPrices[addInitializer]);
                    }
                    else if (addInitializer == 1)
                    {
                        Console.WriteLine(Starter[addInitializer] + "\t\t\t\t\t\t" + StarterPrices[addInitializer]);
                
                    }
                    else if (addInitializer == 2)
                    {
                        Console.WriteLine(Starter[addInitializer] + "\t\t\t\t\t\t" + StarterPrices[addInitializer]);
          
                    }
                    else if (addInitializer == 3)
                    {
                        Console.WriteLine(Starter[addInitializer] + "\t\t\t\t\t\t" + StarterPrices[addInitializer]);
                    }
                    else if (addInitializer == 4)
                    {
                        Console.WriteLine(Starter[addInitializer] + "\t\t\t\t\t\t\t" + StarterPrices[addInitializer]);
                    }
                }
            }
            else if (OrderCategory == 2)
            {
                AddIdentifier = 2;
                Console.WriteLine("\t\t\tCofftea Zone Pizza Menu");
                Console.Write("\n\n\n");
                Console.WriteLine(PizzaTitle);
                for (addInitializer = 0; addInitializer < 5; addInitializer++)
                {
                    if (addInitializer == 0)
                    {
                        Console.WriteLine(Pizza[addInitializer] + "\t\t\t\t\t\t" + PizzaPrices[addInitializer]);
                    }
                    else if (addInitializer == 1)
                    {
                        Console.WriteLine(Pizza[addInitializer] + "\t\t\t\t\t\t" + PizzaPrices[addInitializer]);
                    }
                    else if (addInitializer == 2)
                    {
                        Console.WriteLine(Pizza[addInitializer] + "\t\t\t\t\t\t" + PizzaPrices[addInitializer]);
                    }
                    else if (addInitializer == 3)
                    {
                        Console.WriteLine(Pizza[addInitializer] + "\t\t\t\t\t\t" + PizzaPrices[addInitializer]);
                    }
                    else if (addInitializer == 4)
                    {
                        Console.WriteLine(Pizza[addInitializer] + "\t\t\t\t\t" + PizzaPrices[addInitializer]);
                    }
                }
            }
            else if (OrderCategory == 3)
            {
                AddIdentifier = 3;
                Console.WriteLine("\t\t\tCofftea Zone Main Course Menu");
                Console.WriteLine("\n\n\n");
                Console.WriteLine(MainCourseTitle);
                for (addInitializer = 0; addInitializer < 5; addInitializer++)
                {
                    if (addInitializer == 0)
                    {
                        Console.WriteLine(MainCourse[addInitializer] + "\t\t\t\t\t\t" + MainCoursePrices[addInitializer]);
                    }
                    else if (addInitializer == 1)
                    {
                        Console.WriteLine(MainCourse[addInitializer] + "\t\t\t\t\t\t" + MainCoursePrices[addInitializer]);
                    }
                    else if (addInitializer == 2)
                    {
                        Console.WriteLine(MainCourse[addInitializer] + "\t\t\t\t\t\t" + MainCoursePrices[addInitializer]);
                    }
                    else if (addInitializer == 3)
                    {
                        Console.WriteLine(MainCourse[addInitializer] + "\t\t\t\t\t\t" + MainCoursePrices[addInitializer]);
                    }
                    else if (addInitializer == 4)
                    {
                        Console.WriteLine(MainCourse[addInitializer] + "\t\t\t\t" + MainCoursePrices[addInitializer]);
                    }
                }
            }
            else if (OrderCategory == 4)
            {
                AddIdentifier = 4;
                Console.Clear();
                Console.WriteLine("\t\t\tCofftea Zone Burger and Sandwiches");
                Console.Write("\n\n\n");
                
                for (addInitializer = 0; addInitializer < 5; addInitializer++)
                {
                    if (addInitializer == 0)
                    {
                        Console.WriteLine(BurgerAndSandwiches[addInitializer] + "\t\t\t\t\t" + BurgerAndSandwichesPrices[addInitializer]);
                    }
                    else if (addInitializer == 1)
                    {
                        Console.WriteLine(BurgerAndSandwiches[addInitializer] + "\t\t\t\t\t" + BurgerAndSandwichesPrices[addInitializer]);
                    }
                    else if (addInitializer == 2)
                    {
                        Console.WriteLine(BurgerAndSandwiches[addInitializer] + "\t\t\t\t\t" + BurgerAndSandwichesPrices[addInitializer]);
                    }
                    else if (addInitializer == 3)
                    {
                        Console.WriteLine(BurgerAndSandwiches[addInitializer] + "\t\t\t\t\t" + BurgerAndSandwichesPrices[addInitializer]);
                    }
                    else if (addInitializer == 4)
                    {
                        Console.WriteLine(BurgerAndSandwiches[addInitializer] + "\t\t\t\t\t" + BurgerAndSandwichesPrices[addInitializer]);
                    }
                }
            }
            else if (OrderCategory == 5)
            {
                AddIdentifier = 5;
                Console.WriteLine("\t\t\tCofftea Zone Platter Menu");
                Console.Write("\n\n\n");
                Console.WriteLine(PlatterTitle);
                 for (addInitializer = 0 ; addInitializer < 5 ; addInitializer++) {
                     if (addInitializer == 0)
                     {
                         Console.WriteLine(Platter[addInitializer] + "\t\t\t\t\t" + PlatterPrice[addInitializer]);
                     }
                     else if (addInitializer == 1)
                     {
                         Console.WriteLine(Platter[addInitializer] + "\t\t\t\t\t" + PlatterPrice[addInitializer]);
                     }
                     else if (addInitializer == 2)
                     {
                         Console.WriteLine(Platter[addInitializer] + "\t\t\t\t\t" + PlatterPrice[addInitializer]);
                     }
                     else if (addInitializer == 3)
                     {
                         Console.WriteLine(Platter[addInitializer] + "\t\t\t\t\t" + PlatterPrice[addInitializer]);
                     }
                     else if (addInitializer == 4)
                     {
                         Console.WriteLine(Platter[addInitializer] + "\t\t\t\t\t\t" + PlatterPrice[addInitializer]);
                     }
                 }
            }
            else if (OrderCategory == 6)
            {
                AddIdentifier = 6;
                Console.WriteLine("\t\t\tCofftea Zone Hot Drinks Menu");
                Console.Write("\n\n\n");
                Console.WriteLine(HotDrinksTitle);
                 for (addInitializer = 0 ; addInitializer < 5 ; addInitializer++) {
                     if (addInitializer == 0)
                     {
                         Console.WriteLine(HotDrinks[addInitializer] + "\t\t\t\t\t" + HotDrinksPrices[addInitializer]);
                     }
                     else if (addInitializer == 1)
                     {
                         Console.WriteLine(HotDrinks[addInitializer] + "\t\t\t\t\t" + HotDrinksPrices[addInitializer]);
                     }
                     else if (addInitializer == 2)
                     {
                         Console.WriteLine(HotDrinks[addInitializer] + "\t\t\t\t\t\t" + HotDrinksPrices[addInitializer]);
                     }
                     else if (addInitializer == 3)
                     {
                         Console.WriteLine(HotDrinks[addInitializer] + "\t\t\t\t\t\t" + HotDrinksPrices[addInitializer]);
                     }
                     else if (addInitializer == 4)
                     {
                         Console.WriteLine(HotDrinks[addInitializer] + "\t\t\t\t\t\t" + HotDrinksPrices[addInitializer]);
                     }
                 }
            }
            else if (OrderCategory == 7)
            {
                AddIdentifier = 7;
                Console.WriteLine("\t\t\tCofftea Zone Iced Coffee Menu");
                Console.Write("\n\n\n");
                Console.WriteLine(IcedCoffeeTitle);
                for (addInitializer = 0; addInitializer < 5; addInitializer++)
                {
                    if (addInitializer == 0)
                    {
                        Console.WriteLine(IcedCoffee[addInitializer] + "\t\t\t\t\t" + IcedCoffeePrices[addInitializer]);
                    }
                    else if (addInitializer == 1)
                    {
                        Console.WriteLine(IcedCoffee[addInitializer] + "\t\t\t\t\t\t" + IcedCoffeePrices[addInitializer]);
                    }
                    else if (addInitializer == 2)
                    {
                        Console.WriteLine(IcedCoffee[addInitializer] + "\t\t\t\t\t\t" + IcedCoffeePrices[addInitializer]);
                    }
                    else if (addInitializer == 3)
                    {
                        Console.WriteLine(IcedCoffee[addInitializer] + "\t\t\t\t\t" + IcedCoffeePrices[addInitializer]);
                    }
                    else if (addInitializer == 4)
                    {
                        Console.WriteLine(IcedCoffee[addInitializer] + "\t\t\t\t\t\t" + IcedCoffeePrices[addInitializer]);
                    }
                }
            }
            
            AddProcessOrder();
         
        }
        public static void Add()
        {
            int Order;
            AddRepeat:
            Console.WriteLine("Note: You Can Only Order 20 Foods Or drinks!\n");
            Console.WriteLine("your order is now: " + orderCount + " - " + "20");
            Console.WriteLine("1. Starter");
            Console.WriteLine("2. Pizza");
            Console.WriteLine("3. Main Course");
            Console.WriteLine("4. Burger and Sandwiches");
            Console.WriteLine("5. Platter");
            Console.WriteLine("6. Hot Drinks");
            Console.WriteLine("7. Iced Coffee");
            while(true) {
            
                Console.Write("please Add Your Order:");
                Order = Convert.ToInt32(Console.ReadLine());
                if(Order == 1)
                {
                    AddProccessMenu(Order);
                    break;
                }
                else if (Order == 2) 
                {
                    AddProccessMenu(Order);
                    break;
                } 
                else if (Order == 3) 
                {
                    AddProccessMenu(Order);
                    break;
                }
                else if (Order == 4)
                {
                    AddProccessMenu(Order);
                    break;
                }
                else if (Order == 5)
                {
                    AddProccessMenu(Order);
                    break;
                }
                else if (Order == 6)
                {
                    AddProccessMenu(Order);
                    break;
                }
                else if (Order == 7)
                {
                    AddProccessMenu(Order);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input Please Try Again");
                    Console.WriteLine();
                    Pause(2);
                    Console.Clear();
                    goto AddRepeat;
                }
            }
        }
        public static void Search()
        {
            Console.WriteLine("your are in search module");


        }
        public static void Update()
        {
            


        }
        public static void Display()
        {
            
            Console.WriteLine("\t\t\t Cofftea Zone Product List");
            int i = 0;
         
            Console.WriteLine();

            Console.WriteLine(StarterTitle);
            Console.WriteLine();
            for (i = 0; i < 5; i++)
            {
                if (i == 0) {
                    Console.WriteLine("\t" + Starter[i] + "\t\t\t\t" + StarterPrices[i]);
                } else if(i == 1) {
                    Console.WriteLine("\t" + Starter[i] + "\t\t\t\t\t" + StarterPrices[i]);
                    continue;
                } else if (i == 2) {
                    Console.WriteLine("\t" + Starter[i] + "\t\t\t\t\t" + StarterPrices[i]);
                    continue;
                } else if (i == 3) {
                    Console.WriteLine("\t" + Starter[i] + "\t\t\t\t\t" + StarterPrices[i]);
                    continue;
                } else if (i == 4){
                    Console.WriteLine("\t" + Starter[i] + "\t\t\t\t\t\t" + StarterPrices[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine(MainCourseTitle);
            Console.WriteLine();
            for (i = 0; i < 5; i++)
            {

                if (i == 0) {
                    Console.WriteLine("\t" + MainCourse[i] + "\t\t\t\t\t" + MainCoursePrices[i]);
                }
                else if (i == 1) {
                    Console.WriteLine("\t" + MainCourse[i] + "\t\t\t\t\t" + MainCoursePrices[i]);
                } else if (i == 2) {
                    Console.WriteLine("\t" + MainCourse[i] + "\t\t\t\t\t" + MainCoursePrices[i]);
                } else if (i == 3) {
                    Console.WriteLine("\t" + MainCourse[i] + "\t\t\t\t\t" + MainCoursePrices[i]);
                } else if (i == 4) {
                    Console.WriteLine("\t" + MainCourse[i] + "\t\t\t" + MainCoursePrices[i]);
                }
                
               
              
            }
            Console.WriteLine();

            Console.WriteLine(PizzaTitle);
            Console.WriteLine();
            for (i = 0; i < 5; i++ )
            {
               
                if (i == 0) {
                    Console.WriteLine("\t" + Pizza[i] + "\t\t\t\t\t" + PizzaPrices[i]);
                } else if (i == 1) {
                    Console.WriteLine("\t" + Pizza[i] + "\t\t\t\t\t" + PizzaPrices[i]);
                } else if (i == 2) {
                    Console.WriteLine("\t" + Pizza[i] + "\t\t\t\t\t" + PizzaPrices[i]);
                } else if (i == 3) {
                    Console.WriteLine("\t" + Pizza[i] + "\t\t\t\t\t" + PizzaPrices[i]);
                } else if (i == 4){
                    Console.WriteLine("\t" + Pizza[i] + "\t\t\t\t" + PizzaPrices[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine(PlatterTitle);
            Console.WriteLine();
            for (i = 0; i < 5; i++)
            {
             
                if (i == 0) {
                    Console.WriteLine("\t" + Platter[i] + "\t\t\t\t" + PlatterPrice[i]);
                } else if (i == 1) {
                    Console.WriteLine("\t" + Platter[i] + "\t\t\t\t" + PlatterPrice[i]);
                } else if (i == 2) {
                    Console.WriteLine("\t" + Platter[i] + "\t\t\t\t" + PlatterPrice[i]);
                } else if (i == 3) {
                    Console.WriteLine("\t" + Platter[i] + "\t\t\t\t" + PlatterPrice[i]);
                } else if (i == 4) {
                    Console.WriteLine("\t" + Platter[i] + "\t\t\t\t\t" + PlatterPrice[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine(BurgerAndSandwichesTitle);
            Console.WriteLine();

            for (i = 0; i < 5; i++) 
            {
                
                if(i == 0) {
                    Console.WriteLine("\t" + BurgerAndSandwiches[i] + "\t\t\t\t" + BurgerAndSandwichesPrices[i]);
                } else if (i == 1) {
                    Console.WriteLine("\t" + BurgerAndSandwiches[i] + "\t\t\t\t" + BurgerAndSandwichesPrices[i]);
                } else if (i == 2) {
                    Console.WriteLine("\t" + BurgerAndSandwiches[i] + "\t\t\t\t" + BurgerAndSandwichesPrices[i]);
                } else if (i == 3) {
                    Console.WriteLine("\t" + BurgerAndSandwiches[i] + "\t\t\t\t" + BurgerAndSandwichesPrices[i]);
                } else if (i == 4) {
                    Console.WriteLine("\t" + BurgerAndSandwiches[i] + "\t\t\t\t" + BurgerAndSandwichesPrices[i]);
                }

            }
            Console.WriteLine();
            Console.WriteLine(IcedCoffeeTitle);
            Console.WriteLine();
            for (i = 0; i < 5; i++)
            {
            
                if (i == 0 ) {
                    Console.WriteLine("\t" + IcedCoffee[i] + "\t\t\t\t" + IcedCoffeePrices[i]);
                } else if (i == 1) {
                    Console.WriteLine("\t" + IcedCoffee[i] + "\t\t\t\t\t" + IcedCoffeePrices[i]);
                } else if (i == 2) {
                    Console.WriteLine("\t" + IcedCoffee[i] + "\t\t\t\t\t" + IcedCoffeePrices[i]);
                } else if (i == 3) {
                    Console.WriteLine("\t" + IcedCoffee[i] + "\t\t\t\t" + IcedCoffeePrices[i]);
                } else if (i == 4) {
                    Console.WriteLine("\t" + IcedCoffee[i] + "\t\t\t\t\t" + IcedCoffeePrices[i]);
                }

            }
            Console.WriteLine();
            Console.WriteLine(HotDrinksTitle);
            Console.WriteLine();
            for (i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("\t" + HotDrinks[i] + "\t\t\t\t" + HotDrinksPrices[i]);
                }
                else if (i == 1)
                {
                    Console.WriteLine("\t" + HotDrinks[i] + "\t\t\t\t" + HotDrinksPrices[i]);
                }
                else if (i == 2)
                {
                    Console.WriteLine("\t" + HotDrinks[i] + "\t\t\t\t\t" + HotDrinksPrices[i]);
                }
                else if (i == 3)
                {
                    Console.WriteLine("\t" + HotDrinks[i] + "\t\t\t\t\t" + HotDrinksPrices[i]);
                }
                else if (i == 4)
                {
                    Console.WriteLine("\t" + HotDrinks[i] + "\t\t\t\t\t" + HotDrinksPrices[i]);
                }

            }
               // this infinite loop will stop if the condition below satisfy 
               // and it will be back to the welcome screen 
                while(true) {
                     Console.Write("Are you Ready to process The Order(Yes or No):");
                     Answer = Console.ReadLine();
                    if (Answer == "YES" || Answer == "yes" || Answer == "Yes" 
                        || Answer == "YeS" || Answer == "yEs" || Answer == "yeS"
                        || Answer == "YEs") {
                            Console.Clear();
                            WelcomeScreen();
                            break;
                    }
                    else if (Answer == "NO" || Answer == "no" || Answer == "No" || Answer == "nO")
                    {
                        Console.WriteLine("Ok Stay Here");
                    }
                    else
                    {
                        Console.WriteLine("invalid Input please Repeat!");
                    }
                }



        }
        public static void PrintReceipt()
        {
            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream("./Redirect.txt", FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open Redirect.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(writer);
            Console.WriteLine("This is a line of text");
            Console.WriteLine("Everything written to Console.Write() or");
            Console.WriteLine("Console.WriteLine() will be written to a file");
            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
            Console.WriteLine("Done");

        
        }
        public static void WelcomeScreen()
        {
          
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\tWelcome to Cofftea Zone Point of Sale");
            Console.WriteLine();
        Main:
            Console.WriteLine("1. Add new Order");
            Console.WriteLine("2. Search Product");
            Console.WriteLine("3. Display all the Products");
            Console.WriteLine("4. Update Order");
            Console.WriteLine("5. Delete Order");
            Console.WriteLine();
            Console.Write("Please Select a number above:");
            globalCategoryNumber = Convert.ToInt32(Console.ReadLine());

            if (globalCategoryNumber == 1)
            {
                Console.Clear();
                Add();
            }
            else if (globalCategoryNumber == 2)
            {
                Console.Clear();
                Search();
            }
            else if (globalCategoryNumber == 3)
            {
                Console.Clear();
                Display();
            }
            else if (globalCategoryNumber == 4)
            {
                Console.Clear();
                Update();

            }
            else if (globalCategoryNumber == 5)
            {
                Console.Clear();
                Delete();
            }
            else
            {
                Console.WriteLine("Invalid input please try Again");
                goto Main;
                
            }
        }

        public static void Main(string[] args)
        {
            // just for initializing all the important
            // functions of Our System

            WelcomeScreen();
        }
    }
}
