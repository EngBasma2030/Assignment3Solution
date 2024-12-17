using System.Xml.Linq;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1- Write a program that takes a number from the user then print yes if that 
             * number can be divided by 3 and 4 otherwise print no.
              Example (1)
              Input: 12 
              Output: Yes
              Example (2)
              Input: 9 
              Output: No
            */

            Console.Write("أدخل رقمًا: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string result = (number % 3 == 0 && number % 4 == 0) ? "Yes" : "No";
            Console.WriteLine(result);

            /*2- Write a program that allows the user to insert an integer then print 
             * negative if it is negative number otherwise print positive.
              Example (1)
              Input: -5
              Output: negative
              Example (2)
              Input: 10
              Output: positive
             */
            Console.Write("Enter an integer: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            if (number1 < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }

            /*
               3- Write a program that takes 3 integers from the user then prints the max
                element and the min element.
                   Example (1)
                   Input:7,8,5
                   Output:
                   max element = 8
                   min element = 5
                   Example (2)
                   Input: 3 6 9
                   Outputs:
                   Max element = 9
                   Min element = 3
                 */
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int maxElement = num1;
            if (num2 > maxElement)
            {
                maxElement = num2;
            }
            if (num3 > maxElement)
            {
                maxElement = num3;
            }

            int minElement = num1;
            if (num2 < minElement)
            {
                minElement = num2;
            }
            if (num3 < minElement)
            {
                minElement = num3;
            }

            Console.WriteLine("Max element = " + maxElement);
            Console.WriteLine("Min element = " + minElement);

            /*4- Write a program that allows the user to insert an integer number then 
             * check If a number is even or odd.*/

            Console.Write("Enter an integer number: ");
            int number4 = Convert.ToInt32(Console.ReadLine());

            if (number4 % 2 == 0)
            {
                Console.WriteLine("The number is Even.");
            }
            else
            {
                Console.WriteLine("The number is Odd.");
            }

            /*Write a program that takes character from the user then if it is a vowel chars 
             * (a,e,I,o,u) then print (vowel) otherwise print (consonant).
               Example (1)
               Input: O
               Output: vowel
               Example (2)
               Input: b
               Output: Consonant
               */

            /*7- Write a program that allows the user to insert an integer then 
                 print a multiplication table up to 12.
                    Example
                    Input: 5
                    Outputs: 5 10 15 20 25 30 35 40 45 50 55 60
            */
            Console.Write("Enter an integer number: ");
            int number7 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.Write(number7 * i + " ");
            }
            Console.WriteLine();

            /*8- Write a program that allows to user to insert number then print all even 
             * numbers between 1 to this number
               Example:
               Input: 15
               Output: 2 4 6 8 10 12 14
            */
            Console.Write("Enter a number: ");
            int number8 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Even numbers between 1 and " + number8 + ":");

            for (int i = 1; i <= number8; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

            /*9- Write a program that takes two integers then prints the power.
              Example:
             Input: 4 3
             Output: 64
            */
            Console.Write("Enter the NumberOne number: ");
            int NumberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the NumberTwo: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            double result9 = Math.Pow(NumberOne, numberTwo);
            Console.WriteLine("Result: " + result9);


            /*10- Write a program to enter marks of five subjects and calculate total, 
             * average and percentage.
              Example
              Input: - Enter Marks of five subjects: 95 76 58 90 89
              Output: Total marks = 408
              Average Marks = 81
              Percentage = 81
             */
            int mark1, mark2, mark3, mark4, mark5;
            Console.WriteLine("Enter marks of five subjects: ");
            Console.Write("Enter mark for subject 1: ");
            mark1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter mark for subject 2: ");
            mark2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter mark for subject 3: ");
            mark3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter mark for subject 4: ");
            mark4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter mark for subject 5: ");
            mark5 = Convert.ToInt32(Console.ReadLine());

            int total = mark1 + mark2 + mark3 + mark4 + mark5;

            double average = total / 5.0;

            double percentage = (total / 500.0) * 100;

            Console.WriteLine($"Total Marks = {total}");
            Console.WriteLine($"Average Marks = {average}");
            Console.WriteLine($"Percentage = {percentage}%");

            /*11- Write a program to input the month number and print the number of days 
             * in that month.
             Example
             Input: Month Number: 1
             Output: Days in Month: 31
           */

            Console.Write("Enter month number (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());

            int days;

            switch (month)
            {
                case 1: // يناير
                case 3: // مارس
                case 5: // مايو
                case 7: // يوليو
                case 8: // أغسطس
                case 10: // أكتوبر
                case 12: // ديسمبر
                    days = 31;
                    break;

                case 4: // إبريل
                case 6: // يونيو
                case 9: // سبتمبر
                case 11: // نوفمبر
                    days = 30;
                    break;

                case 2: // فبراير

                    Console.Write("Enter the year: ");
                    int year = Convert.ToInt32(Console.ReadLine());

                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        days = 29;
                    }
                    else
                    {
                        days = 28;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid month number.");
                    return;
            }

            Console.WriteLine($"Days in month {month}: {days}");

            /*12- Write a program to create a Simple Calculator.*/
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");

            Console.Write("Enter your choice (1/2/3/4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the first number: ");
            double numb1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double numb2 = Convert.ToDouble(Console.ReadLine());

            double results = 0;
            switch (choice)
            {
                case 1:
                    results = numb1 + numb2;
                    Console.WriteLine($"Result: {numb1} + {numb2} = {results}");
                    break;
                case 2:
                    results = numb1 - numb2;
                    Console.WriteLine($"Result: {numb1} - {numb2} = {results}");
                    break;
                case 3:
                    results = numb1 * numb2;
                    Console.WriteLine($"Result: {numb1} * {numb2} = {results}");
                    break;
                case 4:

                    if (numb2 != 0)
                    {
                        results = numb1 / numb2;
                        Console.WriteLine($"Result: {numb1} / {numb2} = {results}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid operation.");
                    break;
            
            }
        }
    }
}
