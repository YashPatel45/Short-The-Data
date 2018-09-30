using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Name and Number: Yash Patel, 000770109
 * Date: 21 September, 2018
 * Purpose: The program contain the array, name Employee and which shows the name, number, pay, hours, gross pay of each employee and 
 * any user can input a number between 1 to 5 and it will short the all data decribed as in questions, 6 number will exit the program
 * the whole consept of this program is shorting the data
 * Statement of Authorship: I, Yash Patel, student number 000770109, certify that all code submitted is my own work;
 * that I have not copied it from any other source.  I also certify that I have not allowed my work to be copied by others. 
 * reference of the sort algorithm """"" https://stackoverflow.com/questions/14768010/simple-bubble-sort-c-sharp """"
 */

namespace Lab1
{
    class Employee
    {
            private string name;
            private int number;
            private decimal rate;
            private double hours;
            private decimal gross;

        //constructor of the Employee class
        public Employee(string name, int number, decimal rate, double hours)
        {
                this.name = name;
                this.number = number;
                this.rate = rate;
                this.hours = hours;
        }

            
            /**
             * Getter and setter methods 
             */
            public double GetHours()
            {
                return hours;
            }
            public string GetName()
            {
                return name;
            }
            public int GetNumber()
            {
                return number;
            }
            public decimal GetRate()
            {
                return rate;
            }
            public decimal Rate
            {
                get; set;
            }
            public void setHours(double hours)
            {
                this.hours  = hours;
            }
            public void setName(string name)
            {
                this.name = name;
            }
            public void setNumber(int number)
            {
                this.number = number;
            }
            public void setRate(decimal rate)
            {
                this.rate = rate;
            }
            
            /**
             * GROSS method calculate the grosspay of the employee by using HOURS and RATE from the current class and also
             * if hours is morethan 40 houes payment will be set at 1.5, it's the acual pay of employee
             * Return the calculated grosspay
             */
            public decimal Gross
            {
                get
                {
                    if (hours < 40)
                    {
                        gross = rate * Convert.ToDecimal(hours);
                    }
                    else
                    {
                        gross = rate * (rate / 2) * Convert.ToDecimal(hours);
                    }
                    return gross;
                }
            }

            //tostring method conatin the formate of all Employee in proper places
            override
            public string ToString()
            {
                return string.Format("{0,-25}{1,-15}{2,-15:C}{3,-15}{4,-15:C}", name, number, rate, hours, Gross);
            }
        }
}