// See https://aka.ms/new-console-template for more information
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



