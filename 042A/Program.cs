/*
//Даны две квадратных таблицы чисел. Требуется построить третью, каждый элемент которой равен сумме элементов, стоящих на том же месте в 1-й и 2-й таблицах.
Во входном файле записано сначала число N, затем записана первая таблица, а после нее - вторая. Элементы таблиц - числа от 0 до 100. 100>=N>=1.
*/
// Практиковался с генерацией файла с таблицами, чтением таблиц из этого файла и выводом решеения в новый файл. 

Random random = new Random();
int N=random.Next(1,101); 

CreateFile(N); 

Solve(); 

void Solve() 
{
    using (StreamReader sr = new StreamReader("Tables.txt"))  
    { 
        string s = "";
        s=sr.ReadLine(); 
        int N=int.Parse(s.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]);  
    
        s=sr.ReadLine(); 
        
        int[,] a=ReadTable(N); 
        
        s=sr.ReadLine(); 

        int[,] b=ReadTable(N); 

        using (StreamWriter sw = new StreamWriter("NewTable.txt")) 
        {
            for(int i=0; i<N; i++)   
                {
                    for(int j=0; j<N; j++) 
                    {
                        a[i,j]+=b[i,j]; 
                        sw.Write($"{a[i,j]}  "); 
                    }
                sw.Write($"\n"); 
                }
        }
    
        int[,] ReadTable(int N) 
            {  
                int[,] a=new int[N,N];
                string s = "";
                for (int i=0; i<N;i++) 
                {
                    s=sr.ReadLine();
                    string[] ss=s.Split(' ', StringSplitOptions.RemoveEmptyEntries); 
                    for(int j=0;j<ss.Length;j++)
                        {
                            a[i,j] = int.Parse(ss[j]); 
                        }
                }
            return a;
            }          
    }
}


void CreateFile(int N) //вспомогательный метод, создает файл Tables.txt с размерностью N в первой строке и двумя таблицами через пустую строку
{
    Random random = new Random();
    using (StreamWriter sw = new StreamWriter("Tables.txt")) //открывает текстового потока для записи в файл "Tables.txt"
    {
        sw.Write($"{N}\n");
        sw.Write($"\n"); // перенос на новую строку

        FillTable(); //запись первой таблицы в файл

        sw.Write($"\n"); // перенос на новую строку   

        FillTable(); //запись второй таблицы в файл

        //метод в методе :)   
        void FillTable() //метод заполнения таблицы 
            {
                for(int i=0; i<N; i++)   // цикл записи матрицы
                {
                    for(int j=0; j<N; j++) //цикл заполнения строки
                    {
                        sw.Write($"{random.Next(0,101)}  "); // записывает число
                    }
                sw.Write($"\n"); // перенос на новую строку
                }
            }
    }
    }