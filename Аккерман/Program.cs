//Написать программу вычисления функции Аккермана

System.Console.Write("Введите число n: ");
            int n = System.Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Введите число m: ");
            int m = System.Convert.ToInt32(Console.ReadLine());
            A(n, m);
            
            static int A(int n, int m)
            {
                if (n == 0) return m + 1;
                if (n != 0 && m == 0) return A(n - 1, 1);
                if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
                return A(n,m);
                
            }
        
            System.Console.ReadKey();
