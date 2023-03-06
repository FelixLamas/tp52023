// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un numero");
double num = Convert.ToDouble(Console.ReadLine());
double valorA, cuadrado, raizCuadrada, seno, coseno, parteEntera;

valorA = Math.Abs(num);
cuadrado = Math.Pow(num, (double)2);
raizCuadrada = Math.Sqrt(num);
seno = Math.Sin(num);
coseno = Math.Cos(num);
parteEntera = Math.Truncate(num);

Console.WriteLine("El numero ingresado es: " + num );
Console.WriteLine("El valor absoluto del numero es " + valorA);
Console.WriteLine("El cuadrado del numero es: " + cuadrado );
Console.WriteLine("La raiz cuadrada del numero es: " + raizCuadrada );
Console.WriteLine("El seno del numero es: " + seno );
Console.WriteLine("El coseno del numero es: " + coseno );
Console.WriteLine("la parte entera del numero es: " + num );
Console.ReadLine();

Console.WriteLine("Ingrese dos numeros:");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());

double minimo = Math.Min(a, b);
double maximo = Math.Max(a, b);

Console.WriteLine("El minimo de los numeros ingresados es: " + minimo);

Console.WriteLine("El maximo de los numeros ingresados es: " + maximo);
Console.ReadLine();