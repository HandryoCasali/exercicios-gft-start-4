using Exercicio01.Classes;

var p = new Pessoa();

Console.Write("Digite o nome: ");
p.Nome = Console.ReadLine();

bool dataValida;
do
{
    Console.Write($"Digite a data de nascimento Ex: DD/MM/AAAA: ");
    string dataNasc = Console.ReadLine();

    dataValida = p.ValidarDataNascimento(dataNasc);

    if (dataValida)
    {
        p.DataNasc = dataNasc;
    }
    else
    {
        Console.WriteLine($"Data digitada inválida, por favor digite uma data válida");
    }

} while (dataValida == false);

Console.Write("Digite a altura (Utilize vírgula em vez de ponto): ");
p.Altura = float.Parse(Console.ReadLine());

p.ImprimirDados();

Console.WriteLine("Tecle 'ENTER'para SAIR.");
Console.ReadLine();