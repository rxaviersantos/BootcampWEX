// See https://aka.ms/new-console-template for more information

int[] arrayInteiros = new int[5];

arrayInteiros[0] = 50;
arrayInteiros[1] = 60;
arrayInteiros[2] = 40;


//Percorrendo o array com for
Console.WriteLine("Percorrendo o array com o FOR");
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição n {contador} - {arrayInteiros[contador]}");
}

//Percorrendo o array com foreach
Console.WriteLine("Percorrendo o array com o FOREACH");
int contadorForech = 0;
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Posição n {contadorForech} - {valor}");
    contadorForech++;
}