Console.Write("Digite seu nome completo: ");
string nomeCompleto = Console.ReadLine();

Console.Write("Digite seu peso: ");
double peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite sua altura em metros: ");
double altura  = Convert.ToDouble(Console.ReadLine());

double imc = peso / (altura * altura);

Console.WriteLine($"\nNome: {nomeCompleto}");
Console.WriteLine($"Peso: {peso} kg");
Console.WriteLine($"Altura: {altura} m");
Console.WriteLine($"IMC: {imc:F2}");