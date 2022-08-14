//Написать программу масштабирования фигуры

string s = "(0,0) (2,0) (2,2) (0,2)";
double k=0.5; 

System.Console.WriteLine("Решение с помощью строковых методов:");
SolveString(s,k);
System.Console.WriteLine("\nРешение с помощью массива чисел:");
SolveArray(s,k);

void SolveString(string s, double k)
{
    char[] ss=s.ToCharArray(); 
    string ns="";
    double n;
    bool f;

    

    for (int i=0; i<ss.Length; i++)
    { 
        f=double.TryParse(ss[i].ToString(),out n); 
        if (f!=false) 
        {
        n=n*k; 
        ns=ns+n.ToString(); 
        }
    }

    for (int i=0; i<ns.Length/2; i++) 
    {
        System.Console.Write($"({ns.Substring(i*2, 1)},{ns.Substring(i*2+1, 1)}) "); 
    }
}

void SolveArray(string s, double k)
{
    char[] ss=s.ToCharArray(); 
    double n;
    bool f;
    int N=0;

    for (int i=0; i<ss.Length; i++) 
    { 
        f=double.TryParse(ss[i].ToString(),out n); 
        if (f!=false) N++; 
    }
    
    double[] a=new double[N];
    int j=0;

    for (int i=0; i<ss.Length; i++)
    { 
        f=double.TryParse(ss[i].ToString(),out n); 
        if (f!=false) 
        {
        a[j]=n*k;               
        j++;
        }
    }
    
    for (int i=0; i<a.Length/2; i++) 
    {
    System.Console.Write($"({a[i*2]},{a[i*2+1]}) "); 
    }
}