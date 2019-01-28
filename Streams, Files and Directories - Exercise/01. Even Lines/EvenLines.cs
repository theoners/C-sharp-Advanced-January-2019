namespace _01._Even_Lines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class EvenLines
    {
        public static void Main()
        {
            var symbols = new string[] { "-", ",", ".", "!", "?" };
            using (var reader = new StreamReader("../../../text.txt"))
            {
                var counter = 0;
                using (var writer = new StreamWriter("../../../Output.txt"))
                {
                    while (true)
                    {
                        var line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }

                        if (counter % 2 == 0)
                        {
                            var currentLine = string.Empty;
                            foreach (var character in line)
                            {
                                if (symbols.Contains(character.ToString()))
                                {
                                    currentLine += "@";
                                }
                                else
                                {
                                    currentLine += character;
                                }
                            }

                            var wordsArray = currentLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                            var words = new Stack<string>(wordsArray);

                            writer.WriteLine(string.Join(" ", words));
                        }

                        counter++;
                    }
                }
            }
        }
    }
}
