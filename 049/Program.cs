//создать массив m×n и заполнить, вывести массив

int N=3;
int M=2;

double[,] a=new double[N,M];

Random random=new Random(); 

for(int i=0;i<a.GetLength(0); i++) 
  {
     for(int j=0; j<a.GetLength(1); j++) 
    { 
    a[i,j]= random.NextDouble()*10+1; 
    }
  }

  
for(int i=0;i<a.GetLength(0); i++) 
  {
     for(int j=0; j<a.GetLength(1); j++)
        { 
        System.Console.Write($"{a[i,j]:F2} "); 
        }
 System.Console.WriteLine();
  }