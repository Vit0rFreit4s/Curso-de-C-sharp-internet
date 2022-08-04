
float num = 0f;

Console.Write("Digite um número Real: ");
num = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("-------------------------------");

Console.Write($"Você digitou o valor {num}\n");
Console.Write($"A parte inteira do número é {(int)num}\n");
Console.Write($"Arredondando, temos o número {Convert.ToInt16(num)} \n");

Console.ReadKey();