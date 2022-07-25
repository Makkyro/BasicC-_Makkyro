//Дано число больше 9. Вывести на экран  вторую цифру числа с конца.

int a;
string? s=Console.ReadLine(); 
a=Convert.ToInt32(s);
int b=a/10;
int c=a/10%10;
//System.Console.WriteLine(b);
System.Console.WriteLine(c);