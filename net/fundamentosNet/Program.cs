//Clase 
using net.Models;

internal class Programa
{
    private static void Main(string[] args)
    {
        Pessoa P = new()
        {
            Nome = "Rodrigo",
            Idade = 36
        };
        P.Apresentar();


        //Variáveis /////////////////////////////////////////////////////////////////
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

        //DateTime /////////////////////////////////////////////////////////////////
        DateTime detaAtual = DateTime.Now.AddDays(3);
        Console.WriteLine(detaAtual);


        //Operador de atribuição /////////////////////////////////////////////////////////////////
        int a = 10;
        int c = 23;

        int b = a + c;

        Console.WriteLine(b);

        //Convertendo tipos de varáveis 
        //Diferença emntre Convert e Parse: Parse não aceitará valor Null e encerrará o programa,
        // enquanto o Convert ao passar valor Null ele retornará o valor de 0 
        int e = Convert.ToInt32("6");
        Console.WriteLine(e);

        int d = int.Parse("7");
        Console.WriteLine(d);

        //Conversão Tipo String /////////////////////////////////////////////////////////////////
        int inteiro = 8;
        string h = inteiro.ToString();
        Console.WriteLine("h");

        //Cast implicíto /////////////////////////////////////////////////////////////////
        int j = 6;
        double k = j;
        Console.WriteLine(k);

        int m = 9;
        long o = m;
        Console.WriteLine(m);

        int t = int.MaxValue;
        long s = t;
        Console.WriteLine(s);

        //Ordem dos operadores /////////////////////////////////////////////////////////////////
        double x = 15 / (1 + 4);
        Console.WriteLine(x);

        double z = 15 / 1 + 4;
        Console.WriteLine(z);

        string v = "15";
        int n = Convert.ToInt32(v);
        Console.WriteLine(n);


        string l = "56-";
        // int f = 8;
        int.TryParse(l, out int f);

        Console.WriteLine(f);
        Console.WriteLine("Conversão realizada com sucesso!");

        //Operador condicional /////////////////////////////////////////////////////////////////
        int quantidadeEstoque = 20;

        int quantidadeCompra = 5;
        bool possivelVenda = quantidadeEstoque >= quantidadeCompra;


        Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
        Console.WriteLine($"Quantidade em compra: {quantidadeCompra}");
        Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

        if (possivelVenda)
        {
            Console.WriteLine("Venda realizada!");
        }
        else
        {
            Console.WriteLine("Desculpe. Não temos a quantidade em estoque.");
        }


        // IF aninhado////////////////////////////////////////////////////////////
        int qtdeEstoque = 40;

        int qtdeCompra = 25;
        bool possVenda = qtdeCompra > 0 && qtdeEstoque >= qtdeCompra;


        Console.WriteLine($"Quantidade em estoque: {qtdeEstoque}");
        Console.WriteLine($"Quantidade em compra: {qtdeCompra}");
        Console.WriteLine($"É possivel realizar a venda? {possVenda}");

        if (qtdeCompra == 0)
        {
            Console.WriteLine("Venda inválida");
        }
        else if (possVenda)
        {
            Console.WriteLine("Venda realizada!");
        }
        else
        {
            Console.WriteLine(value: "Desculpe. Não temos a quantidade em estoque.");
        }

        //switch case/////////////////////////////////////////////////////////////////
        Console.WriteLine("Digite uma letra");
        string letra = Console.ReadLine();

        switch (letra)
        {
            case "a":
            case "e":
            case "i":
            case "o":
            case "u":
                Console.WriteLine("É uma vogal");
                break;

            default:
                Console.WriteLine("Não é uma vogal");
                break;

        }

        //Operadores Lógicos /////////////////////////////////////////////////////////////////
        bool ehMaiorDeIdade = true;
        bool possuitAutorizacaoDoResponsavel = false;

        if (ehMaiorDeIdade || possuitAutorizacaoDoResponsavel)
        {
            Console.WriteLine("Ëntrada Liberada!");
        }
        else
        {
            Console.WriteLine("Entrada não Liberada!");
        }


        //Operador And /////////////////////////////////////////////////////////////////
        bool possuiPresencaMinima = true;
        double media = 7.5;

        if (possuiPresencaMinima && media >= 7)
        {
            Console.WriteLine("Aprovado!");
        }
        else
        {
            Console.WriteLine("Reprovado!");
        }

        //Operador NOT ! /////////////////////////////////////////////////////////////////
        bool choveu = true;
        bool estaTarde = false;

        if (!choveu && !estaTarde)
        {
            Console.WriteLine("Vou pedalar!");
        }
        else
        {
            Console.WriteLine("Vou pedalar um outro dia!");
        }

        //Instanciando a classe calculadora
        Calculadora calc = new Calculadora();
        calc.Somar(10, 40);
        calc.Subtrair(8, 4);
        calc.Multiplicar(15, 5);
        calc.Dividir(100, 10);
        calc.Potencia(3, 3);
        calc.Seno(30);
        calc.Coseno(30);
        calc.Tangente(30);

        // FOR
        int numero = 5;
        for (int contador = 0; contador <= 10; contador++)
            Console.WriteLine($"{numero} x {contador} = {numero * contador}");


        // While
        int num = 5;
        int cont = 10;

        while (cont <= 10)
        {
            Console.WriteLine($"{cont + 1} Execução: {num} x {cont} = {num * cont}");

            break;
        }

        // do While
        int soma = 0, nuu = 0;
        do
        {
            Console.WriteLine("Digite um número (0 para parar): ");
            nuu = Convert.ToInt32(Console.ReadLine());

            soma += nuu;

        } while (nuu != 0);
        Console.WriteLine($"Total da soma dos números digitados é: {soma}");


        // Construindo menu interativo 
        string opcao;
        bool exibirMenu = true;

        while (exibirMenu)
        {
            Console.Clear();
            Console.WriteLine("Digite sua opção");
            Console.WriteLine("1 - Cadastrar cliente");
            Console.WriteLine("2 - Buscar cliente");
            Console.WriteLine("3 - Apagar cliente");
            Console.WriteLine("4 - Encerrar");

            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Cadastro de cliente");
                    break;

                case "2":
                    Console.WriteLine("Busca de cliente");
                    break;

                case "3":
                    Console.WriteLine("Apagar cliente");
                    break;

                case "4":
                    Console.WriteLine("Encerrar");
                    exibirMenu = false;
                    // Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.WriteLine("O programa se encerrou");
        }

    }
}

