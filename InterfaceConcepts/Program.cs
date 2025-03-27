using InterfaceConcepts;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the Shape 1.Circle 2.Default");

        int ch = int.Parse(Console.ReadLine());
        IShape cir = new Circle();

        switch (ch)
        {
            case 1:
              
                cir.Area();
                break;
            default:
               
                cir.Square(4);
                break;

        }
    }
}