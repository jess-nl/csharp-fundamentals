using System;
using System.IO;

namespace WorkingWithFiles
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";

            File.Copy(@"c:\temp\myFile.jpg", @"d:\temp\myfilejpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }
        }
    }
}
