/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
суммой элементов: 1 строка
*/

int [,] a= new int[,]  
{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4},
{5, 2, 6, 7},
};

System.Console.WriteLine($"строка {NumberOfMinStringSum(a)}");
int NumberOfMinStringSum (int[,] a) 
{   
    int minSum=0; 
    int iMin=0;   
    for(int i=0;i<a.GetLength(0); i++) 
    {
        int sum=0; 
        for(int j=0; j<a.GetLength(1); j++) 
        { 
            sum+=a[i,j];    
        }
       
        if (i==0) 
        {
            minSum=sum;  
            iMin=i+1;    
        }

        else  
        {
            if (sum<minSum) 
            {
                minSum=sum; 
                iMin=i+1;   
            }   
        }       
    }   
return iMin;
}
