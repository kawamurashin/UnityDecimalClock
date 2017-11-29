public class Utilities  {

    public static string PlusZero(int value)
    {
        string str = (value + 100).ToString();
        str = str.Substring(str.Length-2, 2);
        return str;
    }
    public static string PlusZeroZero(int value)
    {
        string str = (value + 100).ToString();
        str = str.Substring(str.Length-3, 3);
        return str;
    }
}
