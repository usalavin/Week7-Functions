using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimest arvu:");
            int userNumber1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teist arvu:");
            int userNumber2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vali tehe (sisesta '+', '-', '*' või '/')");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '+':
                    AddTwoNumbers(userNumber1, userNumber2);
                    break;
                case '/':
                    DivideTwoNumbers(userNumber1, userNumber2);
                    break;
                case '*':
                    Korrutamine(userNumber1, userNumber2);
                    break;
                case '-':
                   Lahutamine(userNumber1, userNumber2);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }

        }

        public static void AddTwoNumbers(int x, int y)
        {
           int result = x + y;
            Console.WriteLine(result);
        }
        
        public static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);
        }

        public static void Lahutamine(int x, int y)
        {
            double result = x - y;
            Console.WriteLine(result);
        }

        public static void Korrutamine(double x, double y)
        {
            double result = x * y;
            Console.WriteLine(result);
        }
    }
}
