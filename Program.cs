﻿//Вяся и петя купили арбуз. Весы показали w килограмм.Ребята начали делить приобретенную ягоду. 
//Петя и Вася хотят поделить арбуз так, чтобы доля каждого весила именно четное число килограмм, при этом не обязательно, чтобы доли были равными по величине.
// Разумеется, каждому должен достаться кусок положительного веса. Сколько таких вариаций может быть(вывести каждую вариацию на экран)
//Входные данные
//вес купленного ребятами арбуза w=10 кг арбуз
//ВЫВОД
//2 8
//4,6
//6,4
//8,2




using static System.Console ;
Clear() ;

Write(" Введите массу арбуза ");
int massaWatermelon = Convert.ToInt16(ReadLine()) ;
if (massaWatermelon%2==0)
{
    WriteLine(" Арбуз можно разделить на две части массо ") ;
    for ( int i=1; i<massaWatermelon; i++)
    {
        if(i%2==0)
            WriteLine($" {i}  {massaWatermelon-i} ") ; 
    }
}
else WriteLine(" Масса арбуза должна быть четным числом ") ;


