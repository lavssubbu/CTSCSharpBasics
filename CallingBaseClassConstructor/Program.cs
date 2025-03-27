namespace CallingBaseClassConstructor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Constructor will be called during object creation
            Category cat = new Category(111, "Laptop", "Electronics");
            cat.Print();
        }
    }
}
