using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_StaticKeyword
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer cust = new Customer();
            cust.CustomerName = "Deva";
            cust.CustomerID = 1;

            cust.Insert();
            Console.WriteLine(cust.machinename);

            Country coun = new Country();
            coun.CountryName = "India";
            coun.CountryID = 1;

            coun.Insert();

            Customer cust1 = new Customer();
            cust1.CustomerName = "Devd";
            cust1.CustomerID = 2;

            cust1.Insert();

            Console.WriteLine(new string('#',50));

            Console.WriteLine(CommonUtility.counter.ToString()); //3 = means CommonUtlity static class is common across and is instantiated once

            Console.WriteLine(new string('#', 50));

            foreach (string day in CommonUtility.oDaysOfWeek)
            {
                Console.WriteLine(day);
            }
        }
    }
}
