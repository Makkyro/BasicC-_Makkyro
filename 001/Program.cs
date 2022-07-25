//С клавиатуры вводяться целое число. 
//Вывести квадрат числа
double a;
double b;
string? s=Console.ReadLine(); //ввод данных
a=Convert.ToDouble(s);
b=a*a; //обрабртка данных
//вывод результата
System.Console.WriteLine("{0}^2={1}",a,b); //строка форматирования
System.Console.WriteLine($"{a}^2={b}"); //строка интерполяции
