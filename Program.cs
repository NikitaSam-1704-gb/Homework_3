﻿// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

using static System.Console ;
Clear() ;
Write(" Ввудите координату  не равную нулю X ");
int x=Convert.ToInt16(ReadLine()) ;
Write(" Ввудите координату не равную нулю Y ");
int y=Convert.ToInt16(ReadLine()) ;
if(x==0 || y==0)
   WriteLine(" координаты точки не должны равняться нулю ") ; 

if( x>0 && y>0 )
    WriteLine(" точка в первой четверте ") ;
if(x<0 && y>0 )
    WriteLine(" точка во второй четверте ") ;
if(x<0 && y<0)
    WriteLine(" точка в третей четверте ") ;
if(x>0 && y<0)
    WriteLine(" точка в четвертой четверте ") ;