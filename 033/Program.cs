//Задать массив из 8 элементов, заполненных нулями и 
//единицами вывести их на экран

int[] t; 
Init(out t,8,max:1);   

Print(t,"t"); 

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