//С клавиатуры вводятся три числа. Найти максимальное из трех чисел

int a=3;
int b=6;
int c=9;

if (a>b&a>c)
{
    System.Console.WriteLine("Максимальное число "+a);
}
else 
{
    if(b>a&b>c)
    {
         System.Console.WriteLine("Максимальное число "+b);
    }
    else
    System.Console.WriteLine("Максимальное число "+c);
}