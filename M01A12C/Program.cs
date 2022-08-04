









float sal = 0;
Console.Write("Qual é o seu salário? ");
float.TryParse(Console.ReadLine(), out sal);
Console.WriteLine($"Você ganha {sal:C} por mês!");
Console.ReadLine();
