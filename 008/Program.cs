//Вывести на экран числа от -N до N

int N=50;
int i=-(50);
while(i<=N)
{
   if (i%2==0)
   {
    System.Console.Write($"{i} ");
   } 
    i=i+1;
}
