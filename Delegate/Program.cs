//using System;

//public delegate Tuple<int, int> TopElementsDelegate(int[] arr);

//public class Program
//{
//    public static Tuple<int, int> TopElements(int[] arr)
//    {
//        if (arr == null || arr.Length == 0)
//            return null;

//        int maxElement = arr[0];
//        int minElement = arr[0];

//        foreach (int item in arr)
//        {
//            if (item > maxElement)
//                maxElement = item;
//            if (item < minElement)
//                minElement = item;
//        }

//        return Tuple.Create(maxElement, minElement);
//    }

//    public static void Main(string[] args)
//    {
//        int[] myList = { 5, 2, 9, 1, 7 };

//        TopElementsDelegate topElementsDelegate = new TopElementsDelegate(TopElements);
//        Tuple<int, int> result = topElementsDelegate(myList);

//        Console.WriteLine($"Eng katta element: {result.Item1}");
//        Console.WriteLine($"Eng kichik element: {result.Item2}");
//    }
//}

using System;

namespace Delegates
{
    class Program
    {
        //delegat e'lon qilish
        public delegate void Print(string s);
        static void Main(string[] args)
        {
            //delegatdan obyekt hosil qilib unga anonim metod tayinlash
            Print print;
            print = delegate (string str)
            {
                Console.WriteLine($"Hello {str}");
            };

            //delegatni chaqirish
            print("DOT-NET.UZ");

            Console.ReadKey();
        }
    }
}

//Chiquvchi:
//  Hello DOT-NET.UZ