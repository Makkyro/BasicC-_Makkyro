//Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

System.Console.WriteLine("Ведите число для X = ");
int X=Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Ведите число для Y = ");
int Y=Convert.ToInt32(Console.ReadLine());

if (X>0 & Y>0)
{
    System.Console.WriteLine("Точка принадлежит первой четверти");
}
if (X<0 & Y>0)
{
    System.Console.WriteLine("Точка принадлежит второй четверти");
}
if (X<0 & Y<0)
{
    System.Console.WriteLine("Точка принадлежит третьей четверти");
}
if (X>0 & Y<0)
{
    System.Console.WriteLine("Точка принадлежит четвертой четверти");
}
if (X==0 & Y==0)
{
    System.Console.WriteLine("Точка не принадлежит ни одной четверти");
}
