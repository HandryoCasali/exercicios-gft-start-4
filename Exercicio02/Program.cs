Console.WriteLine("Olá, em que turno voce trabalha? ");
Console.WriteLine(@"
Digite:
'M' para Matutino.
'V' para Vespertino.
'N' para Norturno.
");

string turno = Console.ReadLine().ToUpper();

switch(turno)
{
    case "M":
        Console.WriteLine($"Bom dia!");
        break;

    case "V":
        Console.WriteLine($"Boa tarde!");
        break;

    case "N":
        Console.WriteLine($"Boa noite!");
        break;

    default:
        Console.WriteLine($"Valor inválido");
        break;
}
