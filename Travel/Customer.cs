using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Customer
    {
        //Declare and Initialise class parameters
        private static int arraySize = 0;
        private static int[] CustomerAge = new int[arraySize];
        private static string[] CustomerFname = new string[arraySize];
        private static string[] CustomerLname = new string[arraySize];
        private static int[] CustomerPassport = new int[arraySize];
        private static double[] CustomerPrice = new double[arraySize];
        private static string[] CustomerTitle = new string[arraySize];
        private double KidDiscount = 0.9;
        private double SeniorDiscount = 0.8;

        //Constructor
        public Customer() { }
        public Customer(int size)
        {
            CustomerAge = new int[size];
            CustomerTitle = new string[size];
            CustomerFname = new string[size];
            CustomerLname = new string[size];
            CustomerPassport = new int[size];
            CustomerPrice = new double[size];
        }
        //Propterties of class
        public int[] Customer_Age
        {
            get { return CustomerAge; }
            set { CustomerAge = value; }
        }
        public string[] Customer_Title
        {
            get { return CustomerTitle; }
            set { CustomerTitle = value; }
        }
        public string[] Customer_Fname
        {
            get { return CustomerFname; }
            set { CustomerFname = value; }
        }
        public string[] Customer_Lname
        {
            get { return CustomerLname; }
            set { CustomerLname = value; }
        }
        public int[] CustomerPassNo
        {
            get { return CustomerPassport; }
            set { CustomerPassport = value; }
        }
        public double[] CustomerTicket
        {
            get { return CustomerPrice; }
            set { CustomerPrice = value; }
        }
        //user-define function for calculating price of ticket
        public void CalculatePrice()
        {
            for(int i = 0; i < CustomerFname.Length; i++)
            {
                if (CustomerAge[i] < 3)
                {
                    CustomerPrice[i] = 0;
                }
                else if (CustomerAge[i] >= 3 && CustomerAge[i] < 18)
                {
                    CustomerPrice[i] = CustomerPrice[i] * KidDiscount;
                }
      
                else if (CustomerAge[i] >= 65)
                {
                    CustomerPrice[i] = CustomerPrice[i] * SeniorDiscount;
                }
            }
        }
        //Display all infomartion in tabular format
        public void display()
        {
            double total = 0;
            for(int j=0;j<CustomerPassNo.Length; j++)
            {
                total += CustomerPrice[j];
            }
            Console.WriteLine("\n-----------------------------------------------------------");
            Console.WriteLine("\t\tName\tPassportNo.\tFare");
            for(int i = 0; i < CustomerPassNo.Length; i++)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("Passenger"+(i+1)+"\t"+CustomerTitle[i]+""+CustomerFname[i]+""+CustomerLname[i]+"\t"+CustomerPassport[i]+"\t\t"+CustomerTicket[i]);
            }
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("\t\t\tNet amount: {0}", total);
        }
    }
}
