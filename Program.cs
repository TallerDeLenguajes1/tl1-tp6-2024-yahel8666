// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b); */

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