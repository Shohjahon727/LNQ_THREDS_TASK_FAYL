namespace Konstruktor;
class Program
{
    static void Main(string[] args)
    {
        Person Ali =new Person(); 
        Person Vali = new Person("Salom");
        Person Gani =new Person ("Qalesan");
        Ali.GetInfo();
        Vali.GetInfo();
        Gani.GetInfo();
    }
}