//В одномерном массиве из 123 чисел
//найти количество элементов из отрезка [10,99]

int N=123;
int[] a;
Init(out a,N,min:10,max:300);
Print(a,"A");

System.Console.WriteLine();
CountNumbers(a); 

void CountNumbers (int[] a) 
{
    int numb=0;
    for (int i=0;i<a.Length;i++)
        if (a[i]>=10 && a[i]<=99) numb++; 
    System.Console.WriteLine($"Количество чисел из диапазона [10,99] = {numb}");
} 


void Init(out int[] t, int Lenght,int min=0, int max=10)  
{
    t=new int[Lenght];
    Random random = new Random();
    for (int i=0;i<t.Length;i++)
    t[i]=random.Next (min, max+1);
}


void Print (int[] t, string variableName)  
{
    for (int i=0;i<t.Length;i++)
    System.Console.Write($"{variableName}[{i}]={t[i]} ");
}  