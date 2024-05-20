// See https://aka.ms/new-console-template for more information
/* 
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b); 

//invertir numero 
int n=0; 
int invertido=0; 
int ultimo; 
Console.ReadLine("Ingrese un numero: \n"); 
string s = Console.ReadLine(); 
if (int.TryParse(s, out n)) //si la conversión a entero es exitosa...  
{
    while (n!=0)
    {
        ultimo = n%10;
        invertido = invertido*10+ultimo; 
        n = n/10; 
    }
}
Console.WriteLine("El numero invertido es: "+invertido); 
*/

//calculadora V1 
Console.WriteLine("Elegir una opción"); 
Console.WriteLine("1) Sumar numeros"); 
Console.WriteLine("2) Restar numeros"); 
Console.WriteLine("3) Dividir"); 
Console.WriteLine("4) Multiplicar"); 
Console.WriteLine("5) Salir"); 
int opcion = int.Parse(Console.ReadLine()); // is this even valid???? HELPPPP

/*Pide al usuario dos numeros*/ 
string s1, s2; int num1=0, num2=0; 

Console.WriteLine("Ingresar el primer numero");
s1 = Console.ReadLine(); //guardo el valor en un string. 
while (!int.TryParse(s1, out num1))  //verifico si la conversión a entero fue exitosa.
{
    Console.Write("Entrada no válida. Ingrese un número entero válido: ");
    s1 = Console.ReadLine();
}

Console.WriteLine("Ingresar el segundo numero");
s2 = Console.ReadLine(); //guardo el valor en un string. 
while (!int.TryParse(s2, out num2))  //verifico si la conversión a entero fue exitosa.
{
    Console.Write("Entrada no válida. Ingrese un número entero válido: ");
    s2 = Console.ReadLine();
} 

do
{
    switch (opcion)
    {
        case 1: sumarNumeros(num1, num2); 
        break;
        case 2: restarNumeros(num1, num2);  
        break;
        case 3: dividirNumeros(num1, num2); 
        break;
        case 4: multiplicarNumeros(num1, num2);
        break;
    }    
} while (opcion!=5);

void sumarNumeros(int num1, int num2)
{
    Console.WriteLine("Resultado: "+(num1+num2)); 
}

void restarNumeros(int num1, int num2)
{
    Console.WriteLine("Desea restar: "); 
    Console.WriteLine($"1) {num1}-{num2}"); 
    Console.WriteLine($"2) {num2}-{num1}"); 
    int op = int.Parse(Console.ReadLine()); 
    if (op==1)
    {
        Console.WriteLine($"Restulado: {num1-num2}");
    } else
    {
        if(op==2)
        {
            Console.WriteLine($"Restulado: {num2-num1}");
        } else
        {
            Console.WriteLine("Opcion no valida"); 
        }
    } 
}

void dividirNumeros(int num1, num2)
{   
    Console.WriteLine("¿Cómo quiere dividir?");
    Console.WriteLine($"1) {num1} / {num2}");
    Console.WriteLine($"2) {num2} / {num1}");
    int op = int.Parse(Console.ReadLine()); 

    if (op==1)
    {
        if (num2!=0)
        {
            Console.WriteLine($"Resultado: {num1/num2}");
        } else
        {
            Console.WriteLine("Error");
        }
    } else
    {
        if (num1!=0)
        {
            Console.WriteLine($"Resultado: {num2/num1}");
        } else
        {
            Console.WriteLine("Error");
        }
    } else
    {
        Console.WriteLine("Opcion no valida");
    }
}

void multiplicarNumeros(int num1, num2)
{
    Console.WriteLine("Resultado: "+(num1*num2)); 
}