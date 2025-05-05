
bool placaValida = false;
string placaLimpa;

do
{
    Console.WriteLine("Digite a placa do veículo:");

    string placa = Console.ReadLine();
    placaLimpa = placa.Replace(" ", "");

    bool tamanhoCerto = placaLimpa.Length == 7;
    bool letrasIniciais = placaLimpa.Length >= 3 && placaLimpa.Substring(0, 3).All(char.IsLetter);
    bool numerosFinais = placaLimpa.Length == 7 && placaLimpa.Substring(3, 4).All(char.IsDigit);

    if (!tamanhoCerto)
    {
        Console.WriteLine("A placa precisa ter 7 caracteres alfanuméricos.");
    } else

    if (!letrasIniciais)
    {
        Console.WriteLine("A placa precisa iniciar com 3 letras.");
    } else

    if (!numerosFinais)
    {
        Console.WriteLine("A placa precisa finalizar com 4 números.");
    } else
    {
        placaValida = true;
    }
}
while (!placaValida);

Console.WriteLine($"Placa {placaLimpa.ToUpper()} válida!");