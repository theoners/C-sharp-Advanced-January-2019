namespace _5._Slice_File
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            using (var reader = new FileStream("sliceMe.txt", FileMode.Open))
            {
                var filePart = (int)Math.Ceiling(reader.Length / 4.0);
                var buffer = new byte[4096];
                for (int i = 1; i <= 4; i++)
                {
                    var totalWrite = 0;
                    var fileName = $"slice - {i}.txt";
                    using (var writer = new FileStream($"{fileName}", FileMode.Create))
                    {
                        while (true)
                        {
                            var readerLength = Math.Min(buffer.Length,filePart-totalWrite);
                            var currentRead = reader.Read(buffer, 0, readerLength);
                            if (currentRead==0)
                            {
                                return;
                            }

                            writer.Write(buffer,0,currentRead);
                            totalWrite += currentRead;
                            if (totalWrite>=filePart)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
