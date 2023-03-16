// See https://aka.ms/new-console-template for more information


int num1 = 0;
int num2 = 1;
int sum = 0;


Console.WriteLine("Digite um numero.");


int entry = Convert.ToInt32(Console.ReadLine());

Console.Write(num1 +" "+ num2 +" ");

while (sum != entry && sum <= entry)
{
    sum = num1 + num2;
    num1 = num2;
    num2 = sum;
    Console.Write(sum +" ");

}

if (sum == entry)
    {
        Console.WriteLine("\nO numero " + entry + " faz parte da sequência de Fibonacci");
        
    }else
    {
        Console.WriteLine("\nO numero " + entry + " não faz parte da sequência de Fibonacci");
        
    }


