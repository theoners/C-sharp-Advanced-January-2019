namespace _02._Line_Numbers
{
    using System.IO;

    public class LineNumbers
    {
        public static void Main()
        {
            var lineCounter = 1;
            using (var reader = new StreamReader("../../../text.txt"))
            {
                using (var writer = new StreamWriter("../../../Output.txt"))
                {
                    while (true)
                    {
                        var line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }

                        var specialSymbolCount = 0;
                        var space = 0;
                        foreach (var symbol in line)
                        {
                            if (symbol == ' ')
                            {
                                space++;
                            }
                            else if (!char.IsLetter(symbol))
                            {
                                specialSymbolCount++;
                            }
                        }
                        var symbolCount = line.Length - specialSymbolCount-space;

                        writer.WriteLine($"Line {lineCounter}:{line}({symbolCount})({specialSymbolCount})");
                        lineCounter++;
                    }

                }
            }
        }
    }
}
