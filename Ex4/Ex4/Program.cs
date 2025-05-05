bool textoValido = false;

do
{
    Console.WriteLine("Por favor, digite uma palavra ou frase:");

    string texto = Console.ReadLine();
    string textoExibir;

    if (texto != "")
    {
        textoValido = true;
        textoExibir = $"Número de caracteres é: {texto.Replace(" ", "").Length}";
    } else
    {
        textoExibir = "Falha ao analisar esse texto.";
    }

        Console.WriteLine(textoExibir);

} while (textoValido == false);



