
//class Program
//{
//    static void Main()
//    {
//DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Shohjahon\Pictures\Screenshots");

//1-misol
//Console.WriteLine("Toliq manzili : " + dir.FullName);
//Console.WriteLine("Atributlari : " + dir.Attributes.ToString());

//2-misol
//FileInfo[] txtFiles = dir1.GetFiles("*.txt");
//Console.WriteLine("txt fayllar soni :"+txtFiles.Length.ToString());
//foreach (FileInfo file in txtFiles)
//{
//    Console.WriteLine("Fayl nomi : {0}",file.Name);
//    Console.WriteLine("Fayl hajmi : {0}", file.Length);
//    Console.WriteLine("Fayl yaratilgan vaqti : {0}", file.CreationTimeUtc);
//    Console.WriteLine("Atributlari : {0}", file.Attributes);
//    Console.WriteLine(Environment.NewLine);
//}

//3-misol
//try
//{
//    dir.CreateSubdirectory("CSharp");
//    dir.CreateSubdirectory(@"CSharp\SubCSharp");
//}
//catch (IOException ex)
//{
//    Console.WriteLine("Papka tuzishda hatolik roy berdi :" + Environment.NewLine +ex.Message);
//}
//Console.WriteLine("Papka yaratildi : ");

//4-misol
//FileInfo file1 = new FileInfo(@"C:\Users\Shohjahon\Pictures\Screenshots\test1.txt");
//FileStream first = file1.Create();
//Console.WriteLine("Fayl yaratilgan vaqt : {0} ", file1.CreationTime);
//first.Close();

//5-misol
//FileInfo file1 = new FileInfo(@"C: \Users\Shohjahon\Pictures\Screenshots\test1.txt");
//file1.Delete();
//Console.WriteLine(file1.FullName + "  Fayl ochirildi !");


//6-misol

//    }
//}






class Program
{
    static void Main()
    {
        string filePath = @"D:\.Net\Uyga_vazifalarim\salom.txt";
        FileInfo fileInfo = new FileInfo(filePath);
        // Check if the file exists
        if (fileInfo.Exists)
        {
            // Read the contents of the file (same as File.ReadAllText)
            //string fileContent = fileInfo.ReadAllText();
            //Console.WriteLine("File Contents:");
            //Console.WriteLine(fileContent);

            // Get the size of the file
            long fileSizeInBytes = fileInfo.Length;
            Console.WriteLine($"File Size: {fileSizeInBytes} bytes");

            // Copy the file to a new location
            string destinationPath = @"D:\\.Net\\Uyga_vazifalarim\\salom.txt";
            fileInfo.CopyTo(destinationPath);

            // Move the file to a different location
            string newLocation = @"C:\\Users\\Shohjahon\\Pictures\\Screenshots\\salom.txt";
            fileInfo.MoveTo(newLocation);

            // Delete the file
            fileInfo.Delete();
            Console.WriteLine("File deleted.");
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
}