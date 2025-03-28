internal class Program
{
    public static void show(out int val)
    {
        int n = 50;
        val = n*n;
        Console.WriteLine("Value inside the method:"+val);
    }
    public static double divide(int a,int b,out int remainder)
    {
        remainder = a%b;
        return a/b;
    }
    private static void Main(string[] args)
    {
        int num=20;
      //  Console.WriteLine("Value before calling the method"+num);
      //  show(num);//call by value - copy of num
      //show(ref num);//call by reference - passing value as reference of original value and therby affects the original value
        //show(out num);//call by out - works similar to reference,except the fact that its value need not to be initialized before calling
        Console.WriteLine("Value after calling the method:" + num);
        Console.WriteLine(divide(50,2,out num));
        Console.WriteLine("Remainder:" + num);

    }
}