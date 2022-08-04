int ano = 0;

Console.Write("Em que ano você nasceu? ");

ano = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("------------------------------------------------");
Console.WriteLine($"Estamos atualmente no ano de {DateTime.Now.Year}.");
Console.WriteLine($"Se você nasceu em {ano}, vai ter {DateTime.Now.Year - ano} anos.");

Console.ReadKey();

