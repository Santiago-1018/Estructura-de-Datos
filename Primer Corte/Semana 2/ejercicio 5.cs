using System;

public class DateWithoutTime 
{
    public static void Main()
    {
        var dateAndTime = DateTime.Now;
        var Date = dateAndTime.ToLongDateString();

        DateTime diaActual = DateTime.Today;
            DateTime diaAnterior = DateTime.Today.AddDays(-1).DayOfWeek == DayOfWeek.Sunday ? DateTime.Today.AddDays(-2) : DateTime.Today.AddDays(-1);

             MessageBox.Show(string.Format("Día actual {0} Día anterior {1}", diaActual.ToShortDateString(), diaAnterior.ToShortDateString()));
        
        Console.WriteLine("The Current Date Without Time is {0}.", Date);
   
           
        public bool GetAge(DateTime Datebirth, out int Years, out int Month, out int Days)
{
            if (Datebirth < DateTime.Now)
            {
         return false;
                }

        TimeSpan dateDiff = DateTime.Now - Datebirth;
            DateTime age = new DateTime(dateDiff.Ticks);

        Years = age.Year - 1;
        Month = age.Month - 1;
        Days = age.Day - 1;
   
    return true;
       
        }
    }
}