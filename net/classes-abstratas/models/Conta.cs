using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classes-abstratas.Models
{
    public abstract class Conta
{
    protected decimal saldo;
    public abstract void Creditar(decimal valor)
        public void ExibirSaldo()
    {
        Console.WritLine("O seu saldo é: " + saldo)
        }
}
}