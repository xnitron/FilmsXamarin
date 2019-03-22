namespace FilmsXamarin.Utils
{
    public class StringUtils
    {
       public static string TrimString(string str, int length = 15)
        {
            if (str.Length > length)
            {
                return str.Substring(0, length) + " ...";
            }

            return str;
        }
    }
}
