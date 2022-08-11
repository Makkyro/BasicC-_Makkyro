//Показать кубы чисел, заканчивающихся на четную цифру

int N=20;
CubesOfEven(N);

void CubesOfEven(int N) 
{
    int a=0;
    for (int i=0;i<=N;i=i+2)
    {
        a=i*i*i;
        System.Console.WriteLine($"{i} в кубе = {a}");
    }
}