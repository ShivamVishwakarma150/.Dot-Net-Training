namespace LeapYearCalculatorLib.Test
{
    public class LeapYear
    {
        public int IsLeap(int year)
        {
            
            if(year >= 9999 || year <= 1753)
            {
                return -1;
            }
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                return 1;
            else
                return 0;
        }
    }
}