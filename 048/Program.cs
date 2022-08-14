//Написать программу копирования массива

int[] a;
Init(out a, 12, -9,9); 
Print(a,"A");


int[] b;
CloneArray(a, out b);
System.Console.WriteLine(); 
Print(b,"B");

void CloneArray(int[] a, out int[] b ) 
{
    b=new int[a.Length];
    for(int i=0;i<a.Length; i++)
        b[i]=a[i];
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