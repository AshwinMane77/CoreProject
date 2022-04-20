using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject1.Services
{
  
    public class AccountServices 
    {

        public string save(string name)
        {
            string x = "Hi " + name + " Your total earned salary till now is : ";

            return x;
        }
        public double CalculateSalary(double perMonth, DateTime joindate)
        {

            int TotalDays =   Convert.ToInt32((DateTime.Now -joindate).TotalDays);
            int CountMonth = TotalDays / 30;

            double totalSalary = CountMonth * perMonth;

            return totalSalary;
        }

        public double CalculateAnnual(double perMonth)
        {
            double totalSalary = perMonth * 12;
            return totalSalary;
        }





    }
}
