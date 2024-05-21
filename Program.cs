// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b); 

//invertir numero 
/*No sé que problema hay en esta rama
con los readLine, está caprichosa. 

int n=0; 
int invertido=0; 
int ultimo; 
Console.WriteLine("Ingrese un numero: "); 
string s = Console.ReadLine();  
if (int.TryParse(s, out n)) 
    while (n!=0)
    {
        ultimo = n%10;
        invertido = invertido*10+ultimo; 
        n = n/10; 
    }
}
Console.WriteLine("El numero invertido es: "+invertido); 
*/

//calculadoraV2 
double num;
/*
--no funciona si lo pongo así, no sé pq--
(pide el numero mientras no sea valido)
do
{
    Console.WriteLine("Ingrese un numero:");
} while (!double.TryParse(Console.ReadLine(), out num));
*/

Console.WriteLine("Ingrese un numero:");
if(double.TryParse(Console.ReadLine(), out num))
{
    Console.WriteLine("El valor absoluto es: ");
    Console.WriteLine(Math.Abs(num));
    
    Console.WriteLine("El cuadrado es: ");
    Console.WriteLine(Math.Pow(num,2));
    
    Console.WriteLine("La raiz cuadrada es: ");
    Console.WriteLine(Math.Sqrt(num));
    
    Console.WriteLine("El seno es: ");
    Console.WriteLine(Math.Sin(num));
    
    Console.WriteLine("La parte entera es: ");
    Console.WriteLine(Math.Floor(num));
}

//max y minimo. 
double num1, num2;

Console.WriteLine("Ingrese el primer número:");
string input1 = Console.ReadLine();
//num1 = double.Parse(input1);--consultar

Console.WriteLine("Ingrese el segundo número:");
string input2 = Console.ReadLine();
//num2 = double.Parse(input2);

if (double.TryParse(input1, out num1)  && double.TryParse(input1, out num2))
{
   double maximo = num1;
   double minimo = num2;

    if (num2 > num1)
    {
        maximo = num2;
        minimo = num1;
    }
    Console.WriteLine($"El número máximo es: {maximo}");
    Console.WriteLine($"El número mínimo es: {minimo}");
}
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
string s1, s2; int numero1=0, numero2=0; 

Console.WriteLine("Ingresar el primer numero");
s1 = Console.ReadLine(); //guardo el valor en un string. 
while (!int.TryParse(s1, out numero1))  //verifico si la conversión a entero fue exitosa.
{
    Console.Write("Entrada no válida. Ingrese un número entero válido: ");
    s1 = Console.ReadLine();
}

Console.WriteLine("Ingresar el segundo numero");
s2 = Console.ReadLine(); //guardo el valor en un string. 
while (!int.TryParse(s2, out numero2))  //verifico si la conversión a entero fue exitosa.
{
    Console.Write("Entrada no válida. Ingrese un número entero válido: ");
    s2 = Console.ReadLine();
} 

do
{
    switch (opcion)
    {
        case 1: sumarNumeros(numero1, numero2); 
        break;
        case 2: restarNumeros(numero1, numero2);  
        break;
        case 3: dividirNumeros(numero1, numero2); 
        break;
        case 4: multiplicarNumeros(numero1, numero2);
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

void dividirNumeros(int num1, int num2)
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

void multiplicarNumeros(int num1, int num2)
{
    Console.WriteLine("Resultado: "+(num1*num2)); 
}