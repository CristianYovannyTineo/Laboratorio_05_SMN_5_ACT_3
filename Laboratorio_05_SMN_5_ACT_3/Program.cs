// See https://aka.ms/new-console-template for more information

//Crear un programa que permita ingresar n notas y hallar el promedio de estas.
double promedio;
double Resultado = 0;
Console.Write("Ingrese el numero de notas: ");
if (!int.TryParse(Console.ReadLine(), out int n)
    || n <= 0);

for (int i = 1; i <= n; i++)
{
    Console.Write($"Ingrese la nota {i}: ");
    if (!int.TryParse(Console.ReadLine(), out int notas) || notas < 0 || notas > 20)
    return; Resultado += notas;
}
 promedio = Resultado / n;
Console.WriteLine($"El promedio es {promedio}" );