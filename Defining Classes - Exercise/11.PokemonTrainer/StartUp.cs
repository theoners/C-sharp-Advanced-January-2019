namespace _11.PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var trainers = new List<Trainer>();
            while (true)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Tournament")
                {
                    break;
                }
                var trainerName = input[0];
                var pokemonName = input[1];
                var pokemonElement = input[2];
                var pokemonHealth = int.Parse(input[3]);
                var pokemon = new Pokemon(pokemonName,pokemonElement,pokemonHealth);
                if (trainers.Exists(x=>x.Name==trainerName))
                {
                    var currentTrainerIndex = trainers.FindIndex(x => x.Name == trainerName);
                    trainers[currentTrainerIndex].CollectionOfPokemon.Add(pokemon);
                }
                else
                {
                    var trainer = new Trainer(trainerName,pokemon);
                    trainers.Add(trainer);
                }
            }

            while (true)
            {
                var input = Console.ReadLine();
                if (input=="End")
                {
                    break;
                }

                foreach (var trainer in trainers)
                {
                    if (trainer.CollectionOfPokemon.Exists(x=>x.Element==input))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        trainer.CollectionOfPokemon.ForEach(x => x.Health -= 10);
                        trainer.CollectionOfPokemon.RemoveAll(x => x.Health <= 0);
                    }
                }
            }

            foreach (var trainer in trainers.OrderByDescending(x=>x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.CollectionOfPokemon.Count}");
            }
        }
    }
}
