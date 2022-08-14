//Написать программу преобразования десятичного числа в двоичное

int n=3; 

System.Console.WriteLine(DecToBin (n));

string DecToBin(int n) 
{
    if (n==0) return"0";
    string s="";
    while (n!=0)
    {
        s=(n%2)+s; 
        n/=2; 
    }
return s;
}