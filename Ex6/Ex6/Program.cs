using System.Globalization;

bool opcaoValida = false;
DateTime dataAtual = DateTime.Today;

do
{
    Console.WriteLine("Olá, escolha o formato para visualizar a data de hoje:\n" +
    "1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos) \n" +
    "2 - Data no formato dd/mm/aaaa\n" +
    "3 - Hora no formato 24h\n" +
    "4 - Data no formato 'dia de mês' (por extenso)");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine(DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss", new CultureInfo("pt-BR")));
            opcaoValida = true;
            break;
        case "2":
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yy"));
            opcaoValida = true;
            break;
        case "3":
            Console.WriteLine(DateTime.Now.ToString("HH" + "h"));
            opcaoValida = true;
            break;
        case "4":
            Console.WriteLine(DateTime.Now.ToString("dd 'de' MMMM", new CultureInfo("pt-BR")));
            opcaoValida = true;
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}
while (!opcaoValida);

