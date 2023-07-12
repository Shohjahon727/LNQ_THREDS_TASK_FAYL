namespace Konstruktor;
class Person
{
    public string name;
    public int age;

    public Person() { name = "Nomalum"; age = 18; }      // 1-konstruktor

    public Person(string n) { name = n; age = 18; }         // 2 -konstruktor

    public Person(string n, int a) { name = n; age = a; }   // 3 -konstruktor

    public void GetInfo()
    {
        Console.WriteLine($"Name: {name}  Age: {age}");
    }
}