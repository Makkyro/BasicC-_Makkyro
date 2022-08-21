/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int [,] a= new int[,]  
{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4},
};

PrintArray(SortDescending(a));

int [,] SortDescending (int[,] a) 
{
    for(int i=0;i<a.GetLength(0); i++) 
    {
        for(int j=0; j<a.GetLength(1)-1; j++) 
        { 
            int max=0;  
            int jMax=0; 
            for(int k=j; k<a.GetLength(1); k++) 
            {
                if (a[i,k]>max)   
                {
                    max=a[i,k]; 
                    jMax=k;     
                }        
            }    
            if (jMax!=j)
            {
                int temp=a[i,j];
                a[i,j]=a[i,jMax]; 
                a[i,jMax]=temp; 
            }
        } 
    }
    return a;
}


void PrintArray (int[,] a) 
{
    for(int i=0;i<a.GetLength(0); i++) 
    {
        for(int j=0; j<a.GetLength(1); j++)
        { 
            System.Console.Write($"{a[i,j]} ");
        }
    System.Console.WriteLine();
    }
} 