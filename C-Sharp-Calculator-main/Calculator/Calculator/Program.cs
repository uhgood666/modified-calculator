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
            // Ввод первого значения
            Console.Write("Enter first value: ");
            int no1 = int.Parse(Console.ReadLine());

            // Ввод второго значения
            Console.Write("Enter second value: ");
            int no2 = int.Parse(Console.ReadLine());

            // Вывод информации для операции сложение
            Console.WriteLine("Enter 1 for addition");

            // Вывод информации для операции вычитание
            Console.WriteLine("Enter 2 for subtraction");

            // Вывод информации для операции умножение
            Console.WriteLine("Enter 3 for multiplication");

            // Вывод информации для операции деление
            Console.WriteLine("Enter 4 for division");

            // Вывод информации для операции процент
            Console.WriteLine("Enter 5 for answ");

            // Вывод информации для операции возведение в степень 
            Console.WriteLine("Enter 6 for step");

            // Вывод информации для операции извлечение корня
            Console.WriteLine("Enter 7 for root");

            // Выбор операции
            Console.Write("Enter an operation to perform: ");
            int op = int.Parse(Console.ReadLine());

            // Операция сложение
            if (op == 1)
            {
                int sum = no1 + no2;
                Console.WriteLine("Value = " + sum);
            }

            // Операция Вычитание
            else if (op == 2)
            {
                int sub = no1 - no2;
                Console.WriteLine("Value = " + sub);
            }

            // Операция умножение
            else if (op == 3)
            {
                int mul = no1 * no2;
                Console.WriteLine("Value = " + mul);
            }

            // Операция деление
            else if (op == 4)
            {
                int div = no1 / no2;
                Console.WriteLine("Value = " + div);
            }
            // Операция процент
            else if (op == 5)
            {
                int ansv = no1 % no2;
                Console.WriteLine("Value = " + ansv);
            }

            // Операция возведение в степень
            double degree;
            if (op == 6)
            {
                degree = Math.Pow(no1, 2);
                Console.WriteLine("Value = " + degree);
                degree = Math.Pow(no2, 2);
                Console.WriteLine("Value = " + degree);
            }

            // Операция извлечение корня
            double root;
            if (op == 7)
            {
                root = Math.Sqrt(no1);
                Console.WriteLine("Value = " + root);
                root = Math.Sqrt(no2);
                Console.WriteLine("Value = " + root);
            }

            // Вывод при неправильной операции
            else
            {
                Console.WriteLine("Invalid operation!");
            }

            Console.WriteLine("Operation completed!");

            Console.ReadLine();
        }
    }
}
