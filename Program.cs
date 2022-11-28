// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

using static System.Console ;
Clear() ;

Write(" Введите число N ") ;
int n=Convert.ToInt16(ReadLine()) ;
int summ = 0;
Write(" -> ") ;
for( int i=1; i<=n; i++)
{
    summ=Convert.ToInt32(Math.Pow(i, 3));
    Write($"  {summ} ") ;
    summ=0 ;
}
WriteLine();
