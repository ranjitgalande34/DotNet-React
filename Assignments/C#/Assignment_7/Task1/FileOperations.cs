using System;
using System.IO;

namespace Task1
{
    public static class FileOperations
    {
        public static void CreateFiles()
        {
            File.Create("Demo/file1.txt").Close();
            var fileInfo = new FileInfo("Demo/file2.txt");
            fileInfo.Create().Close();
        }

        public static void WriteToFiles()
        {
            File.WriteAllText("Demo/file1.txt", "Hello from file1");
            var fileInfo = new FileInfo("Demo/file2.txt");
            using (var writer = fileInfo.CreateText())
            {
                writer.Write("Hello from file2");
            }
        }

        public static void CopyFileToDemo2()
        {
            File.Copy("Demo/file1.txt", "Demo/Demo2/file1_copy.txt");
        }

        public static void DeleteAllFiles()
        {
            foreach (var file in Directory.GetFiles("Demo"))
            {
                File.Delete(file);
            }
        }
    }
}
