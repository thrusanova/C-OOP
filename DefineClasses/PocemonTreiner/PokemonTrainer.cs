using System;
using System.Collections.Generic;
using System.Linq;

namespace PocemonTreiner
{
    class PokemonTrainer
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            var trList = new List<Trainer>();
            var pokList = new List<Pokemon>();
            while (str!= "Tournament")
            {
                string[] input = str.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                string trainer = input[0];
                string pokemonName = input[1];
                string element = input[2];
                int pokemonHealth = int.Parse(input[3]);
                var currTrainer = new Trainer(trainer);
               // trList.Add(currTrainer);
                var currPokemon = new Pokemon(pokemonName, element, pokemonHealth);
              //  pokList.Add(currPokemon);
                currTrainer.pokemons.Add(currPokemon);
                bool isAdd = false;
                foreach (var tr in trList)
                {
                    if (tr.Name==trainer)
                    {
                        tr.pokemons.Add(currPokemon);
                        isAdd = true;
                        break;
                    }
                }
                if (!isAdd)
                {
                    trList.Add(currTrainer);
                }
                str = Console.ReadLine();
            }
            string elem = Console.ReadLine();
            int num = 0;
            while (elem!="End")
            {
                foreach (var tr in trList)
                {
                    for (int i =0; i < tr.pokemons.Count; i++)
                    {
                        if (tr.pokemons[i].Element==elem)
                        {
                            tr.Badges++;
                                                  
                        }
                        else
                        {
                            tr.pokemons[i].Health -= 10;
                            if (tr.pokemons[i].Health<=0)
                            {
                                tr.pokemons = tr.pokemons.Where(pok => pok.Health > 0).ToList();
                               

                            }
                        }
                        num++;
                    }
                    
                }
                elem = Console.ReadLine();
            }
            trList = trList.OrderByDescending(t => t.Badges).ToList();
            foreach (var tr in trList)
            {
                Console.WriteLine($"{tr.Name} {tr.Badges} {tr.pokemons.Count}");
            }
            }

        }
    }
