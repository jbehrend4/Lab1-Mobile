using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose program 1 or 2: ");
            String choice = Console.ReadLine();

            while (choice != "1" && choice != "2")
            {
                Console.Write("Please choose program 1 or 2: ");
                choice = Console.ReadLine();
            }

            if (choice == "1")
            {
                int flipChoice = 0;
                Console.Write("Please enter a number between 3 and 9: ");
                String enteredNumber = Console.ReadLine();
                int num = Convert.ToInt32(enteredNumber);
                while (num < 3 || num > 9)
                {
                    Console.Write("Please enter a number between 3 and 9: ");
                    enteredNumber = Console.ReadLine();
                    num = Convert.ToInt32(enteredNumber);
                }

                for (int i = 1; i < num + 1; i++)
                {
                    for (int j = 1; j < num + 1; j++)
                    {
                        Console.Write(i * j);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }

                while (flipChoice != 5)
                {
                    //I don't know what the difference between diagonal left and diagonal right are supposed to be
                    Console.WriteLine("Flip on:");
                    Console.WriteLine("1: Horizontal");
                    Console.WriteLine("2: Vertical");
                    Console.WriteLine("3: Diagonal Left");
                    Console.WriteLine("4: Diagonal Right");
                    Console.WriteLine("5: Exit");
                    String choseFlipOption = Console.ReadLine();
                    flipChoice = Convert.ToInt32(choseFlipOption);

                    switch (flipChoice)
                    {
                        case 1:
                            for (int i = num; i > 0; i--)
                            {
                                for (int j = 1; j < num + 1; j++)
                                {
                                    Console.Write(i * j);
                                    Console.Write(" ");
                                }
                                Console.WriteLine();
                            }
                            break;
                        case 2:
                            for (int i = 1; i < num + 1; i++)
                            {
                                for (int j = num; j > 0; j--)
                                {
                                    Console.Write(i * j);
                                    Console.Write(" ");
                                }
                                Console.WriteLine();
                            }
                            break;
                        case 3:
                            for (int i = num; i > 0; i--)
                            {
                                for (int j = num; j > 0; j--)
                                {
                                    Console.Write(i * j);
                                    Console.Write(" ");
                                }
                                Console.WriteLine();
                            }
                            break;
                        case 4:
                            for (int i = num; i > 0; i--)
                            {
                                for (int j = num; j > 0; j--)
                                {
                                    Console.Write(i * j);
                                    Console.Write(" ");
                                }
                                Console.WriteLine();
                            }
                            break;
                        default:
                            break;

                    }

                }



            }

            else
            {
                int personType = 0;
                List<Person> people = new List<Person>();
                while (personType != 3)
                {
                    Console.WriteLine("Please enter a: ");
                    Console.WriteLine("1: Student");
                    Console.WriteLine("2: Teacher");
                    Console.WriteLine("3: End");
                    Console.Write("");
                    String personTypeInput = Console.ReadLine();
                    personType = Convert.ToInt32(personTypeInput);

                    if (personType == 1)
                    {
                        Student student = new Student();
                        Console.Write("Name: ");
                        String name = Console.ReadLine();
                        Console.Write("Age: ");
                        String ageInput = Console.ReadLine();
                        int age = Convert.ToInt32(ageInput);
                        Console.Write("ID: ");
                        String idInput = Console.ReadLine();
                        int id = Convert.ToInt32(idInput);
                        Console.Write("Program. 1: Computer Science, 2: Accounting, 3: Marketing, 4: Nursing: ");
                        String programChoiceInput = Console.ReadLine();
                        int programChoice = Convert.ToInt32(programChoiceInput);
                        while (programChoice < 1 && programChoice > 4)
                        {
                            Console.Write("Program. 1: Computer Science, 2: Accounting, 3: Marketing, 4: Nursing");
                            programChoiceInput = Console.ReadLine();
                            programChoice = Convert.ToInt32(programChoiceInput);
                        }
                        Console.Write("Credits Earned: ");
                        String creditsInput = Console.ReadLine();
                        int credits = Convert.ToInt32(creditsInput);
                        student.programs = programChoice switch
                        {
                            1 => Programs.ComputerScience,
                            2 => Programs.Accounting,
                            3 => Programs.Marketing,
                            4 => Programs.Nursing,
                            _ => student.programs
                        };
                        student.Name = name;
                        student.Age = age;
                        student.Id = id;
                        student.CreditsEarned = credits;
                        people.Add(student);
                    }
                    else if (personType == 2)
                    {
                        Teacher teacher = new Teacher();
                        Console.Write("Name: ");
                        String name = Console.ReadLine();
                        Console.Write("Age: ");
                        String ageInput = Console.ReadLine();
                        int age = Convert.ToInt32(ageInput);
                        Console.Write("ID: ");
                        String idInput = Console.ReadLine();
                        int id = Convert.ToInt32(idInput);
                        Console.Write("Program. 1: Computer Science, 2: Accounting, 3: Marketing, 4: Nursing: ");
                        String programChoiceInput = Console.ReadLine();
                        int programChoice = Convert.ToInt32(programChoiceInput);
                        while (programChoice < 1 && programChoice > 4)
                        {
                            Console.Write("Program. 1: Computer Science, 2: Accounting, 3: Marketing, 4: Nursing");
                            programChoiceInput = Console.ReadLine();
                            programChoice = Convert.ToInt32(programChoiceInput);
                        }
                        Console.Write("Years of Service: ");
                        String YoSInput = Console.ReadLine();
                        int yearsOfService = Convert.ToInt32(YoSInput);
                        teacher.programs = programChoice switch
                        {
                            1 => Programs.ComputerScience,
                            2 => Programs.Accounting,
                            3 => Programs.Marketing,
                            4 => Programs.Nursing,
                            _ => teacher.programs
                        };
                        teacher.Name = name;
                        teacher.Age = age;
                        teacher.Id = id;
                        teacher.YearsOfService = yearsOfService;
                        people.Add(teacher);

                    }
                }

                foreach (var i in people)
                {
                    Console.WriteLine(i.ToString());
                }

            }
        }
    }

    public class Person
    {
        public String Name;
        public int Age;
        public int Id;
        public Programs programs;
    }

    public class Student : Person
    {
        public int CreditsEarned;
        public override string ToString()
        {
            return "Name: " + Name + " | Age: " + Age + " | ID: " + Id + " | Program: " + programs + " | Credits Earned: " + CreditsEarned;
        }
    }

    public class Teacher : Person
    {
        public int YearsOfService;
        public override string ToString()
        {
            return "Name: " + Name + " | Age: " + Age + " | ID: " + Id + " | Program: " + programs + " | Years of Service: " + YearsOfService;
        }
    }

    public enum Programs
    {
        ComputerScience,
        Accounting,
        Marketing,
        Nursing
    }
}
