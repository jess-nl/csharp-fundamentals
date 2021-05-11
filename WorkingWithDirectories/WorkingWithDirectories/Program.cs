using System;
using System.IO;

namespace WorkingWithDirectories
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Directory.CreateDirectory(@"/Users/jay/Desktop/csharp-fundamentals/WorkingWithDirectories/temp/folder1/");

            // .AllDirectories returns all files in the directory and subdirectories
            var files = Directory.GetFiles(@"/Users/jay/Desktop/csharp-fundamentals", "*.sln", SearchOption.AllDirectories);

            foreach (var file in files)
                Console.WriteLine(file);

            // this returns only the directories
            var directories = Directory.GetDirectories(@"/Users/jay/Desktop/csharp-fundamentals", "*.*", SearchOption.AllDirectories);
            foreach  (var directory in directories)
                Console.WriteLine(directory);

            // specify a path in "..."
            Directory.Exists("...");

            // specify a path in "..."
            var directoryInfo = new DirectoryInfo("...");

            // get all files
            directoryInfo.GetFiles();

            // get all directories
            directoryInfo.GetDirectories();
        }
    }
}
