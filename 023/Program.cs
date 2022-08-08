// Найти расстояние между точками в пространстве 2D

System.Console.WriteLine("Ведите число для X1 = ");
int x1=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ведите число для X2 = ");
int x2=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ведите число для Y1 = ");
int y1=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ведите число для Y2 = ");
int y2=Convert.ToInt32(Console.ReadLine());

int a=(x2 - x1);
int b=(y2 - y1);

if (x2>x1 & y2>y1)
{
    double a2=Math.Pow(a,2);
    double b2=Math.Pow(b,2);
    double c=Math.Sqrt(a2 + b2);
    System.Console.WriteLine(c);
}
else 
{
    System.Console.WriteLine("Неверные значение. Должно X2>X1 и Y2>Y1");
}
