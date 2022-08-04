




string nome = "Vitor";
float sal = 550.7556f;
int idade = 22;
Console.WriteLine($"O {nome, -10} tem {idade, -5:D3} anos e ganha {sal, 10:c2} por mês.");

int num = 13;
Console.WriteLine($"O número em hexadecimal foi {num:X}.");

float valor = 44679.003f;
Console.WriteLine($"O valor foi {valor:N2}.");

float val = 44679.003f;
Console.WriteLine($"O valor em notação científica foi {val:E}.");

Console.ReadKey();