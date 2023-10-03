//Clase 
using net.Models;

Pessoa P = new()
{
    Nome = "Rodrigo",
    Idade = 36
};
P.Apresentar();


//Variáveis 
string apresentação = "Olá, seja bem vindo!";

int quantidade = 1;
double altura = 1.85;
decimal preco = 1.50M;
bool condicao = true;

Console.WriteLine(apresentação);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura);
Console.WriteLine("Valor da variável preco: " + preco);
Console.WriteLine("Valor da variável condicao: " + condicao);

//DateTime
DateTime detaAtual = DateTime.Now.AddDays(3);
Console.WriteLine(detaAtual.ToString("dd/MM/yyyy"));