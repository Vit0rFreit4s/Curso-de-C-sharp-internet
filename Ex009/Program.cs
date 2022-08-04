
float preco1, preco2;
string prod1, prod2;

Console.Write("Produto 1: ");
prod1 = Console.ReadLine().Trim();
Console.Write("Preço 1: ");
float.TryParse(Console.ReadLine(), out preco1);

Console.Write("Produto 2: ");
prod2 = Console.ReadLine().Trim();
Console.Write("Preço 2: ");
float.TryParse(Console.ReadLine(), out preco2);


Console.SetCursorPosition(0, 10);
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine($"{" Produto", -20}{"Preço ", 13}");
Console.ResetColor();

Console.BackgroundColor = ConsoleColor.DarkGray;
Console.ForegroundColor = ConsoleColor.Black;

Console.WriteLine($"{prod1, -20}{preco1, 13:C}");
Console.WriteLine($"{prod2, -20}{preco2, 13:C}");



Console.ReadKey();


