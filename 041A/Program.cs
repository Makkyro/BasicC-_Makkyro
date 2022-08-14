﻿//Дана квадратная матрица. Проверить, является ли она симметричной относительно главной диагонали.

Solve(Input());

int [,] Input()  
{
    string s=Console.ReadLine();
    int N=int.Parse(s.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]); 
    int[,] a=new int[N,N];   
    for (int i=0; i<N;i++) 
    {
        s=Console.ReadLine();
        string[] ss=s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for(int j=0;j<ss.Length;j++)
            {
                a[i,j] = int.Parse(ss[j]);
            }
    }
    return a;
}

void Solve (int[,] a) 
{
    bool flag=true;
    for(int i=0;i<a.GetLength(0); i++) 
    {
        for(int j=0; j<a.GetLength(1); j++)
        { 
            if (a[i,j]!=a[j,i]) 
            {
            flag = false;
            break; 
            }       
        } 
    if (flag) break;  
    }

    if (flag) System.Console.WriteLine("Матрица симметрична");
    else System.Console.WriteLine("Матрица не симметрична");
}

/* Даны матрицы: первое число: размерность матрицы следом идут строки матрицы 
(для проверки копировать в терминал)
4
1 2 3 4
2 1 5 6
3 5 1 7
4 6 7 1
5 
1 2 3 4 5
2 1 6 7 8
3 6 1 9 5
4 7 9 1 4
5 8 5 4 1
*/