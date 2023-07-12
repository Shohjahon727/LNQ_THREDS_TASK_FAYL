namespace Learning_C_;
class Program
{
    static void Main(string[] args)
    {
        BrikMold brik = new BrikMold();
        Console.WriteLine(brik.width);
        Console.WriteLine(brik.hight);
        Console.WriteLine(brik.length);
        Console.ReadKey();
    }
}