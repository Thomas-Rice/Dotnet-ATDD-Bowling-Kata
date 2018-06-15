namespace ATDD_BowlingAPP.Extensions
{
    public class CharToIntConverter
    {
        public static int Convert(char score)
        {
            return int.Parse(score.ToString());
        }
    }
}