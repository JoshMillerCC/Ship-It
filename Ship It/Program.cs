using System;
using System.Collections.Generic;

namespace Ship_It
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShippable> myList = new List<IShippable>();
            string userChoice = "a";
            while(userChoice != "7")
            {
                Console.WriteLine("1. Add a Bicycle to the shipment");
                Console.WriteLine("2. Add a Lawn Mower to the shipment");
                Console.WriteLine("3. Add a Baseball Glove to the shipment");
                Console.WriteLine("4. Add a Crackers to the shipment");
                Console.WriteLine("5. List Shipment Items");
                Console.WriteLine("6. Compute Shipping Charges");
                Console.WriteLine("7. Exit");
                Console.WriteLine("");
                userChoice = Console.ReadLine();
                Console.WriteLine("");

                switch (userChoice)
                {
                    case "1":
                        // adding a bike to the List
                        myList.Add(new Bicycle());
                        Console.WriteLine("1 Bicycle added to shipment.");
                        Console.WriteLine("");
                        break;

                    case "2":
                        // adding a lawn mower to the List
                        myList.Add(new Lawn_Mower());
                        Console.WriteLine("1 Lawn Mower added to shipment.");
                        Console.WriteLine("");
                        break;

                    case "3":
                        // adding a baseball glove to the List
                        myList.Add(new Baseball_Glove());
                        Console.WriteLine("1 Baseball Glove added to shipment.");
                        Console.WriteLine("");
                        break;

                    case "4":
                        // adding crackers to the List
                        myList.Add(new Crackers());
                        Console.WriteLine("1 Crackers added to shipment.");
                        Console.WriteLine("");
                        break;

                    case "5":
                        // writing all items from the List to the console.

                        // create 4 variables that represent the 4 items being shipped
                        int bike = 0;
                        int mower = 0;
                        int glove = 0;
                        int crackers = 0;

                        Console.WriteLine("Shipment Manifest:");

                        // loop through all items in the List, when an item.Product string name is equal to 
                        // the string given, then add one to specified integer value.
                        foreach (IShippable item in myList)
                        {
                            if (item.Product.Equals("Bicycle"))
                            { bike++; }
                            else if (item.Product.Equals("Lawn Mower"))
                            { mower++; }
                            else if (item.Product.Equals("Baseball Glove"))
                            { glove++; }
                            else if (item.Product.Equals("Crackers"))
                            { crackers++; }
                        }

                        // if the values of all integers is still 0 then nothing has been added to 
                        // the List so nothing is being shipped
                        if (bike == 0 && mower == 0 && glove == 0 && crackers == 0)
                        { 
                            Console.WriteLine("Nothing being shipped");
                            Console.WriteLine("");
                        }
                        // when bicycle, lawn mower, and baseball glove is equal to 1, then use the singular version of it
                        // when they are greater than 1, use the plural version of it. Since crackers is always plural, just
                        // make sure that it is greater than 0
                        else
                        {
                            if (bike == 1)
                            { Console.WriteLine(bike + " Bicycle"); }
                            else if (bike > 1)
                            { Console.WriteLine(bike + " Bicycles"); }

                            if (mower == 1)
                            { Console.WriteLine(mower + " Lawn Mower"); }
                            else if (mower > 1)
                            { Console.WriteLine(mower + " Lawn Mowers"); }

                            if (glove == 1)
                            { Console.WriteLine(glove + " Baseball Glove"); }
                            else if (glove > 1)
                            { Console.WriteLine(glove + " Baseball Gloves"); }

                            if (crackers > 0)
                            { Console.WriteLine(crackers + " Crackers"); }
                            Console.WriteLine("");
                        }
                        break;

                    case "6":
                        // Write out the total shipping of all items in the List

                        //create a variable of decimal type and set it to 0
                        decimal money = 0.0m;
                        
                        // loop through all items in the List and add their shipping cost to the decimal variable created earlier
                        foreach(IShippable item in myList)
                        { money += item.ShipCost; }

                        // if that variable is still 0, nothing was added to the List
                        if(money == 0.0m)
                        { 
                            Console.WriteLine("Nothing being shipped");
                            Console.WriteLine("");
                        }
                        // Write the total amount that the decimal variable has come out to after adding all shipping costs to it
                        else 
                        { 
                            Console.WriteLine("Shipping total for all items on manifest is $" + money);
                            Console.WriteLine("");
                        }
                        break;

                    case "7":
                        // exit out of the while loop
                        break;

                    default:
                        // have the user pick a new option since they pressed something that wasn't an option
                        Console.WriteLine("Pick a valid choice");
                        Console.WriteLine("");
                        break;

                }
            }
        }
    }
}
