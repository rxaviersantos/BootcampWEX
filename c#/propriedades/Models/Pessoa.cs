using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedade.models
{
    public class Pessoa
    {
        private string_nome;
        public string Nome
        {
            get;
            {
                return _nome.ToUpper();
            }

            set;
          {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine{ $"Nome: {Nome}, Idade: {Idade}"};
        }
    }
}