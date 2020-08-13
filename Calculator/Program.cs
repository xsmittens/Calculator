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
            int calculationAnswer;

            Console.WriteLine("Input first digit");
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second digit");
            secondNum = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Input type of equation +, -, x, / ");


            

            //else if (equationType == "-")
            //{
            //    calculationAnswer = firstNum - secondNum;
            //    Console.WriteLine(firstNum + "-" + secondNum + "=" + calculationAnswer);
            //    Console.ReadLine();
            //}
            //else if (equationType == "x")
            //{
            //    calculationAnswer = firstNum * secondNum;
            //    Console.WriteLine(firstNum + "x" + secondNum + "=" + calculationAnswer);
            //    Console.ReadLine();
            //}
            //else if (equationType == "/")
            //{
            //    calculationAnswer = firstNum / secondNum;
            //    Console.WriteLine(firstNum + "/" + secondNum + "=" + calculationAnswer);
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect format, please try again");
            //    Console.ReadLine();
                
            //}

        }
    }
}
