using System.Reflection;

namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2); //The formula "Math.PI * radius * radius" would also produce the correct answer
        }
        static void Main()
        {
            #region Exercise 1
            int x = 10;
            int y = 5;
            int add = x + y;
            int subtract = x - y;
            int multiply = x * y;
            int divide = x / y;
            int modulus = x % y;
            Console.WriteLine($"{x} + {y} = {add}, {x} - {y} = {subtract}, {x} * {y} = {multiply}, {x} / {y} = {divide}, and {x} % {y} = {modulus}");

            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            }
            #endregion

            #region Exercise 2
            Console.WriteLine("What is the radius of your circle ?");
            var radius = double.Parse(Console.ReadLine());
            double answer = Program.AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with a radius of {radius} is {answer}.");
            #endregion

            #region Thought Exercise
            //my guess before running it is k = 4 * 5, which is 20; but as soon as I was hitting the play button, I said "I bet the answer is actually 16..." because I was remembering something from class.
            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine(k);
            #endregion
        }
    }
}