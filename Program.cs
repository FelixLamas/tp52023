// See https://aka.ms/new-console-template for more information
<<<<<<< HEAD
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
=======
char respuesta ='s';
int resultado;

do
{
    int operacion, num1, num2;
    do
    {
        Console.WriteLine("Seleccione una operacion a realizar: 1-sumar, 2-restar, 3-multiplicar, 4-dividir:");
        operacion = Convert.ToInt32(Console.ReadLine());
    } while (operacion!= 1 && operacion!= 2 && operacion!= 3 && operacion!= 4 );

    Console.WriteLine("Ingrese el primer numero para realizar la operacion: " );
    num1= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero para realizar la operacion: " );
    num2= Convert.ToInt32(Console.ReadLine());
    switch (operacion)
    {
        case 1 : 
            resultado = num1 + num2;
            Console.WriteLine("El resultado de la operacion solicitada es: " + resultado);
            break;
        case 2 : 
            resultado = num1 - num2;
            Console.WriteLine("El resultado de la operacion solicitada es: " + resultado);
            break;
        case 3 : 
            resultado = num1 * num2;
            Console.WriteLine("El resultado de la operacion solicitada es: " + resultado);
            break;
        case 4 : 
            while (num2==0)
            {
                Console.WriteLine("El segundo numero debe ser distinto de cero:");
                num2= Convert.ToInt32(Console.ReadLine());
            }
            resultado = num1 / num2;
            Console.WriteLine("El resultado de la operacion solicitada es: " + resultado);
            break;
    };
    
    Console.WriteLine("Desea realizar otra operacion? s(SI)/ n(NO):");
    respuesta = Convert.ToChar(Console.ReadLine());
} while (respuesta=='s');
Console.ReadLine();
>>>>>>> Calculadora1
