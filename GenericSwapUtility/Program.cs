public class SwapUtility
{
    public static void Swap<T>(ref T lhs, ref T rhs)
    {
        T temp = lhs;
        lhs = rhs;
        rhs = temp;
    }
}

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine($"Before Swap: a = {a}, b = {b}");
        SwapUtility.Swap(ref a, ref b);
        Console.WriteLine($"After Swap: a = {a}, b = {b}");

        string str1 = "Hello";
        string str2 = "World";
        Console.WriteLine($"Before Swap: str1 = {str1}, str2 = {str2}");
        SwapUtility.Swap(ref str1, ref str2);
        Console.WriteLine($"After Swap: str1 = {str1}, str2 = {str2}");
    }
}
