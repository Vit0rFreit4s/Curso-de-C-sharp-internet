


/*
//Conversão Implícita int -> float
int a = 8;
float b = a;
*/
/*
//Conversão Explícita float -> int
float a = 8.9999f;
float b = (int)a;
*/
//Conversão por classes auxiliares
float a = 8.502f;
float b = Convert.ToInt16(a);

Console.WriteLine("O valor de a é " + a + " do tipo " + a.GetType());
Console.WriteLine("O valor de b é " + b + " do tipo " + b.GetType());

Console.ReadKey();
