using System;

namespace Pokemon
{

    public enum Gender {
        MALE,
        FEMALE
    }

    class PokemonInParty : Pokemon
    {
        Gender gender;

        public PokemonInParty(string name, int id, Gender gender) : base(name, id) {
            this.gender = gender;
        }

        public PokemonInParty(Pokemon pokemon, Gender gender) : base(pokemon.name, pokemon.id) {
            this.gender = gender;
        }

      
        public override string ToString() {
          
            return $"{this.name} - {this.gender}";
        }
    }
}
