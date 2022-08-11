//Найти сумму чисел одномерного массива стоящих на нечетной позиции

int N=12;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(-9,10);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");

int s=0;
for(int i=1; i<a.Length; i=i+2)
    s=s+a[i];

System.Console.WriteLine(s);
