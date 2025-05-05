float numero1;
float numero2;

numero1 = converterEntrada();
numero2 = converterEntrada(true);

static float converterEntrada(bool segundaChamada = false)
{
    float numero;
    bool conversao;

    do
    {
        if (segundaChamada)
        {
            Console.Write("Digite mais um número inteiro: ");
        }
        else
        {
            Console.Write("Digite um número inteiro: ");
        }
        string entrada = Console.ReadLine();
        conversao = float.TryParse(entrada, out numero);

        if (!conversao)
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
        }

    } while (!conversao);

    return numero;
}

Console.WriteLine($"Soma: {numero1 + numero2}");
Console.WriteLine($"Subtração: {numero1 - numero2}");
Console.WriteLine($"Multiplicação: {numero1 * numero2}");
if (numero2 == 0)
{
    Console.WriteLine("Divisão: Não é possível dividir um número por 0");
}
else
{
    float divisao = numero1 / numero2;
    Console.WriteLine($"Divisão: {divisao:F2}");
}
float media = (numero1 + numero2) / 2;
Console.WriteLine($"Média: {media:F2}");