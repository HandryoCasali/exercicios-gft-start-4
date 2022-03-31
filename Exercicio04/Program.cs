Console.WriteLine("Digite a idade da pessoa: ");
int idade = int.Parse(Console.ReadLine());

if ( idade >= 18 && idade <= 67)
{
    Console.WriteLine("Essa pessoa pode doar sangue");
}
else
{
    Console.WriteLine("Essa pessoa não tem a idade necessária para doar sangue.");
    
}