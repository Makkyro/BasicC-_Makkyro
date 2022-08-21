//В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j]) записать в подпрограммы

int[,] a;
a=InitArray(2,3);

for(int i=0;i<a.GetLength(0); i++) 
  {
     for(int j=0; j<a.GetLength(1); j++)
        { 
        System.Console.Write($"{a[i,j]} ");
        }
 System.Console.WriteLine();
  }

for(int i=0;i<a.GetLength(0); i++) 
  {
     for(int j=0; j<a.GetLength(1); j++)
        { 
         if(a[i,j]%2==0)
         a[i,j]=-a[i,j];   
        }
  }

for(int i=0;i<a.GetLength(0); i++) 
  {
     for(int j=0; j<a.GetLength(1); j++)
        { 
        System.Console.Write($"{a[i,j]} ");
        }
 System.Console.WriteLine();
  }

int[,] InitArray(int N, int M)
{
a=new int[N,M];
Random random=new Random(); 
for(int i=0;i<a.GetLength(0); i++) 
  {
     for(int j=0; j<a.GetLength(1); j++) 
    { 
    a[i,j]= random.Next(1,11); 
    }
  }
return a;
}