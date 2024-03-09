using System;
namespace AllNameSpace
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Even Numbers:");
                int[] evenNumbers = EvenNumbers.EvenNumberGenerator.GenerateEvenNumbers(5);
                PrintNumbers(evenNumbers);

                Console.WriteLine("\n\nOdd Numbers:");
                int[] oddNumbers = OddNumbers.OddNumberGenerator.GenerateOddNumbers(5);
                PrintNumbers(oddNumbers);

                Console.WriteLine("\n\nPrime Numbers:");
                int[] primeNumbers = PrimeNumbers.PrimeNumberGenerator.GeneratePrimeNumbers(5);
                PrintNumbers(primeNumbers);

                Console.WriteLine("\n\nFibonacci Numbers:");
                int[] fibonacciNumbers = FibonacciNumbers.FibonacciNumberGenerator.GenerateFibonacciNumbers(5);
                PrintNumbers(fibonacciNumbers);


            Shapes.Triangle triangle = new Shapes.Triangle(5, 8);
            Console.WriteLine("Triangle Area: " + triangle.Area());
            triangle.Draw();

            Shapes.Rectangle rectangle = new Shapes.Rectangle(4, 6);
            Console.WriteLine("Rectangle Area: " + rectangle.Area());
            rectangle.Draw();

            Shapes.Square square = new Shapes.Square(3);
            Console.WriteLine("Square Area: " + square.Area());
            square.Draw();  
        }

            static void PrintNumbers(int[] numbers)
            {
                foreach (var number in numbers)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }

        }
}
