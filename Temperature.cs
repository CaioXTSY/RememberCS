while (true)
{
    Console.WriteLine("[1]Celcius para Farenheight");
    Console.WriteLine("[2]Farenheight para Celcius");
    Console.WriteLine("[3]Celcius para Kelvin");
    Console.WriteLine("[4]Kelvin para Celcius");
    Console.WriteLine("[5]Farenheight para Kelvin");
    Console.WriteLine("[6]Kelvin para Farenheight");
    Console.WriteLine("[7]Sair");
    int n1 = int.Parse(Console.ReadLine());
    if (n1 == 7)
    {
        break;
    }
    Console.WriteLine("Digite o valor a ser convertido:");
    double n2 = double.Parse(Console.ReadLine());
    if (n1 == 1)
    {
        Console.WriteLine($"{n2}°C é igual a {n2 * 1.8 + 32}°F");
    }
    else if (n1 == 2)
    {
        Console.WriteLine($"{n2}°F é igual a {(n2 - 32) / 1.8}°C");
    }
    else if (n1 == 3)
    {
        Console.WriteLine($"{n2}°C é igual a {n2 + 273.15}K");
    }
    else if (n1 == 4)
    {
        Console.WriteLine($"{n2}K é igual a {n2 - 273.15}°C");
    }
    else if (n1 == 5)
    {
        Console.WriteLine($"{n2}°F é igual a {(n2 - 32) / 1.8 + 273.15}K");
    }
    else if (n1 == 6)
    {
        Console.WriteLine($"{n2}K é igual a {(n2 - 273.15) * 1.8 + 32}°F");
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
}
