//Дано число обозначающее день недели. 
//Выяснить является номер дня недели выходным.

int a=Convert.ToInt32(Console.ReadLine());

if (a==1 || a==2 || a==3 || a==4 || a==5)
{
    System.Console.WriteLine("Рабочий день");
}
if (a==6 || a==7)
{
    System.Console.WriteLine("Выходной день");
}
else 
{
    System.Console.WriteLine("Нет такого числа дня недели");
}