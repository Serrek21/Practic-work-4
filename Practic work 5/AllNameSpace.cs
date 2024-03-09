using System;

namespace AllNameSpace
{
    namespace EvenNumbers
    {
        public class EvenNumberGenerator
        {
            public static int[] GenerateEvenNumbers(int count)
            {
                int[] evenNumbers = new int[count];
                for (int i = 0, num = 0; i < count; i++, num += 2)
                {
                    evenNumbers[i] = num;
                }
                return evenNumbers;
            }
        }
    }

    namespace OddNumbers
    {
        public class OddNumberGenerator
        {
            public static int[] GenerateOddNumbers(int count)
            {
                int[] oddNumbers = new int[count];
                for (int i = 0, num = 1; i < count; i++, num += 2)
                {
                    oddNumbers[i] = num;
                }
                return oddNumbers;
            }
        }
    }

    namespace PrimeNumbers
    {
        public class PrimeNumberGenerator
        {
            public static int[] GeneratePrimeNumbers(int count)
            {
                int[] primes = new int[count];
                for (int i = 2, index = 0; index < count; i++)
                {
                    if (IsPrime(i))
                    {
                        primes[index++] = i;
                    }
                }
                return primes;
            }

            private static bool IsPrime(int num)
            {
                if (num < 2)
                    return false;

                for (int i = 2; i <= Math.Sqrt/*Для виведення кореня числа*/(num); i++)
                {
                    if (num % i == 0)
                        return false;
                }

                return true;
            }
        }
    }

    namespace FibonacciNumbers
    {
        public class FibonacciNumberGenerator
        {
            public static int[] GenerateFibonacciNumbers(int count)
            {
                int[] fibonacciNumbers = new int[count];
                int a = 0, b = 1;

                for (int i = 0; i < count; i++)
                {
                    fibonacciNumbers[i] = a;
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
                return fibonacciNumbers;
            }
        }
    }

    // Простір імен для геометричних фігур
    namespace Shapes
    {
        // Базовий клас для геометричних фігур
        public abstract class Shape //Абстрактний класс
        {
            public abstract double Area(); //Абстрактне поле
            public abstract void Draw(); //Абстрактне поле
        }

        // Клас для трикутника
        public class Triangle : Shape /*Успадкування*/
        {
            public double baseLength;
            public double height;

            public Triangle(double baseLength, double height)
            {
                this.baseLength = baseLength;
                this.height = height;
            }

            public override double Area() /*Перевизначення абстрактного Поля*/
            {
                return 0.5 * baseLength * height;
            }

            public override void Draw() /*Перевизначення абстрактного Поля*/
            {
                Console.WriteLine("Drawing Triangle:");
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        // Клас для прямокутника
        public class Rectangle : Shape /*Успадкування*/
        {
            public double length;
            public double width;

            public Rectangle(double length, double width)
            {
                this.length = length;
                this.width = width;
            }

            public override double Area() /*Перевизначення абстрактного Поля*/
            {
                return length * width;
            }

            public override void Draw() /*Перевизначення абстрактного Поля*/
            {
                Console.WriteLine("Drawing Rectangle:");
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        // Клас для квадрата
        public class Square : Shape /*Успадкування*/
        {
            public double side;

            public Square(double side)
            {
                this.side = side;
            }

            public override double Area() /*Перевизначення абстрактного Поля*/
            {
                return side * side;
            }

            public override void Draw() /*Перевизначення абстрактного Поля*/
            {
                Console.WriteLine("Drawing Square:");
                for (int i = 0; i < side; i++)
                {
                    for (int j = 0; j < side; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}