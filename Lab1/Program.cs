using System;
using System.IO;

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
    class Program
    {
        static void Main(string[] args)
        {
            //Emloyee array read and create intance of the the "employees.txt" file
            Employee[] numberOfEmployees = ReadEmployee("employees.txt");
            if (numberOfEmployees == null) return;
            bool condition = true;             

            //While loop run till user input the 6 digit
            while (condition)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("1 - Sort by Employee Name (ascending)");
                Console.WriteLine("2 - Sort by Employee Number (ascending)");
                Console.WriteLine("3 - Sort by Employee Pay Rate (descending)");
                Console.WriteLine("4 - Sort by Employee Hours (descending)");
                Console.WriteLine("5 - Sort by Employee Gross Pay (descending)");
                Console.WriteLine("6 - Exit");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine();
                Console.Write("Enter Your choice : ");

                string userChoice = Console.ReadLine();             
                Console.WriteLine();
                //Shows the heading of the all employee data
                Console.WriteLine(string.Format("{0,-25}{1,-15}{2,-15:C}{3,-15}{4,-15:C}", "NAME", "NUMBER", "RATE", "HOURS", "GROSS PAY"));
                Console.WriteLine();

                //switch case call the shorting method by using user's input
                switch (userChoice)
                {
                     case "1":
                        SortName(numberOfEmployees);
                        foreach (Employee a in numberOfEmployees)
                            Console.WriteLine(a);
                        break;

                    case "2":
                        SortNumber(numberOfEmployees);
                        foreach (Employee a in numberOfEmployees)
                            Console.WriteLine(a);
                        break;

                    case "3":
                        SortPayRate(numberOfEmployees);
                        foreach (Employee a in numberOfEmployees)
                            Console.WriteLine(a);
                        break;

                    case "4":
                        SortHours(numberOfEmployees);
                        foreach (Employee a in numberOfEmployees)
                            Console.WriteLine(a);
                        break;

                    case "5":
                        SortGrossPay(numberOfEmployees);
                        foreach (Employee a in numberOfEmployees)
                            Console.WriteLine(a);
                        break;

                    case "6":
                        condition = false;
                        break;

                    default:
                        Console.WriteLine("Please ENTER valid number");
                        break;
                }
                }
               

            //Employee array read the whole information from the employee.txt file and call here as string 
            Employee[] ReadEmployee(string file)
            {
                Employee[] theEmployee = new Employee[100];
                StreamReader data = new StreamReader(file);

                string line;
                string[] lineData;
                int count = 0;

                //while loop read each line from Employee array and put (",") comma between each information
                while ((line = data.ReadLine()) != null)
                {
                    lineData = line.Split(',');
                    theEmployee[count] = new Employee(Convert.ToString(lineData[0]), Convert.ToInt32(lineData[1].Trim()), Convert.ToDecimal(lineData[2].Trim()), Convert.ToDouble(lineData[3].Trim()));
                    count++;
                }
                //DELET extra space
                //return array
                Array.Resize(ref theEmployee, count);
                return theEmployee;
            }



            //ShortName method - short names in ascending order by unsing for loop
            void SortName(Employee[] theEmployee)
            {
                int low = 0;
                Employee alt = null;
                int calc = theEmployee.Length;
 
                for (int x = 0; x < calc - 1; x++)
                {
                    low = x;
                    for (int y = x + 1; y < calc; y++)
                    {
                        /**
                         * FIRST string store name
                         * SECOND string another name and store in ascending order
                         * STARTING value of the first string
                         * STARTING value of the second string
                         */
                        string str1 = theEmployee[y].GetName();           
                        string str2 = theEmployee[low].GetName();        
                        int valueA = 0;                              
                        int valueB = 0;                             
                        for (int z = 0; valueA == valueB; z++)
                        {
                            valueA = System.Convert.ToInt32(str1[z]);
                            valueB = System.Convert.ToInt32(str2[z]);
                        }
                        if (valueA < valueB)
                        {
                            low = y;
                        }
                    }
                    //swip the previous values with shorted values
                    alt = theEmployee[low];
                    theEmployee[low] = theEmployee[x];
                    theEmployee[x] = alt;
                }
            }

            //ShortNumber method - short numbers in ascending order by unsing for loop
            void SortNumber(Employee[] theEmployee)
            {
                int low = 0;
                Employee alt = null;
                int calc = theEmployee.Length;

                for (int x = 0; x < calc - 1; x++)
                {
                    low = x;
                    for (int y = x + 1; y < calc; y++)
                    {
                        if (numberOfEmployees[y].GetNumber() < numberOfEmployees[low].GetNumber())
                        {                        
                            low = y;
                        }
                    }
                    //swip the previous values with shorted values
                    alt = theEmployee[low];
                    theEmployee[low] = theEmployee[x];
                    theEmployee[x] = alt;
                }
            }

            //ShortPayRate method - short pay in descending order by unsing for loop
            void SortPayRate(Employee[] theEmployee)
            {
                Employee alt = null;
                int calc = theEmployee.Length;

                for (int x = 0; x < calc - 1; x++)
                {
                    for (int y = x + 1; y < calc; y++)
                    {
                        if (numberOfEmployees[x].GetRate() < numberOfEmployees[y].GetRate())
                        {
                            //swip the previous values with shorted values
                            alt = theEmployee[x];
                            theEmployee[x] = theEmployee[y];
                            theEmployee[y] = alt;
                        }
                    }
                }
            }

            //ShortHours method - short houes in descending order by unsing for loop
            void SortHours(Employee[] theEmployee)
            {
                Employee alt = null;
                int calc = theEmployee.Length;

                for (int x = 0; x < calc - 1; x++)
                {
                    for (int y = x + 1; y < calc; y++)
                    {
                        if (numberOfEmployees[x].GetHours() < numberOfEmployees[y].GetHours())
                        {
                            //swip the previous values with shorted values
                            alt = theEmployee[x];
                            theEmployee[x] = theEmployee[y];
                            theEmployee[y] = alt;
                        }
                    }
                }
            }

            //ShortGrossPay method - short grosspay in descending order by unsing for loop
            void SortGrossPay(Employee[] theEmployee)
            {
                Employee alt = null;
                int calc = theEmployee.Length;

                for (int x = 0; x < calc - 1; x++)
                {
                    for (int y = x + 1; y < calc; y++)
                    {
                        if (numberOfEmployees[x].Gross < numberOfEmployees[y].Gross)
                        {
                            //swip the previous values with shorted values
                            alt = theEmployee[x];
                            theEmployee[x] = theEmployee[y];
                            theEmployee[y] = alt;
                        }
                    }
                }
            }                     
        }
    }
}