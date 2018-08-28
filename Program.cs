using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Пишем калькулятор*/


            //Console.WriteLine("The method calculate sum, difference, multiplication and division of numbers.");

            //Console.WriteLine("Please enter the first number");
            //String a = Console.ReadLine();
            //Console.WriteLine("Please enter the second number");
            //String b = Console.ReadLine();

            //int num1 = Int32.Parse(a);
            //int num2 = Int32.Parse(b);


            //Console.WriteLine("Yours results:");
            //int result = num1 + num2;
            //Console.WriteLine(result);

            //result = num1 - num2;
            //Console.WriteLine(result);

            //result = num1 * num2;
            //Console.WriteLine(result);

            //double quotient = (double) (num1) / num2;
            //Console.WriteLine(quotient);

            //Console.ReadLine();



            Console.WriteLine("Calculator");
            while (true)
            {
                double a, b, c; char h; c = 0.0;
                Console.WriteLine("Please enter the first number "); a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the operation (+) (-) (*) (/) "); h = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Please enter the second number "); b = Convert.ToDouble(Console.ReadLine());
                    switch (h) //выбор оператора
                    {
                        case '+': c = a + b;
                            break;
                        case '-': c = a - b;
                            break;
                        case '/': c = a / b;
                            break;
                        case '*': c = a * b;
                            break;
                    }
                Console.WriteLine();
                Console.WriteLine("= " + c); //полученный результат из условия
                Console.WriteLine("Start over? (y/n)");
                ConsoleKeyInfo e = Console.ReadKey(); //при положительном выборе цикл продолжается
                    if (e.KeyChar == 'n') break; //свойство KeyChar используется для выбора образцов клавиш во время выполнения и для изменения нажатий клавиш
                Console.WriteLine();

            }

        }

    }
}
