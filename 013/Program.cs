//Удалить вторую цифру целого числа введенного с клавиатуры.

int n=Convert.ToInt32(Console.ReadLine());
int d0=n%10;
int d1=n/10%10;
int d2=n/100;
int n1=d2*10+d0;
//System.Console.WriteLine($"{d0}{d1}{d2}");
System.Console.WriteLine($"{n1}");