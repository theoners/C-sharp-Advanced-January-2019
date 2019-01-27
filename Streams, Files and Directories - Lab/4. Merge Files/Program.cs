using System;
using System.IO;

namespace _4._Merge_Files
{
    public class Program
    {
        public static void Main()
        {
            using (var firstReader = new StreamReader("FileOne.txt"))
            {

                using (var secondReader = new StreamReader("FileTwo.txt"))
                {

                    using (var writer = new StreamWriter("Output.txt"))
                    {
                        while (true)
                        {
                            var firstFileLine = firstReader.ReadLine();
                            var secondFileLine = secondReader.ReadLine();

                            if (firstFileLine == null && secondFileLine == null)
                            {
                                break;
                            }

                            if (firstFileLine != null)
                            {
                                writer.WriteLine(firstFileLine);
                            }

                            if (firstFileLine != null)
                            {
                                writer.WriteLine(secondFileLine);
                            }

                        }
                    }
                }
            }
        }
    }
}
