// See https://aka.ms/new-console-template for more information



namespace QuarterCalculator
{
    public class QuarterCalculator
    {
        static void Main(string[] args)
        {

        }
    }
    public class QuarterCal
    {
        public string CalculateQuarter(int month)
        {
            // Evaluating the month
            if (month <= 0)
            {
                return "Tháng không hợp lệ!";
            }
            else if (month <= 3)
            {
                return "Quý 1";
            }
            else if (month <= 6)
            {
                return "Quý 2";
            }
            else if (month <= 9)
            {
                return "Quý 3";
            }
            else if (month <= 12)
            {
                return "Quý 4";
            }
            else
            {
                return "Tháng không hợp lệ!";
            }
        }
    }
}



