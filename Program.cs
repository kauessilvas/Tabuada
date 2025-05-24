Console.Clear();

Console.WriteLine("======== Tabuada ========");

int numero;

while (true)
{
    Console.Write("\nDigite um número inteiro: ");
    string entrada = Console.ReadLine()!;

    bool sucesso = int.TryParse(entrada, out numero);

    if (sucesso)
    {
        break;
    }
    else
    {
        Console.WriteLine("\nEntrada inválida! Por favor, digite apenas números inteiros.");
    }
}

string[] resultadoTabuada = calculaTabuada(numero);

foreach (string linha in resultadoTabuada)
{
    Console.WriteLine(linha);
}

static string[] calculaTabuada(int numero)
{
    string[] tabuada = new string[11];
    for (int i = 0; i <= 10; i++)
    {
        int resultado = numero * i;
        tabuada[i] = $"{numero} x {i} = {resultado}";
    }
    return tabuada;
}