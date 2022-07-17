// See https://aka.ms/new-console-template for more information
//комментарий
/* Console.WriteLine("Hello, World!");
Console.WriteLine(11%3);
System.Console.WriteLine(int.MaxValue);
*/

//С клавиатуры вводяться целое число. Вывести квадрат числа
double a;
double b;
string? s=Console.ReadLine(); //ввод данных
a=Convert.ToDouble(s);
b=a*a; //обрабртка данных
//вывод результата
System.Console.WriteLine("{0}^2={1}",a,b); //строка форматирования
System.Console.WriteLine($"{a}^2={b}"); //строка интерполяции

/*string? s; //объявили
s=Console.ReadLine(); //присвоили

System.Console.WriteLine(s);
*/
