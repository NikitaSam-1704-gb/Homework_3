// У нас есть кеш - N $ , мы хотим сохранить его от инфляции, кладем в банк и получаем раз в год M % , 
//через сколько лет у нас получится купить квартиру за K $ , при том , 
//что цена квартиры также растет на Q % если этот процент больше или равен N , то вывести в консоль безысходность 

using static System.Console ;
Clear() ;

Write(" Введите сумму которую вы хотите положить под процент ");
double moneyInterest=Convert.ToDouble(ReadLine());

Write(" Введите процентр роста стоимости вашего вклада  ");
int Interest=Convert.ToInt16(ReadLine());

Write(" Введите стоимость квартиры  ");
double сostApartment=Convert.ToDouble(ReadLine());

Write(" Введите рост стоимости квартиры в год, в процентах  ");
int apartmentInterest=Convert.ToInt16(ReadLine());
int year=0 ;
if(apartmentInterest<Interest)
{
    while (moneyInterest<=сostApartment)
    {
        moneyInterest=moneyInterest+(moneyInterest*Interest/100);
        сostApartment=сostApartment+(сostApartment*apartmentInterest/100);
        year=year+1 ;
    }
    WriteLine($" что накопить необходимую сумму вам понадобиться {year} лет ") ;
}  
else WriteLine(" Приданном  роста стоимости вклада и стоимости объекта недвижимости. Покупка невозможна ");
