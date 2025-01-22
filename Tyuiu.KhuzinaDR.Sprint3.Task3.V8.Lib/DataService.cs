using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhuzinaDR.Sprint3.Task3.V8.Lib
{
    public class DataService : ISprint3Task3V8
    {
        public int ConvertStringToInt(string value)
        {
            string res = "";
            foreach (char c in value)
            {
                if (Char.IsDigit(c))
                {
                    res += c;
                }
            }
            int number = Int32.Parse(res);
            return number;
        }
    }
}