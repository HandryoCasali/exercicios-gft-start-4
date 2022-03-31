Console.Write(
@"Digite qual suco foi vendido:
L - limao
T - tamarino.
");

string opcao = Console.ReadLine().ToUpper();

int litros;
float valorLitro;
float valorTotal;
float valorDesconto;
float desconto;
switch (opcao)
{
    case "L":
        Console.WriteLine("Quantos litros de suco foram vendidos?");
        litros = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual o valor do litro desse suco? ");
        valorLitro = float.Parse(Console.ReadLine());

        if (litros <= 2)
        {
            // terá 3%
            desconto = 0.03f;
            valorTotal = (valorLitro * litros);
            valorDesconto = valorTotal - (valorTotal * desconto);
            Console.WriteLine($"Valor a ser pago: {valorDesconto}");

        }
        else if (litros > 5)
        {
            // terá 5%
            desconto = 0.05f;
            valorTotal = (valorLitro * litros);
            valorDesconto = valorTotal - (valorTotal * desconto);
            Console.WriteLine($"Valor a ser pago: {valorDesconto}");

        }
        break;

    case "T":
        Console.WriteLine("Quantos litros de suco foram vendidos?");
        litros = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual o valor do litro desse suco? ");
        valorLitro = float.Parse(Console.ReadLine());

        if (litros <= 2)
        {
            // terá 4%
            desconto = 0.04f;
            valorTotal = (valorLitro * litros);
            valorDesconto = valorTotal - (valorTotal * desconto);
            Console.WriteLine($"Valor a ser pago: {valorDesconto}");

        }
        else if (litros > 5)
        {
            // terá 6%
            desconto = 0.06f;
            valorTotal = (valorLitro * litros);
            valorDesconto = valorTotal - (valorTotal * desconto);
            Console.WriteLine($"Valor a ser pago: {valorDesconto}");

        }
        break;

    default:
        break;
}

