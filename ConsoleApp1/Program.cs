using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics.Model;

namespace ConsoleApp1
{
    class Program
    {
        public static void Swap<TResult>(ref TResult a, ref TResult b)
        {
            TResult temp;

            temp = a;

            a = b;

            b = temp;
        }

        public static void SwapArray<TResult>(int indexA, int indexB, ref TResult[] array)
        {

            TResult temp = array[indexA];

            array[indexA] = array[indexB];

            array[indexB] = temp;
        }

        public static void TestSwap_With_Integers()
        {
            int a = 10, b = 20;

            Console.WriteLine($"Before swap: a {a} b: {b}");

            Swap<int>(ref a, ref b);

            Console.WriteLine($"After swap: a {a} b: {b}");
        }

        public static void TestSwap_With_Strings()
        {
            string fruit1 = "apple", fruit2 = "orange";

            Console.WriteLine($"Before swap: fruit1 {fruit1} fruit2: {fruit2}");

            Swap<string>(ref fruit1, ref fruit2);

            Console.WriteLine($"After swap: fruit1 {fruit1} fruit2: {fruit2}");
        }

        public static void TestSwap_With_Arrays()
        {
            var collection = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine($"Before swap: collection[0] {collection[0]} collection[1]: {collection[1]}");

            SwapArray<int>(0, 1, ref collection);

            Console.WriteLine($"Before swap: collection[0] {collection[0]} collection[1]: {collection[1]}");
        }

        static void Main(string[] args)
        {
            #region Generic-Class

            TransactionResult<string> results = new TransactionResult<string>();
            results.Success = true;
            results.Result = new List<string> { "A", "B", "C", "D", "E" };

            TransactionResult<int> intResults = new TransactionResult<int>();
            intResults.Success = true;
            intResults.Result = new List<int> { 1, 2, 3, 4, 5 };

            #endregion

            #region Generic-Methods

            //TestSwap_With_Integers();

            //TestSwap_With_Strings();

            //TestSwap_With_Arrays();

            #endregion

        }
    }
}
