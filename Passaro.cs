using System;
using System.Collections.Generic;
using System.Text;

namespace Sistemas_de_Animais
{
    internal class Passaro : Animal
    {

        public Passaro(string nome, int idade, double peso)
        {
            Nome = nome;
            Idade = idade;
            Peso = peso;
        }






        public override void EmitSom()
        {
            Console.WriteLine("Piu Piu!");
        }
    
    }
}
