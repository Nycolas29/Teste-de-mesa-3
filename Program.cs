Console.Write("Determine o valor presente:");
double ValorPresente = double.Parse(Console.ReadLine());

Console.Write("Determine a taxa de juros presente:");
double taxaJuros = double.Parse(Console.ReadLine());

Console.Write("Determine o periodo presente:");
int periodo= int.Parse(Console.ReadLine());

double valorFuturo = ValorPresente * (Math.Pow((taxaJuros/100) + 1, periodo));

Console.WriteLine("O rendimento total foi: " + Math.Round(valorFuturo, 2));