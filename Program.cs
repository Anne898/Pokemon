using System;
using System.Collections.Generic;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();

            List<PokemonInParty> party = new List<PokemonInParty>();


            Pokemon pikachu = pokedex.FindPokemonByName("Pikachu");
            Pokemon Wooloo = pokedex.FindPokemonByName("Wooloo");
            Pokemon Vulpix = pokedex.FindPokemonByName("Vulpix");
            Pokemon Togedemaru = pokedex.FindPokemonByName("Togedemaru");
            Pokemon Togepi = pokedex.FindPokemonByName("Togepi");
            Pokemon Litten = pokedex.FindPokemonByName("Litten");

            Pokemon notExistantPokemon = pokedex.FindPokemonByName("Agumon");

            System.Console.WriteLine(pikachu);
            System.Console.WriteLine(notExistantPokemon);

            PokemonInParty pikachuInParty = new PokemonInParty(pikachu, Gender.FEMALE);
            PokemonInParty WoolooInParty = new PokemonInParty(Wooloo, Gender.MALE);
            PokemonInParty VulpixInParty = new PokemonInParty(Vulpix, Gender.MALE);
            PokemonInParty TogedemaruInParty = new PokemonInParty(Togedemaru, Gender.FEMALE);
            PokemonInParty TogepiInParty = new PokemonInParty(Togepi, Gender.FEMALE);
            PokemonInParty LittenInParty = new PokemonInParty(Litten, Gender.MALE);

            party.Add(pikachuInParty);
            party.Add(WoolooInParty);
            party.Add(VulpixInParty);
            party.Add(TogedemaruInParty);
            party.Add(TogepiInParty);
            party.Add(LittenInParty);

            System.Console.WriteLine(party.Count);



            foreach (var pokemon in party)
            {
                System.Console.WriteLine(pokemon);
            }

            pokedex.PrintPokedex();

            PokemonTeam team = new PokemonTeam(LittenInParty, VulpixInParty, pikachuInParty);
        }
    }
}

