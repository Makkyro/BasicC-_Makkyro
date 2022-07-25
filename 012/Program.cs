// С клавиатуры вводится целое число из  диапазона  [10, 99]. 
//Показать наибольшую цифру числа.

int a;
string? s=Console.ReadLine(); 
a=Convert.ToInt32(s);

int b=a/10;
int c=a%10;

if (b>c)
{
    System.Console.WriteLine(b);
}
else
{
    System.Console.WriteLine(c);
}

