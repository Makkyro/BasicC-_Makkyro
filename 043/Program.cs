//С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры


int N=0;
System.Console.WriteLine("Введите целое число больше 1");
do 
{
   N=InputInt();
   if (N<1) System.Console.WriteLine("Введите целое число больше 1");
}
while(N<1);

System.Console.WriteLine($"Введено {CountPositiveNumbers(FillArray(N))} чисел больше 0 "); 


int CountPositiveNumbers(int[] a) 
{
int quantPosNumb=0;
for (int i=0; i<a.Length; i++)
   {
      if (a[i]>0) quantPosNumb++;
   }
return quantPosNumb;
}


int InputInt() 
{
string s;
int N;
bool f;
do 
    {
        s=System.Console.ReadLine();
        f=int.TryParse(s,out N);  
        if (f==false) System.Console.WriteLine("Wrong input. Введите целое число");
    }
while(f==false);
return N;
}

int[] FillArray(int N) 
{
int[] a=new int [N];
int count=N;
System.Console.WriteLine("Введите целое число");
for (int i=0; i<a.Length; i++)
   { 
      a[i]=InputInt();
      if (count>1) System.Console.WriteLine($"Осталось ввести {count-1} чисел ");
      count--;
   }
   return a;
}  
