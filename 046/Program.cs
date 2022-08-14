//С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1

System.Console.WriteLine("Введите целое число первых чисел ряда Фибоначи");
Fibonachi(InputInt());

void Fibonachi(int N) 
{
switch(N)
{
    case 0:
        System.Console.WriteLine($"F0=0  "); 
        break;
    case 1:
        System.Console.Write($"F0=0  F1=1  "); 
        break;
    default:
        double f0=0;
        double f1=1;
        System.Console.Write($"F0=0  F1=1  ");
        for(int i=2; i<=N; i++)
        {
            double f=f1+f0;
            System.Console.Write($"F{i}={f}  ");
            f0=f1;
            f1=f;
        }
        break;
}      
}

int InputInt() 
{
string s;
int n;
bool f;
do 
    {
        s=System.Console.ReadLine();
        f=int.TryParse(s,out n);  
        if (f==false) System.Console.WriteLine("Wrong input. Введите целое число");
    }
while(f==false);
return n;
}