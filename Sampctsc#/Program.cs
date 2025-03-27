using OOPSConceptscts;

namespace SampctsC_
{
     internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");
            int num = 10;
            Console.WriteLine(num);
            Console.WriteLine("Enter the name:");
            string? name = Console.ReadLine();
            Console.WriteLine("Name is"+name);
            Console.WriteLine("Enter the age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name:{0} \n Age:{1}",name,age);
            Console.WriteLine($"Name:{name} \n Age:{age}");
            //Samp.AgeElgibility(age);
            Samp sam = new Samp();//instance creation
            sam.AgeElgibility(age);
               Samp.Display();

            Employee em = new OOPSConceptscts.Employee();
           
        }
       
    }
}