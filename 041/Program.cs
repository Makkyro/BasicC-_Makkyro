//В указанном массиве вещественных чисел найдите разницу 
//между максимальным и минимальным элементом

int N=20;
double[] a;
Init(out a,N);
Print(a,"A");


System.Console.WriteLine();
FoundDeltaMinMax(a); 

void FoundDeltaMinMax (double[] a) 
{
    double minA=a[0];
    double maxA=a[0];
    for (int i=1;i<a.Length;i++)
        if (a[i]>maxA) maxA=a[i]; 
        else if (a[i]<minA) minA=a[i]; 
    double delta=maxA-minA;
    System.Console.WriteLine($"Разница между мин. и макс. значением = {delta}");
} 

void Init(out double [] t, int Lenght)  
{
    t=new double[Lenght];
    Random random = new Random();
    for (int i=0;i<t.Length;i++)
    t[i]=random.NextDouble ()*100;
}


void Print (double[] t, string variableName) 
{
    for (int i=0;i<t.Length;i++)
    System.Console.Write($"{variableName}[{i}]={t[i]} ");
} 