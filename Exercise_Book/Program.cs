
//class exesice1
//{
//    static void Main(string[] args)
//    {
//        var list = new List<int>();
//        list.Add(1);
//        list.Add(2);
//        list.Add(3);
//        list.Add(4);
//        list.Add(5);
//        list.Add(6);
//        var evenNumber = list.Where(n => n % 2 == 0);
//        Console.WriteLine(evenNumber.Count());
//        var intList = new List<int>() { 15, 25, 35 };
//        var avg = intList.Average();
//        Console.WriteLine("Averge : {0}", avg);
//    }
//}



//class exersice2
//{
//    static void Main(string[] args)

//    {
//        int[] scores = new int[] {100,97,85,56,72,50,63};

//        IEnumerable<int> scoreQuery=
//            from score in scores
//            where score > 60
//            select score;
//        foreach(int score in scoreQuery)
//        {
//            Console.WriteLine(score + " ");
//        }
//    }
//}


//class exercise3
//{
//    static void Main()
//    {
//        List<int> list = new List<int>() { 9, 2, 3, 4, 5, 6, 7, 8, 1 };
//        var querySyntax = from obj in list
//                          where obj > 5
//                          select obj;
//        foreach(var item1 in querySyntax)
//        {
//            Console.WriteLine(item1);
//        }

//        Console.WriteLine("______________________________");
//        var methodSyntax =  list.Where(obj => obj > 5);
//        foreach (var item2 in methodSyntax)
//        {
//            Console.WriteLine(item2);
//        }

//        Console.WriteLine("_______________________________");

//        var mixedSyntax = (from obj in list
//                           select obj).Max();
//        Console.WriteLine("Max value :" + mixedSyntax);
//    }
//}


//class exercise4
//{
//    static void Main()
//    {
//        List<MyFamily> myFamilies = new List<MyFamily>()
//        {
//            new MyFamily() { id = 1, name = "Shohruh"},
//            new MyFamily() { id = 2, name = "Shohboz"},
//            new MyFamily() { id = 3, name = "Nodirbek"},
//            new MyFamily() { id = 4, name = "Shohjahon"},
//            new MyFamily() { id = 5, name = "Zeboxon"}
//        };
//        var basicQuery = myFamilies.ToList();
//        Console.WriteLine("BasicQuery : ");
//        foreach(var item in basicQuery)
//        {
//            Console.WriteLine($" ID : {item.id}  Name : {item.name} ");
//        }

//    }
//}

//class MyFamily
//{
//    public int id { get; set; }
//    public string name { get; set; }
//}




//class exercise5
//{
//    static void Main()
//    {
//        List<string> strings = new List<string>() { "Salom" , "Homework"};
//        var result = strings.SelectMany(s => s).ToList();
//        foreach(var item in result)
//        {
//            Console.Write(item + " ");
//        }
//    }
//}


//class exercise6
//{
//    static void Main()
//    {
//        List<Oila> oilas = new List<Oila>()
//        {
//            new Oila() {age = 51, name = "Ulugbek"},
//            new Oila() {age = 49, name = "Zarifaxon"},
//            new Oila() {age = 13, name = "Zeboxon"},
//            new Oila() {age = 17, name = "Nodirbek"},
//            new Oila() {age = 20, name = "Shohjahon"},
//            new Oila() {age = 27, name = "Shohboz"},
//            new Oila() {age = 29, name = "Shohruh"},
//        };
//        var result = from rst in oilas
//                     where rst.age > 20
//                     select rst;
//        foreach(var i in result)
//        {
//            Console.WriteLine($"Name : {i.name}  Age : {i.age} ");
//        }
//    }
//}
//class Oila
//{
//    public int age { get; set; }
//    public string name { get; set; }
//}




//class exercie7
//{
//    static void Main(string[] args)
//    {
//        List<Employee> employees = new List<Employee>()
//            {
//                new Employee(){Id = 1, Name = "Muhammadkarim", Email = "muhammadkarim@gmail.com", Programming = new List<string>(){"PHP", "C#", "SQL"} },
//                new Employee(){Id = 2, Name = "Jasurbek", Email = "jasur@gmail.com", Programming = new List<string>(){"C++", "C#", "Arduino"}},
//                new Employee(){Id = 3, Name = "Xondamir", Email = "xondamir", Programming = new List<string>(){"C#", "Python", "MVC"}}
//            };
//        var MethodSyntax = employees.SelectMany(x => x.Programming);
//        foreach (var item in MethodSyntax)
//        {
//            Console.WriteLine(item);
//        }
//        //Output: PHP, C#, SQL, C++, C#, Arduino, C#, Python, MVC
//    }
//}
//class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string Email { get; set; }
//    public List<String> Programming { get; set; }
//}



//class exercise8
//{
//    static void Main()
//    {
//        List<MyFamily> myFamilies = new List<MyFamily>()
//        {
//            new MyFamily() { id = 1, name = "Shohruh", result = 50},
//            new MyFamily() { id = 2, name = "Shohboz", result = 70},
//            new MyFamily() { id = 3, name = "Nodirbek", result = 90},
//            new MyFamily() { id = 4, name = "Shohjahon", result = 110},
//            new MyFamily() { id = 5, name = "Zeboxon", result = 130}
//        };
//        var basicQuery = myFamilies.Where(x => x.result >= 90).Select(p => p.name).ToList();
//        Console.WriteLine("BasicQuery : ");
//        foreach (var item in basicQuery)
//        {
//            Console.WriteLine($" {item} ");
//        }

//    }
//}
//class MyFamily
//{
//    public int id { get; set; }
//    public string name { get; set; }
//    public int result { get; set; }
//}





//class exercise9
//{
//    static void Main(string[] args)
//    {
//        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//        var MethodSyntax = numbers.Where(x => x > 4 && x < 7).ToList();
//        foreach (var item in MethodSyntax)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}


//class exercise10
//{
//    static void Main(string[] args)
//    {
//        var DataSource = new List<object>() { 'a', "Jasur", "Xondamir", 1, 2, 3, 4, };
//        var selected = DataSource.OfType<string>();
//        foreach (var item in selected)
//        {
//            Console.WriteLine(item);
//        }
//        // Output: Jasur, Xondamir
//    }
//}


//class exercise11
//{
//    static void Main()
//    {
//        List<Salom> saloms = new List<Salom>()
//        { 
//            new Salom() { id = 1, name = "Shohjahon", email  =  "alijonov_ooo.gmail.com", programming = new List<string>() { "C++","C#","Python"} },
//            new Salom() { id = 2, name = "Jasurbek", email = "jasur@gmail.com", programming = new List<string>(){"C++", "C#", "Arduino"}},
//            new Salom() { id = 3, name = "Xondamir", email = "xondamir", programming = new List<string>(){"C#", "Python", "MVC"}}

//         };
//        var result = saloms.SelectMany(x => x.programming);
//        foreach(var i in result)
//        {
//            Console.Write(i+" ");
//        }

//    }
//}
//class Salom
//{
//    public int id { get; set; }
//    public string name { get; set; }
//    public string email { get; set; }
//    public List<string> programming { get; set; }
//}


//class exercise12
//{
//    static void Main()
//    {
//        List<Example> examples = new List<Example>()
//        {
//            new Example () { id = 1, name = "a", result = 85 },
//            new Example () { id = 2, name = "b", result = 90 },
//            new Example () { id = 3, name = "c", result = 34 },
//            new Example () { id = 4, name = "d", result = 76 },
//            new Example () { id = 5, name = "e", result = 65 },
//        };
//        var newresult = examples.Where(x => x.result > 60).Select(p => p.name).ToList();
//        foreach(var i in  newresult)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}
//class Example
//{
//    public int id { get; set; }
//    public string name { get; set; }
//    public int result { get; set; }
//}



//class exercise13
//{
//    static void Main()
//    {
//        var example = new List<object>() { 'a', "Salom", 1, 5, 6, "Dunyo", 212 };
//        var result = example.OfType<int>();
//        foreach( var item in result )
//        {
//            Console.WriteLine(item);
//        }
//    }
//}


//class exercise14
//{
//    static void Main()
//    {
//        List<Example> examples = new List<Example>()
//        {
//            new Example () { id = 1, name = "a", result = 85 },
//            new Example () { id = 2, name = "b", result = 90 },
//            new Example () { id = 3, name = "c", result = 34 },
//            new Example () { id = 4, name = "d", result = 76 },
//            new Example () { id = 5, name = "e", result = 65 },
//        };
//        var newresult = examples.OrderBy(x => x.result).Where(y => y.result > 60).Select(p => p.name).ToList();
//        foreach (var i in newresult)
//        {
//            Console.WriteLine(i);   
//        }
//    }
//}
//class Example
//{
//    public int id { get; set; }
//    public string name { get; set; }
//    public int result { get; set; }
//}


//class exercise15
//{
//    static void Main(string[] args)
//    {
//        List<Employee> employees = new List<Employee>()
//            {
//                new Employee() { Id = 1, FirstName = "Muhammadkarim", Lastname = "To'xtaboyev"},
//                new Employee() { Id = 2, FirstName = "Zokirjon", Lastname = "Xasanboyev" },
//                new Employee() { Id = 3, FirstName = "Jasurbek", Lastname = "Xasanboyev" }
//            };

//        var MethodSyntax = employees.OrderBy(x => x.Lastname).ThenBy(x => x.FirstName);
//        foreach (var emp in MethodSyntax)
//        {
//            Console.WriteLine($"{emp.Id} {emp.Lastname} {emp.FirstName}");
//        }
//        /* Output: 1 To'xtaboyev Muhammadkarim
//                   3 Xasanboyev Jasurbek
//                   2 Xasanboyev Zokirjon
//        */

//    }
//}
//class Employee
//{
//    public int Id { get; set; }
//    public string FirstName { get; set; }
//    public string Lastname { get; set; }
//}


//class exercise16
//{
//    static void Main(string[] args)
//    {
//        List<Employee> employees = new List<Employee>()
//            {
//                new Employee() { id = 1, name = "Zarif", email = "zarif@gmail.com"},
//                new Employee() { id = 2, name = "Muhammadkarim", email = "muhammadkarim@gmail.com"},
//                new Employee() { id = 3, name = "Xumoyun", email = "xumoyun@gmail.com"},
//                new Employee() { id = 4, name = "Akrom", email = "akrom@gmail.com"},
//                new Employee() { id = 5, name = "Jasur", email = "jasur@gmail.com"},
//                new Employee() { id = 6, name = "Mirzo Ulug`bek", email = "mirzoulugbek@gmail.com"},
//                new Employee() { id = 7, name = "Behzod", email = "behzod@gmail.com"}
//            };

//        var basicQuery = (from emp in employees
//                          select emp).ToList();
//        Console.WriteLine("Basic Query: ");
//        foreach (var item in basicQuery)
//        {
//            Console.WriteLine($"Id = {item.id} Name: {item.name}");
//        }

//        Console.WriteLine("#--------#--------#---------#");

//        //-----------------------------------------//

//        var basicMethod = employees.ToList();
//        Console.WriteLine("Basic Method: ");
//        foreach (var item in basicMethod)
//        {
//            Console.WriteLine($"Id = {item.id} Name: {item.name}");
//        }

//        Console.WriteLine("#--------#---------#---------#");

//        //-----------------------------------------//

//        var basicPropQuery = (from emp in employees
//                              select emp.id).ToList();
//        Console.WriteLine("Basic property query: ");
//        foreach (var item in basicPropQuery)
//        {
//            Console.WriteLine($"Id = {item}");
//        }

//        Console.WriteLine("#--------#---------#---------#");

//        //-----------------------------------------//

//        var basicPropMethod = employees.Select(emp => emp.name);
//        Console.WriteLine("Basic property method: ");
//        foreach (var item in basicPropMethod)
//        {
//            Console.WriteLine($"Id = {item}");
//        }

//        Console.WriteLine("#--------#---------#---------#");

//        //-----------------------------------------//

//        var selectQuery = (from emp in employees
//                           select new Student()
//                           {
//                               stId = emp.id,
//                               stName = emp.name,
//                               stEmail = emp.email
//                           }).ToList();
//        Console.WriteLine("Select query: ");
//        foreach (var item in selectQuery)
//        {
//            Console.WriteLine($"Id = {item.stId} Name: {item.stName}");
//        }

//        Console.WriteLine("#--------#---------#---------#");

//        //-----------------------------------------//

//        var selectMethod = (employees.Select(emp => new Student() { stId = emp.id, stName = emp.name, stEmail = emp.email })).ToList();

//        Console.WriteLine("Select method: ");
//        foreach (var item in selectMethod)
//        {
//            Console.WriteLine($"Id = {item.stId} Name: {item.stName}");
//        }

//        Console.WriteLine("#--------#---------#---------#");

//        //-----------------------------------------//

//        var query = employees.Select((emp, index) => new { Index = index, stName = emp.name }).ToList();

//        // Bu query yozishning eng yaxshi ko`rinishlaridan biridir

//    }
//    class Employee
//    {
//        public int id { get; set; }
//        public string name { get; set; }
//        public string email { get; set; }
//    }
//    class Student
//    {
//        public int stId { get; set; }
//        public string stName { get; set; }
//        public string stEmail { get; set; }
//    }
//}



// C# program to illustrate the
// concept of foreground thread

//class GFG
//{

//    // Main method
//    static void Main(string[] args)
//    {

//        // Creating and initializing thread
//        Thread thr = new Thread(mythread);
//        thr.Start();
//        Console.WriteLine("Main Thread Ends!!");
//    }

//    // Static method
//    static void mythread()
//    {
//        for (int c = 0; c <= 3; c++)
//        {
//            Thread.Sleep(500);
//            Console.WriteLine("mythread is in progress!!");
            
//        }
//        Console.WriteLine("mythread ends!!");
//    }
//}


class GFG
{
     
    // Main method
    static void Main(string[] args)
    {
        // Creating and initializing thread
        var thr = new Thread(mythread);

        // Name of the thread is Mythread
        thr.Name = "Mythread";
        thr.Start();

        // IsBackground is the property of Thread
        // which allows thread to run in the background
        thr.IsBackground = true;

        Console.WriteLine("Main Thread Ends!!");
    }

    // Static method
    static void mythread()
    {

        // Display the name of the
        // current working thread
        Console.WriteLine("In progress thread is: {0}",
                            Thread.CurrentThread.Name);

        Thread.Sleep(2000);
         
        Console.WriteLine("Completed thread is: {0}",
                          Thread.CurrentThread.Name);
    }
}
