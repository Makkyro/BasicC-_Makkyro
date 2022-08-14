//Найти точку пересечения двух прямых заданных уравнением 

double b1=5;
double b2=5;
double k1=6;
double k2=3;


Solve(b1, b2, k1, k2);



void Solve (double b1,double b2, double k1, double k2) 
{
if (k1==k2) 
{
    if (k1==k2 && b1==b2) 
        System.Console.WriteLine($"Прямые совпадают");
    else 
        System.Console.WriteLine($"Прямые параллельны");
}
else
{ 
    double x=(b2-b1)/(k1-k2);  
    double y=k1*x+b1;
    System.Console.WriteLine($"Точка пересечения прямых:  x={x},  y={y}");
}
}