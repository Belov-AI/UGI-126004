using System;
using System.IO;

namespace FilesAndDirectories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(!File.Exists("text.txt"))
                File.Create("text.txt").Close();

            if(!File.Exists("copy.txt"))
                File.Copy("text.txt", "copy.txt");

        }
    }
}
