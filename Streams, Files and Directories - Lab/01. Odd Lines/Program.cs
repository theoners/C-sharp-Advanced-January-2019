namespace _01._Odd_Lines
{
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            using (var reader = new StreamReader(@"Input.txt"))
            {
                using (var writer = new StreamWriter("Output.txt"))
                {
                    int counter = 0;

                    while (true)
                    {
                        var line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }

                        if (counter % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }

                        counter++;
                    }
                }
            }
        }
    }
}
