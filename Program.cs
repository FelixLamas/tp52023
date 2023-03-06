// See https://aka.ms/new-console-template for more information
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
