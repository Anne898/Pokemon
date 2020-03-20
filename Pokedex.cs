using System;
using System.Collections.Generic;

namespace Pokemon
{
    class Pokedex
    {
        public HashSet<Pokemon> pokedexRegistry = new HashSet<Pokemon>();

        public Pokedex()
        {

            Pokemon pikachu = new Pokemon("Pikachu", 25);
            Pokemon Wooloo = new Pokemon("Wooloo", 831);
            Pokemon Rowlet = new Pokemon("Wooloo", 722); ;
            Pokemon Pancham = new Pokemon("Pancham", 674);
            Pokemon Litten = new Pokemon("Litten", 725);
            Pokemon Togedemaru = new Pokemon("Togedemaru", 777);
            Pokemon Vulpix = new Pokemon("Vulpix", 37);
            Pokemon Psyduck = new Pokemon("Psyduck", 54);
            Pokemon Snorlax = new Pokemon("Snorlax", 141);
            Pokemon Togepi = new Pokemon("Togepi", 175);

            pokedexRegistry.Add(pikachu);
            pokedexRegistry.Add(Wooloo);
            pokedexRegistry.Add(Rowlet);
            pokedexRegistry.Add(Pancham);
            pokedexRegistry.Add(Litten);
            pokedexRegistry.Add(Togedemaru);
            pokedexRegistry.Add(Vulpix);
            pokedexRegistry.Add(Psyduck);
            pokedexRegistry.Add(Snorlax);
            pokedexRegistry.Add(Togepi);

        }

        public Pokemon FindPokemonByName(string name)
        {


            foreach (var pokemon in pokedexRegistry)
            {
                if (name == pokemon.name)
                {

                    return pokemon;
                }
            }

            return new Pokemon("MissingNo.", 0);
        }

        public Pokemon FindPokemonById(int id)
        {


            foreach (var pokemon in pokedexRegistry)
            {
                if (id == pokemon.id)
                {

                    return pokemon;
                }
            }

            return new Pokemon("MissingNo.", 0);
        }

        public void PrintPokedex()
        {
            System.Console.WriteLine("Pokedex Entries:");
            foreach (var pokemon in pokedexRegistry)
            {
                //pokemon
                System.Console.WriteLine(pokemon);
            }
        }
    }
}
