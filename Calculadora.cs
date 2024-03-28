while (true)
{
    Console.WriteLine("[1]Somar");
    Console.WriteLine("[2]Subtrair");
    Console.WriteLine("[3]Multiplicar");
    Console.WriteLine("[4]Dividir");
    Console.WriteLine("[5]Sair");
    Console.WriteLine("Escolha uma opção: ");
    int opcao = int.Parse(Console.ReadLine());
    if (opcao == 5)
    {
        break;
    }
    Console.WriteLine("Digite o primeiro número: ");
    int n1 = int.Parse(Console.ReadLine());
    if (opcao != 5)
    {
        Console.WriteLine("Digite o segundo número: ");
        int n2 = int.Parse(Console.ReadLine());
        if (opcao == 1)
        {
            Console.WriteLine($"O resultado da soma é: {n1 + n2}");
        }
        else if (opcao == 2)
        {
            Console.WriteLine($"O resultado da subtração é: {n1 - n2}");
        }
        else if (opcao == 3)
        {
            Console.WriteLine($"O resultado da multiplicação é: {n1 * n2}");
        }
        else if (opcao == 4)
        {
            Console.WriteLine($"O resultado da divisão é: {n1 / n2}");
        }
    }   
}
