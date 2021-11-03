using System;

namespace SharpExtensions.Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = 2.11M;
            Console.WriteLine(number.ToInt());

            int[] arr = { 0, 1, 2, 3, 0, 1 };
            Console.WriteLine(arr.FromArrayToString());
            Console.WriteLine(arr.FromArrayToString("-"));

            decimal[] arrDecimal = { 2.11M, 3.89M, 4.659M, 5.157M, 6.73429M, 7.2349M };
            Console.WriteLine(arrDecimal.FromArrayToString());

            int[] arrOrder = { 2, 3, 0, 1, 5, 4 };
            Console.WriteLine(arrOrder.ToOrderBy().FromArrayToString());

        }
    }
}
