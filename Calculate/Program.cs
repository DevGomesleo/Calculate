

using System;
using System.Security;

class Program
{
        static int num = 9999;
        static string design = "------------------------\n";
    static void Main()
    {
        while (num != 0)
        {
            string back = "";
            comeback:;
            
            Console.WriteLine($"\n{design}Welcome To My program!!!\n{design}");
            Console.WriteLine($"CALCULATE:\n{design}[1]Sum\n[2]Subtraction\n[3]Multiplication\n[4]Division\n[0]Exit\n{design}");
            Console.Write("Choice The Option: ");

            num = int.Parse(Console.ReadLine()); // "System.FormatException"
            verific:
            int value_one = 0;
            int value_two = 0;
            int x = 0;
           
            
            if (num == 0)
            {
                Console.WriteLine("Come Back [y] or [Enter] to exit: ");
                back = Console.ReadLine();
                if (back == "y" || back == "Y")
                {
                    num = 9999;
                    Console.Clear();

                    goto comeback;
                }

                Console.WriteLine($"{design}Ends game\n{design}");
                Console.ReadLine();

                break;
            }else if
              ( num == 1 || num == 2 || num == 3 || num == 4) 
            {
                switch (num) // Math Operations
                {
                    case 1:
                        Console.WriteLine("Welcome to [SUM]");
                        Console.Write("Enter the First Number: ");
                        value_one = int.Parse(Console.ReadLine());
                        Console.Write("Enter the Second Number: ");
                        value_two = int.Parse(Console.ReadLine());
                        x = value_one + value_two;
                        Console.WriteLine($"The sum between {value_one} + {value_one} = {x}\n");
                        break;
                    case 2:
                        Console.WriteLine("Welcome to [SUBTRACTION]");
                        Console.Write("Enter the First Number: ");
                        value_one = int.Parse(Console.ReadLine());
                        Console.Write("Enter the Second Number: ");
                        value_two = int.Parse(Console.ReadLine());
                        x = value_one - value_two;
                        Console.WriteLine($"the Subtraction between {value_one} - {value_one} = {x} \n");
                        break;
                    case 3:
                        Console.WriteLine("Welcome to [MULTIPLICATION]");
                        Console.Write("Enter the First Number: ");
                        value_one = int.Parse(Console.ReadLine());
                        Console.Write("Enter the Second Number: ");
                        value_two = int.Parse(Console.ReadLine());
                        x = value_one * value_two;
                        Console.WriteLine($"the Multiplication between {value_one} x {value_one} = {x}\n");
                        break;
                    case 4:
                        Console.WriteLine("Welcome to [DIVISION]");
                        Console.Write("Enter the First Number: ");
                        value_one = int.Parse(Console.ReadLine());
                        Console.Write("Enter the Second Number: ");
                        value_two = int.Parse(Console.ReadLine());
                        x = value_one / value_two;
                        Console.WriteLine($"the Division between {value_one} / {value_one} = {x}\n");
                        break;
                }
                num = 0;
                goto verific;
            }
  

        }

        
    }
     
}