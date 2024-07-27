using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class ProblemEmployeeDataIF
    {
        class Employee
        {
            public string[] MenuChoices = new string[5] { "1. Add Employee", "2. Update Employee", "3. Delete Employee", "4. List Employee", "5. Exit" };
            public string[] MenuResults = new string[5];
            public int Choice;

            public Employee()
            {
                Console.WriteLine("Processing ...");
            }

            public void AddEmployee(string Name)
            {
                for (int i = 0; i < MenuResults.Length; i++)
                {
                    if (MenuResults[i] == null)
                    {
                        MenuResults[i] = Name;
                        break;
                    }
                }
            }

            public void RemoveEmployee(string Name)
            {
                for (int i = 0; i < MenuResults.Length; i++)
                {
                    if (MenuResults[i] != null)
                    {
                        if (MenuResults[i].Equals(Name))
                        {
                            MenuResults[i] = null;
                        }
                    }
                }
            }

            public void UpdateEmployee(string Name, string NewName)
            {
                for (int i = 0; i < MenuResults.Length; i++)
                {
                    if (MenuResults[i] != null)
                    {
                        if (MenuResults[i].Equals(Name))
                        {
                            MenuResults[i] = NewName;
                        }
                    }
                }
            }

            public void ListEmployee()
            {
                for (int i = 0; i < MenuResults.Length; i++)
                {
                    if (MenuResults[i] != null)
                    {
                        Console.WriteLine(MenuResults[i]);
                    }
                }
            }

            public void PrintMenu()
            {
                for (int i = 0; i < MenuChoices.Length; i++)
                {
                    Console.WriteLine(MenuChoices[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Make a choice");
            }
        }

        internal class Classesdemo
        {
            public static void MainIF()
            {
                Employee employee = new Employee();
                bool LoopExitCheck = true;

                do
                {
                    employee.PrintMenu();
                    int Number = Int32.Parse(Console.ReadLine());

                    if (Number == 1)
                    {
                        string Name;
                        Console.WriteLine("New name = ");
                        Name = Console.ReadLine();
                        employee.AddEmployee(Name);
                    }
                    else if (Number == 2)
                    {
                        string OldName, NewName;
                        Console.WriteLine("Name to be updated = ");
                        OldName = Console.ReadLine();
                        Console.WriteLine("Corrected Name = ");
                        NewName = Console.ReadLine();
                        employee.UpdateEmployee(OldName, NewName);
                    }
                    else if (Number == 3)
                    {
                        string Name;
                        Console.WriteLine("Name to be deleted = ");
                        Name = Console.ReadLine();
                        employee.RemoveEmployee(Name);
                    }
                    else if (Number == 4)
                    {
                        employee.ListEmployee();
                    }
                    else if (Number == 5)
                    {
                        LoopExitCheck = false;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect entry, retry");
                    }
                    Console.WriteLine();
                } while (LoopExitCheck);

            }
        }
    }
}
