using System;
using System.Collections.Generic;
using System.Text;

namespace Sistemas_de_Animais
{
    abstract class Animal
    {
        

        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }



        public abstract void EmitSom();

        public void Alimentar()
        {
            Console.WriteLine($"{Nome} está sendo alimentado.");
        }
    }
}