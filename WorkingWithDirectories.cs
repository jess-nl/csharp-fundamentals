namespace CSharpFundamentals
{
    static class WorkingWithDirectories
    {
        public static void Practice()
        {
            Directory.CreateDirectory(@"/path/to/your/temporary/folder/");

            // .AllDirectories returns all files in the directory and subdirectories
            var files = Directory.GetFiles(@"/path/to/your/requested/folder", "*.cs", SearchOption.AllDirectories);

            foreach (var file in files)
                Console.WriteLine(file);

            // this returns only the directories
            var directories = Directory.GetDirectories(@"/path/to/your/requested/folder", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
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
