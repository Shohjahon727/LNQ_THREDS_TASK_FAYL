//Tuple<int, string, string> person = new Tuple<int, string, string>(20, "Shohjahon", "Alijonov");
//var person = Tuple.Create(3, " - Kurs Salom ", 2, "- Xayr");
//Console.Write(person.Item1);
//Console.WriteLine(person.Item2);
//Console.Write(person.Item3);
//Console.Write(person.Item4);

//var person = Tuple.Create(1, "Stive", "Jobs");
//DisplayTuple(person);



//static void DisplayTuple (Tuple <int, string, string> person)
//{
//    Console.WriteLine($"Id = {person.Item1}");
//    Console.WriteLine($"First name = {person.Item2}");
//    Console.WriteLine($"Last name = {person.Item3}");
//}


//var person = GetPerson();

//static Tuple<int ,string ,string > GetPerson()
//{
//    return Tuple.Create(1, "Bill", "Gates");
//}

//namespace Tuple
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var tuple1 = ("dotnetuz", "Csharp", 2021);
//            Console.WriteLine("Sayt :" + tuple1.Item1);
//            Console.WriteLine("Dasturlash tili :" + tuple1.Item2);
//            Console.WriteLine("Yil :" + tuple1.Item3);
//        }
//    }
//}


/// <summary>
/// Alibaba nomli metod ochdik
/// Va Alibaba kompaniya haqida malumotlar kiritish uchun ValueTuple dan foydalandik
/// </summary>

//    var alibaba = Alibaba();
//    Console.WriteLine(alibaba.Kompaniya_tarixi);

//static (string Kompaniya_tarixi, string Foydasi, string Nufuzi) Alibaba()
//{
//    var kompaniya_tarixi = "Alibaba Group Holding Limited — Alibaba Group va Alibaba.com sifatida tanilgan, Xitoyning elektron tijorat, chakana savdo,\n Internet va texnologiyalarga ixtisoslashgan transmilliy texnologik kompaniyasi. \n1999-yil 28-iyunda Chjetszyan shahrining Xanchjou shahrida tashkil etilgan[1].\n Kompaniya veb-portallar orqali isteʼmolchidan isteʼmolchiga (C2C),\n biznesdan isteʼmolchiga (B2C) va biznesdan biznesga (B2B) savdo xizmatlarini taqdim etadi.\n Elektron toʻlov xizmatlari, xarid qilish qidiruv tizimlari va bulutli hisoblash xizmatlari mavjud.\n U dunyodagi ko'plab biznes sohalarida turli xil kompaniyalar portfeliga egalik qiladi va ishlaydi[2]. \nBuyuk Britaniyaning dunyo bozorini o‘rganuvchi «Kantar» kompaniyasi dunyoning eng qimmat kompaniyalari reytingini e’lon qildi. ";
//    var foydasi = "25 mlrd AQSh dollar";
//    var nufuzi = "Jaxon reytingini kuchli o'ntaligida 'Alibab' turadi ";
//    return (kompaniya_tarixi, foydasi, nufuzi);
//}


   var anonim = new { }