// Задать N и вывести # до N елочкой 
//пример N = 3;     # 
//                 ###
//N = 5   # 
//       ###
//      #####
//N = 7      # 
//          ###
//         #####
//        #######

//Двумерный цикл 
//Если у нас не должно быть # , то пишем пробел

using static System.Console ;
Clear ();
 Write(" Введите нечетное число   ") ;
 int n=Convert.ToInt16(ReadLine());
 int leftBorder=n/2+1;
 int reghtBorder=n/2+1;

 for(int i=0; i<(n+1)/2; i++ )
 {
    for ( int j=0; j<=n; j++)
    {
        if(j>=leftBorder && j<=reghtBorder)
            Write("#");
        else Write(" ");    
    }
    WriteLine();
    leftBorder=leftBorder-1 ;
    reghtBorder=reghtBorder+1;
 }
