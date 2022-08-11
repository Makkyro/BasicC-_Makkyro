//Написать программу замены элементов массива на противоположные

int N=13;
int[] a;
Init(out a,N,0,15);

Print(a);
Reverse(a);
System.Console.WriteLine();
Print(a);

void Init(out int[] t, int Lenght,int min=0, int max=10)  

{
    t=new int[Lenght];
    Random random = new Random();
    for (int i=0;i<t.Length;i++)
        t[i]=random.Next (min, max+1);
}

void Print (int[] t) 
{
    for (int i=0;i<t.Length;i++)
        System.Console.Write($"{t[i]} "); 
}

void Reverse(int[] a) 
{
    int temp;
    for (int i=0;i<=a.Length/2;i++)
    {  
        temp = a[i];
        a[i]=a[a.Length-i-1];
        a[a.Length-i-1] = temp;
    }
}