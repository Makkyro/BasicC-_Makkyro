//Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел

int N=10;
int[] a;
Init(out a,N,min:100,max:1000);

Print(a,"A");
System.Console.WriteLine();
CountEven (a); 

void CountEven (int[] a) 
{
    int even=0;
    int notEven=0;
    for (int i=0;i<a.Length;i++)
        if (a[i]%2==0) even++;
        else notEven++;
    System.Console.WriteLine($"Количество четных чисел = {even}");
    System.Console.WriteLine($"Количество нечетных чисел = {notEven}");
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