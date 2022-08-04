
int inicio = 0, fim =0, aleatorio = 0;



Console.WriteLine("SORTEADOR DE NÚMERO");
Console.WriteLine("--------------------");

Console.Write("Início: ");
int.TryParse(Console.ReadLine(), out inicio);
Console.Write("Fim: ");
int.TryParse(Console.ReadLine(), out fim);
Console.WriteLine("--------------------");

Console.SetCursorPosition(0, 5);
Console.WriteLine("Sorteando...");
Thread.Sleep(2000);

Random Random = new Random();
aleatorio = Random.Next(inicio, fim+1);

Console.SetCursorPosition(0, 5);
Console.WriteLine($"Entre {inicio} e {fim} sorteei o valor {aleatorio}");

Console.ReadKey();



