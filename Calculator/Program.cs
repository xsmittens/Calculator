using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;
            string equationType;
            int calculationAnswer = 0;
            

            Console.WriteLine("Input first digit");
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second digit");
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input type of equation +, -, x, / ");
            equationType = Console.ReadLine();

            if (equationType == "+")
            {
                calculationAnswer = Calculation.Addition(firstNum, secondNum);
            }

            if (equationType == "-")
            {
                calculationAnswer = Calculation.Subtraction(firstNum, secondNum);
            }

            if (equationType == "x")
            {
                calculationAnswer = Calculation.Multiplication(firstNum, secondNum);
            }

            if (equationType == "/")
            {
                calculationAnswer = Calculation.Division(firstNum, secondNum);
            }
            
            Console.WriteLine($"{firstNum} {equationType} {secondNum} = {calculationAnswer}");

            Console.Read();
        }
    }
}
