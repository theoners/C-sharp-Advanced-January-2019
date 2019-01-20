namespace _08._Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Ranking
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var contestAndPassword = new Dictionary<string, string>();

            while (input != "end of contests")
            {
                string[] line = input.Split(':');
                string contest = line[0];
                string contestPass = line[1];
                contestAndPassword[contest] = contestPass;
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            var submissions = new Dictionary<string, Dictionary<string, int>>();

            while (input != "end of submissions")
            {
                string[] line = input.Split("=>");
                string contest = line[0];
                string contestPass = line[1];
                string name = line[2];
                int points = int.Parse(line[3]);


                if (contestAndPassword.ContainsKey(contest) && contestAndPassword[contest] == contestPass)
                {
                    if (!submissions.ContainsKey(name))
                    {
                        submissions.Add(name, new Dictionary<string, int>());
                    }
                    UserChecker(submissions, contest, name, points);
                }

                input = Console.ReadLine();
            }

            string user = FindBestUser(submissions);

            Console.WriteLine($"Best candidate is {user} with total {submissions[user].Values.Sum()} points.");
            Console.WriteLine("Ranking:");

            foreach (var kvp in submissions.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var kvpInerDic in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {kvpInerDic.Key} -> {kvpInerDic.Value}");
                }
            }
        }

        private static string FindBestUser(Dictionary<string, Dictionary<string, int>> submissions)
        {
            string bestUser = "";
            int bestPoints = -1;
            foreach (var kvp in submissions)
            {
                int points = kvp.Value.Values.Sum();

                if (points > bestPoints)
                {
                    bestUser = kvp.Key;
                    bestPoints = points;
                }
            }

            return bestUser;
        }

        private static void UserChecker(Dictionary<string, Dictionary<string, int>> submissions, string contest, string name, int points)
        {
            if (!submissions[name].ContainsKey(contest))
            {
                submissions[name].Add(contest, points);
            }
            else
            {
                if (submissions[name][contest] < points)
                {
                    submissions[name][contest] = points;
                }
            }
        }
    }
}