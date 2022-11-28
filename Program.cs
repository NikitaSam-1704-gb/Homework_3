// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

using static System.Console ;
Clear() ;

int [] FillArray(int count) 
{
    int[] arrya= new int[count] ;
    WriteLine($" Введите {count} - мерный массив ") ;
    for( int i =0; i<count; i++)
    {
      arrya[i]= Convert.ToInt32(ReadLine()); 
    }
    WriteLine();
    return arrya;
}

Write(" Введите количетво осей  координат ");
int dimensional = Convert.ToInt16(ReadLine()) ;
Write(" Координат точки 1 ");
int [] arrayCoordinates1=FillArray(dimensional);

Write("Координат точки 2 ");
int [] arrayCoordinates2=FillArray(dimensional);

double summ=0 ;
for ( int i=0; i < dimensional; i++)
{
    summ=summ+Math.Pow(arrayCoordinates1[i]-arrayCoordinates2[i], 2) ;
}
summ=Math.Sqrt(summ) ;
WriteLine($" расстояние между точками {summ}") ;