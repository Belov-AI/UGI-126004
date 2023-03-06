using System;
using System.IO;

namespace FilesAndDirectories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("text.txt"))
                File.Create("text.txt").Close();

            if (!File.Exists("copy.txt"))
                File.Copy("text.txt", "copy.txt");

            //File.Delete("text.txt");

            var myFile = new FileInfo("copy.txt");
            myFile.Delete();

            var s = File.ReadAllText("text.txt");
            Console.WriteLine(s);

            File.WriteAllText("text.txt", "Третья строка.");
            PrintFile("text.txt");

            File.WriteAllLines("text.txt",
                new[]
                {
                    "Первая строка.",
                    "Вторая строка."
                });
            PrintFile("text.txt");

            File.AppendAllLines("text.txt",
                new[]
                {
                    "Третья строка.",
                    "Четвертая строка."
                });
            PrintFile("text.txt");

            Console.WriteLine();
            using(var f = new StreamReader("text.txt"))
            {
                while(!f.EndOfStream)
                {
                    var line = f.ReadLine().ToLower();
                    Console.WriteLine(line);
                }
            }

            //var bytes = File.ReadAllBytes("text.txt");
            //foreach (var b in bytes)
            //    Console.WriteLine(b);

            var dir = Directory.CreateDirectory("Data");
            Console.WriteLine(dir.FullName);
            Console.WriteLine(dir.Exists);

            FileStream file;
            var path = Path.Combine(dir.FullName, "1.txt");
            if (!File.Exists(path))
                file = File.Create(path);
            else
                file = File.Open(path, FileMode.Open, FileAccess.ReadWrite);

            Console.WriteLine(file.Name);

            using (var stream = new StreamWriter(file))
            {
                stream.WriteLine("Первая строка");
                stream.WriteLine("Вторая строка");
            }

            Console.WriteLine(File.ReadAllText(file.Name));


                Console.ReadKey();
        }

        private static void PrintFile(string name)
        {
            Console.WriteLine();
            var lines = File.ReadAllLines(name);
            foreach (var line in lines)
                Console.WriteLine(line);
        }
    }
}
