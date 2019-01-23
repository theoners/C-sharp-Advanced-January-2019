namespace _6._Hot_Potato
{
    using System;
    using System.Collections.Generic;

    public class HotPotato
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var number = int.Parse(Console.ReadLine());
            var playersName = new Queue<string>(input);

            while (playersName.Count != 1)
            {
                for (int i = 1; i < number; i++)
                {
                    playersName.Enqueue(playersName.Dequeue());
                }

                Console.WriteLine($"Removed {playersName.Dequeue()}");
            }

            Console.WriteLine($"Last is {playersName.Dequeue()}");
        }
    }
}
