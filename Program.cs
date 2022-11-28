//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21



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
/*void ArrayOutput(int [] arrya) 
{ 
    for( int i =0; i<arrya.Length; i++)
    {
      Write($"{arrya[i]}  "); 
    }
    WriteLine();
}*/

Write(" Введите количетво осей  координат ");
int dimensional = Convert.ToInt16(ReadLine()) ;
Write(" Координат точки 1 ");
int [] arrayCoordinates1=FillArray(dimensional);
//ArrayOutput(arrayCoordinates1);
Write("Координат точки 2 ");
int [] arrayCoordinates2=FillArray(dimensional);
//ArrayOutput(arrayCoordinates2);
double summ=0 ;
for ( int i=0; i < dimensional; i++)
{
    summ=summ+Math.Pow(arrayCoordinates1[i]-arrayCoordinates2[i], 2) ;
//    WriteLine( summ) ;
}
summ=Math.Sqrt(summ) ;
WriteLine($" расстояние между точками {summ}") ;

