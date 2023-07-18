

//var t1 = new Task(UyqudanTurish);
//var t2 = new Task(Yuvinish);
//var t3 = new Task(ChoyTayyorlash);


//t1.Start();
//t2.Wait(1000);
//t2.Start();
//t3.Wait(1000);
//t3.Start();

//static void UyqudanTurish()
//{
//    Console.WriteLine("Uyqudan Turdim");
//    Console.WriteLine("Yuizimi Yuvgani Kettim");
//}


//static void Yuvinish()
//{

//    Console.WriteLine("Yuzimi Yuvdim");
//    Console.WriteLine("Tishimni Yuvdim");
//    Console.WriteLine("Nonushtaga Kettim");
//}

//static void ChoyTayyorlash()
//{
//    Console.WriteLine("Cofe Tayyorladm");
//    Console.WriteLine("Tuxum qovurdim");
//    Console.WriteLine("Ovqatlandm");
//}

//var t1 = new Task(Uygonish);
//var t2 = new Task(Yuvinish);
//var t3 = new Task(ChoyTayyorlash);

//t2.Start();
//t1.Start();
//t3.Start();
//t3.Wait(2000);

//static void Uygonish()
//{
//    Console.WriteLine("Uyqudan turdim");
//    Console.WriteLine("Yuvingani ketdim");

//}

//static void Yuvinish()
//{
//    Task.Delay(500).Wait();
//    Console.WriteLine("Yuzimni yuvdim");
//    Console.WriteLine("Tishimni yuvdim");
//    Console.WriteLine("Nonushtaga ketdim");

//}

//static void ChoyTayyorlash()
//{
//    Task.Delay(1000).Wait();
//    Console.WriteLine("Cofe tayyorladim");
//    Console.WriteLine("Tuxum pishirdim");
//    Console.WriteLine("Ovqatlandim");
//}



//Console.WriteLine($"Main ishga tushdi");

//Task<int> taskA = AsinxronMethod();

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($" B{i}");
//    Task.Delay(50).Wait();
//}

//Console.WriteLine("taskA ni tugashini kutadi. ");
//await taskA;

//Console.WriteLine($"The result of taskA is {taskA.Result}");
//ConsoleWriteLine("nimadir");

//Console.ReadKey();

//static async Task<int> AsinxronMethod()
//{
//    for (int i = 0; i < 10; i++)
//    {
//        Console.WriteLine($" A{i}");
//        await Task.Delay(100);
//    }
//    int result = 123;
//    Console.WriteLine($" A returns result {result}");
//    return result;
//}d

//static void ConsoleWriteLine(string str)
//{
//    int threadId = Environment.CurrentManagedThreadId;
//    Console.ForegroundColor = threadId == 1 ? ConsoleColor.White : ConsoleColor.Cyan;

//    Console.WriteLine($"{str}{new string(' ', 10 - str.Length)}\nThread {threadId}");
//}