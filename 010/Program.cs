//Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 

int a;
string? s=Console.ReadLine(); //ввод данных
a=Convert.ToInt32(s);

int b=a/10;
int c=a%10;
//System.Console.WriteLine(b);
System.Console.WriteLine(c);
