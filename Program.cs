using Ejerciciosemana2.Negocio;
using Ejerciciosemana2.Entidades;


Console.WriteLine("Digite el primer numero");

int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite el segundo numero");

int num2 = int.Parse(Console.ReadLine());

Numeros num = new Numeros(num1, num2);

Logica logica = new Logica(); 

Console.WriteLine(logica.NMayorOIgual(num));