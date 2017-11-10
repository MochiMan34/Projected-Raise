using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectedRaises
{
    class Program
    {
        
        static void Main(string[] args)
        {
            displaySalaries();    
           

            

         

           

       
        }

        public static void displaySalaries()
        {
            const double fourPercentRaise = 0.04;
            String[] employees = { "Bob", "Alex", "Marcus" };
            double[] salaries = { 42371.42, 68921.29, 89410.52 };

            for (int i = 0; i < 3; i++)
            {
                double newSalary = salaries[i] + (salaries[i] * fourPercentRaise); 

                System.Console.WriteLine(employees[i] + "'s current annual salary is: $" + salaries[i] + ". However, next year's projected annual salary for the given employee would be: $" + newSalary );
                System.Console.ReadKey();
            }

        }


    }
}
