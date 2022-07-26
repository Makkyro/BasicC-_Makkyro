//Дано число. 
//Проверить кратно ли оно 7 и 23

bool b,c;
int a=Convert.ToInt32(Console.ReadLine());
b=a%7==0;
c=a%23==0;
System.Console.WriteLine(b);
System.Console.WriteLine(c);