using System;

namespace Pokemon
{
    public class Pokemon
    {
        //Crear pokemones
        public string name;

        public int id;

        public Pokemon(string name, int id) {
            this.name = name;
            this.id = id;
        }

        public override string ToString() {
           
            return $"No. {this.id} - {this.name}";
        }
    }
}