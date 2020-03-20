using System;
using System.Collections.Generic;

namespace Pokemon  
{
    public class PokemonTeam {
        HashSet<Pokemon> team = new HashSet<Pokemon>();

         //EQUIPO COMPETITIVO 

        public PokemonTeam(Pokemon p1, Pokemon p2, Pokemon p3) {
            
            bool isDuplicated = false;
            if (p1.id == p2.id) {
                isDuplicated = true;
            } else if (p2.id == p3.id) {
            
                isDuplicated = true;
            } else if (p1.id == p3.id) {
               
                isDuplicated = true;
            }

            if (isDuplicated) {
                System.Console.WriteLine("Los Pokemon del equipo competitivo están repetidos!");
            }

            team.Add(p1);
            team.Add(p2);
            team.Add(p3);
        }
    }
}