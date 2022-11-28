// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да 

using static System.Console ;
Clear() ;


Write(" Введите число без пробелов max 10 разрядов ") ;
int chislo =Convert.ToInt32(ReadLine()) ;

int ostatok = chislo ;
int digir=0 ;
while( ostatok != 0 )                       
{
    ostatok = ostatok/10 ; 
    digir++ ;                               // находим количество разрядов введенного числа
}
int count=0 ;
for( int i=1; i<=digir/2; i++)
{
    int  A=chislo/Convert.ToInt32(Math.Pow( 10, digir-i))%10 - chislo%Convert.ToInt32(Math.Pow( 10, i))/Convert.ToInt32(Math.Pow( 10, i-1));   // сравниваем числа в "зеркальных разрядах"
    if(A == 0)
        count++;          // Считаем количество совпадений
}   
 if (count==digir/2) 
 WriteLine ($" число {chislo} является полиндромом") ;
else WriteLine($" число {chislo} НЕ является полиндромом") ;
