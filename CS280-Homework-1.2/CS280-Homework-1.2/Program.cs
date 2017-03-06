using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_Homework_1._2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            pokemon.Name = "Charmander";
            pokemon.Number = 4f;
            pokemon.Height = 2.0f;
            pokemon.Weight = 18.7f;
            pokemon.Category = "Lizard";
            pokemon.Abilities = "Blaze";
            pokemon.Gender = "M";
            Console.WriteLine("名字:{0}, 編號{1}", pokemon.Name, pokemon.Number);
        }
    }
}