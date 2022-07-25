//С клавиатуры вводится целое число. 
//Вывести третью цифру числа или сообщить, что её нет.

int a=Convert.ToInt32(Console.ReadLine());

int b=a/10;
int c=a/10/10%10;
//System.Console.WriteLine(b);


if (c!=0)
{
    System.Console.WriteLine(c);
}
else
{
    System.Console.WriteLine("Третьей цифры числа нет");
}