//using System;
//namespace Takrorlash
//{
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            string text = "dot-net.uz";
//            int n = 3;
//            print(text, n);
//        }

//        static void print(string s, int n)
//        {
//            for (int i = 0; i < n; i++)
//                Console.Write(s + " ");
//        }

//    }
//}


//using System;
//using System.Collections;

//class Program
//{
//    static void Main()
//    {
//        // Queue yaratamiz va unda elementlarni qo'shamiz
//        Queue myQueue = new Queue();
//        myQueue.Enqueue("Apple");
//        myQueue.Enqueue("Banana");
//        myQueue.Enqueue("Orange");
//        myQueue.Enqueue("nok")

//        // Bir elementni olish
//        object firstElement = myQueue.Dequeue();

//        // Olingan elementni ekranga chiqaramiz
//        Console.WriteLine("Olingan element: " + firstElement);

//        // Qolgani elementlar vaqtincha saqlangan tartibda chiqariladi
//        Console.WriteLine("Qolgani elementlar:");
//        foreach (object element in myQueue)
//        {
//            Console.WriteLine(element);
//        }
//    }
//}


//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        // List yaratamiz va unda elementlarni qo'shamiz
//        List<string> myList = new List<string>();
//        myList.Add("Element1");
//        myList.Add("Element2");
//        myList.Add("Element3");

//        // Elementlarni ekranga chiqaramiz
//        Console.WriteLine("Elementlar:");
//        foreach (string element in myList)
//        {
//            Console.WriteLine(element);
//        }

//        // Olib tashlash uchun indeksni tanlab olamiz (0 dan boshlanadi)
//        int indexToRemove = 4;

//        try
//        {
//            // Indeks bo'yicha elementni olib tashlaymiz
//            string removedElement = myList[indexToRemove];
//            myList.RemoveAt(indexToRemove);
//            Console.WriteLine("Olib tashlangan element: " + removedElement);

//            // Qolgani elementlar chiqariladi
//            Console.WriteLine("Qolgani elementlar:");
//            foreach (string element in myList)
//            {
//                Console.WriteLine(element);
//            }
//        }
//        catch (ArgumentOutOfRangeException)
//        {
//            Console.WriteLine("Indeks xato! Berilgan indeks List hajmi oraliqida bo'lishi kerak.");
//        }
//    }
//}


//var queue = new Queue<int>();
//for (int i = 0; i < 10; i++)
//    queue.Enqueue(i);

//RemoveCenter(5, queue);
//foreach (int i in queue)
//    Console.WriteLine(i);



//void RemoveCenter<T>(int index, Queue<T> queue)
//{
//    if (index < 0 || index >= queue.Count) throw new IndexOutOfRangeException();

//    T[] array = new T[queue.Count];
//    queue.CopyTo(array, 0);
//    queue.Clear();
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (i == index) continue;
//        queue.Enqueue(array[i]);
//    }
//}


//using System;
//using System.Collections;

//class Program
//{
//    static void Main()
//    {

//        Queue myQueue = new Queue();
//        myQueue.Enqueue("Element1");
//        myQueue.Enqueue("Element2");
//        myQueue.Enqueue("Element3");
//        myQueue.Enqueue("Element4");


//        Console.WriteLine("Queue elements:");
//        foreach (object element in myQueue)
//        {
//            Console.WriteLine(element);
//        }


//        int indexToRemove = 3;


//        if (indexToRemove >= 0 && indexToRemove < myQueue.Count)
//        {
//            for (int i = 0; i < indexToRemove; i++)
//            {
//                object elementToDequeue = myQueue.Dequeue();
//            }
//        }
//        else
//        {
//            throw new Exception();
//            //Console.WriteLine("Indeks xato! Berilgan indeks Queue hajmi oraliqida bo'lishi kerak.");
//        }

//        // Qolgani elementlar chiqariladi
//        Console.WriteLine("Remaining elements in the Queue:");
//        foreach (object element in myQueue)
//        {
//            Console.WriteLine(element);
//        }
//    }
//}


using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Queue myQueue = new Queue();
        myQueue.Enqueue("Element1");
        myQueue.Enqueue("Element2");
        myQueue.Enqueue("Element3");
        myQueue.Enqueue("Element4");

        
        Console.WriteLine("Queue elements:");
        foreach (object element in myQueue)
        {
            Console.WriteLine(element);
        }

        int indexToRemove = 6;
         
        List<object> tempList = new List<object>();
        int queueCount = myQueue.Count;
        for (int i = 0; i < queueCount; i++)
        {
            if (i == indexToRemove)
            {
                object elementToDequeue = myQueue.Dequeue();
                
            }
            else
            {
                throw new Exception();
            }
        }
       
        foreach (object element in tempList)
        {
            myQueue.Enqueue(element);
        }

        Console.WriteLine("Remaining elements in the Queue:");
        foreach (object element in myQueue)
        {
            Console.WriteLine(element);
        }
    }
}




