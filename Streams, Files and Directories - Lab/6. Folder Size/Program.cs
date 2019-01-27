namespace _6._Folder_Size
{
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            string[] files = Directory.GetFiles("../../../TestFolder");
            double sum = 0;
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }
            sum = sum / 1024 / 1024;
            File.WriteAllText("Output.txt", sum.ToString());

        }
    }
}
