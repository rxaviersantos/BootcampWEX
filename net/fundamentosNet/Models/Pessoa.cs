using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net.Models
{
    public class Pessoa
    {
        public required string Nome { get; set; }

        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
        }
    }

}