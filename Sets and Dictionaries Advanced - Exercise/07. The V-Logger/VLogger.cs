namespace _07._The_V_Logger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class User
    {
        public List<string> following { get; set; }
        public List<string> followers { get; set; }
    }
    public class VLogger
    {
        public static void Main()
        {
            var vLoggers = new Dictionary<string, User>();

            while (true)
            {
                var input = Console.ReadLine()
                    .Split();
                if (input[0] == "Statistics")
                {
                    break;
                }
                var command = input[1];

                if (command == "joined")
                {
                    var newUser = new User()
                    {
                        following = new List<string>(),
                        followers = new List<string>()
                    };
                    var user = input[0];
                    if (!vLoggers.ContainsKey(user))
                    {
                        vLoggers.Add(user, newUser);

                    }
                }
                else
                {
                    var follower = input[0];
                    var user = input[2];

                    if (vLoggers.ContainsKey(follower) && vLoggers.ContainsKey(user) && user != follower)
                    {
                        if (!vLoggers[user].followers.Contains(follower))
                        {
                            vLoggers[user].followers.Add(follower);
                        }

                        if (!vLoggers[follower].following.Contains(user))
                        {
                            vLoggers[follower].following.Add(user);
                        }
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vLoggers.Keys.Count} vloggers in its logs.");
            var index = 0;
            foreach (var vLogger in vLoggers.OrderByDescending(x => x.Value.followers.Count).ThenBy(x => x.Value.following.Count))
            {
                Console.WriteLine($"{++index}. {vLogger.Key} : {vLogger.Value.followers.Count} followers, {vLogger.Value.following.Count} following");

                if (index == 1)
                {
                    foreach (var follower in vLogger.Value.followers.OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
            }
        }
    }
}
