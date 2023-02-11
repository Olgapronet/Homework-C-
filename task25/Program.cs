// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


System.Console.Write(" Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine( )) ;

System.Console.Write(" Получение степени B: ");
int B = Convert.ToInt32(Console.ReadLine( )) ;

int  myPow ( int  a , int  b )
{
    int  Pow  =  1 ;
    for ( int   i = 0 ; i < b ; i ++ ) Pow  *=  a ;
    return  Pow ;
}
System.Console.WriteLine(myPow ( A , B ));