namespace Assignment2;


public class Delegates
{

    public delegate string StringDel(string str);

    public static string DeleReverseMethod(string str)
    {
        return new string(str.Replace(" ", "").ToCharArray().Reverse().ToArray());
    }

    public delegate Decimal DecimalDel(Decimal num1, Decimal num2);

    public static Decimal ProductCalc(Decimal num1, Decimal num2)
    {
        return Decimal.Multiply(num1, num2);
    }


    public delegate bool BoolDel(string str, int num);

    public static bool isStringSameAsNum(string str, int num)
    {
        return Int32.Parse(str).Equals(num);

    }

}