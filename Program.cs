using System;

namespace hw5
{
    class Program
    {
        static void Main()
        {
            int result;
            Console.WriteLine("enter number1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("enter number2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        initial: Console.WriteLine("enter opertaion (+,-,*,/): ");
            string operation = Console.ReadLine();
            Console.Clear();

            switch (operation)
            {
                case "+":
                    result = number1 + number2; 
                    break;

                case "-":
                    result = number1 - number2;
                    break;

                case "*":
                    result = number1 * number2;
                    break;

                case "/":
                    result = number1 / number2;
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("""bruh, no "mezelenmey" plz""");
                    goto initial;
            }
            Console.WriteLine($"{number1} {operation} {number2} = {result}");

        }
    }
}
