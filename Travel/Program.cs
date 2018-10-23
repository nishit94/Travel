using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            int passenger;  //Decalre local variable
            bool check;     //Declare boolean operator
            Console.WriteLine("Enter number of passenger: ");
            check = int.TryParse(Console.ReadLine(), out passenger);    //ask user to enter passenger
            while (check == false || passenger == 0 || passenger < 0)   //check input whether it is valid or not
            {
                Console.WriteLine("Invalid Input");     //display appropriate message
                Console.WriteLine("Enter number of passenger: ");   
                check = int.TryParse(Console.ReadLine(), out passenger);
            }
            Customer customer = new Customer(passenger);    //Create object of Customer class
            for (int i = 0; i < passenger; i++)
            {
                Console.WriteLine("-----------Customer {0}-----------", i+1);    //Enter details of customer
                customer.Customer_Age[i] = getAge();            //Call getAge() to enter age
                customer.Customer_Title[i] = getTitle();
                customer.Customer_Fname[i] = getInfo("First");  //Call getInfo() to enter First name
                customer.Customer_Lname[i] = getInfo("Last");   //Call getInfo() to enter Last name
                customer.CustomerTicket[i] = getAirfare();      //Call getAirfare() to enter Airfare
                customer.CalculatePrice();                      //Calculate airfare per passenger
                customer.CustomerPassNo[i] = getPassport();     //Call getPassport() to get passport number
                for (int j = 0; j < i; j++)
                {
                    while (customer.CustomerPassNo[i] == customer.CustomerPassNo[j])    //check passport number is not repeated
                    {
                        Console.WriteLine("Passport already exists");
                        customer.CustomerPassNo[i] = getPassport();
                    }
                    break;
                }
                
            }
            customer.display(); //call display method from customer class
            Console.ReadKey();
            Console.Clear();
        }
        //function for getting age from user
        public static int getAge()
        {
            int age;
            bool check;            
            Console.WriteLine("Enter age: ");
            check = int.TryParse(Console.ReadLine(), out age);
            while (check == false || age == 0 || age < 0)
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine("Enter age: ");
                check = int.TryParse(Console.ReadLine(), out age);
            }
            return age;
        }
        //function for getting AirFare from user
        public static double getAirfare()
        {
            double fare;
            bool check;
            Console.WriteLine("Enter Airfare: ");
            check = double.TryParse(Console.ReadLine(), out fare);
            while (check == false || fare < 0)
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine("Enter Airfare: ");
                check = double.TryParse(Console.ReadLine(), out fare);
            }
            return fare;
        }
        //function for getting first and last name
        public static string getInfo(string what)
        {
            string name; 
            Console.WriteLine("Enter {0} name: ", what);
            name = Console.ReadLine();
            while(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty");
                Console.WriteLine("Enter {0} name: ", what);
                
                name = Console.ReadLine();
            }
            return name;
        }
        //function for getting Passport number
        public static int getPassport()
        {
            bool check;
            int number;
            Console.WriteLine("Enter Passport number: ");
            check = int.TryParse(Console.ReadLine(), out number);
            while (check == false || number < 0)
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine("Enter Passport number: ");
                check = int.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }
        //function for getting title
        public static string getTitle()
        {
            string title;
            Console.WriteLine("Get Title: ");
            title = Console.ReadLine();
            while (string.IsNullOrEmpty(title))
            {
                Console.WriteLine("Name cannot be empty");
                Console.WriteLine("Get Title: ");
                title = Console.ReadLine();
            }
            return title;
        }
    }
}
