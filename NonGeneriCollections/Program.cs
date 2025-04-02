// See https://aka.ms/new-console-template for more information
using System.Collections;
Console.WriteLine("Hello, World!");

ArrayList arrlst = new ArrayList();
arrlst.Add(111);
arrlst.Add("Cognizant");

foreach(object o in arrlst)
{
    Console.WriteLine(o);
}
Console.WriteLine(arrlst.Count);
Console.WriteLine(arrlst.Capacity);


string[] course = { "DotNet", "SQLServer", "React" };

arrlst.AddRange(course);
Console.WriteLine();
foreach (object o in arrlst)
{
    Console.WriteLine(o);
}
Console.WriteLine(arrlst.Count);
Console.WriteLine(arrlst.Capacity);

arrlst.Insert(1, "Priya");
Console.WriteLine();
foreach (object o in arrlst)
{
    Console.WriteLine(o);
}
Console.WriteLine(arrlst.Count);
Console.WriteLine(arrlst.Capacity);

arrlst.InsertRange(0, course);
Console.WriteLine();
foreach (object o in arrlst)
{
    Console.WriteLine(o);
}
Console.WriteLine(arrlst.Count);
Console.WriteLine(arrlst.Capacity);


arrlst.Remove("DotNet");
Console.WriteLine();
foreach (object o in arrlst)
{
    Console.WriteLine(o);
}
arrlst.RemoveAt(4);
Console.WriteLine();
foreach (object o in arrlst)
{
    Console.WriteLine(o);
}
arrlst.RemoveRange(2, 2);
Console.WriteLine();
foreach (object o in arrlst)
{
    Console.WriteLine(o);
}

Console.WriteLine(arrlst.Contains("SQLServer"));

arrlst[1] = "Update";
foreach (object i in arrlst)
{
    Console.WriteLine(i);
}

ArrayList intarr = new ArrayList();
intarr.Add(111);
intarr.Add(112);//Boxing - value type(int) converted to ref type(object)

foreach (int item in intarr)
{
    Console.WriteLine(item);//Unboxing 
}

//Non Generic - slow performance compared to generics because of automatic boxing and unboxing


