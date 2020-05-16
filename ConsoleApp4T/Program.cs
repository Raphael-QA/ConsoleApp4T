using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4T
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            while (true)
            {
                Console.Clear();
                
                Console.WriteLine("Выберие операцию:\n1 - Сложение.\n2 - Вычитание.\n3 - Умножение.\n4 - Деление.\n5 - Квадратный корень.");
                switch (Console.ReadLine())
                {
                    case "1":
                        try
                        {
                            Console.WriteLine("Введите перове чило");
                            class1.a = double.Parse(Console.ReadLine());
                            Console.WriteLine("Введите второе чило");
                            class1.b = double.Parse(Console.ReadLine());
                            Console.WriteLine($"\nРезультат: {class1.Sum(class1.a, class1.b)}\n\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"\nОшибка: {ex.Message}\n\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                        break;
                    case "2":
                        try
                        {
                            Console.WriteLine("Введите перове чило");
                            class1.a = double.Parse(Console.ReadLine());
                            Console.WriteLine("Введите второе чило");
                            class1.b = double.Parse(Console.ReadLine());
                            Console.WriteLine($"\nРезультат: {class1.Min(class1.a, class1.b)}\n\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"\nОшибка: {ex.Message}\n\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                        break;
                    case "3":
                        try
                        {
                            Console.WriteLine("Введите перове чило");
                            class1.a = double.Parse(Console.ReadLine());
                            Console.WriteLine("Введите второе чило");
                            class1.b = double.Parse(Console.ReadLine());
                            Console.WriteLine($"\nРезультат: {class1.Mult(class1.a, class1.b)}\n\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"\nОшибка: {ex.Message}\n\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                        break;
                    case "4":
                        try 
                        { 
                        Console.WriteLine("Введите перове чило");
                        class1.a = double.Parse(Console.ReadLine());
                            
                        Console.WriteLine("Введите второе чило");
                        class1.b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"\nРезультат: {class1.Div(class1.a, class1.b)}\n\nНажмите любую клавишу для продолжения...");
                        Console.ReadKey();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"\nОшибка: {ex.Message}\n\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }                                                                            
                        break;
                    case "5":
                        try
                        {
                            Console.WriteLine("Введите чило");
                            class1.a = double.Parse(Console.ReadLine());
                            Console.WriteLine($"\nРезультат: {class1.Sqrt(class1.a)}\n\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"\nОшибка: {ex.Message}\n\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                        break;
                }
            }
            
        }
    }
}
