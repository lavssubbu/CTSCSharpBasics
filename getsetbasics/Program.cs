
namespace getsetsamp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student student = new Student();
            student.Stid = 11;
            student.Name = "Anu";
            student.Age = 28;
            Console.WriteLine(student.Stid);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);

        }
    }
}