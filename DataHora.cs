public class DataHora
{
    /*
     DateTime é um struct que representa um momento no tempo com data e hora
     propriedades: Year Month Day Hour ...
        DayofWeek DayofYear
     métodos: AddDays AddHours AddMonths AddYears
        ToLongDateString ... ToLongHourString
    */

    DateTime dataAtual = DateTime.Now;
    // aaaa,mm,dd,hh,mm,ss
    DateTime dataInstanciada = new(2025, 04, 27, 21, 10, 05);
}