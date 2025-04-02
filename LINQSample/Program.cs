
//1. Obtain Data Source
using DoverC_day7;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;

int[] nums = [10, 20, 30, 25, 35, 46];

//2. LINQ - write the query for filteration
IEnumerable<int> res = from nu in nums
                       where (nu %2)==0
                       select nu;//Deferred Execution - Delayed execute ,Not Immediate

//3. Execute the query. In foreach loop,the execution happens
foreach (int num in res)
{
    Console.WriteLine(num);

}
//Immediate Execution
var resim = (from nu in nums
            where (nu % 2) == 0
            select nu).ToList();

var resimar = (from nu in nums
             where (nu % 2) == 0
             select nu).ToArray();

//Displaying the result
foreach (int num in resim)
{
    Console.WriteLine(num);
       
}

IList<string> lstnames = new List<string>()
{
    "Anu",
    "Gayathri",
    "Mano",
    "Karthi"
};
//Method Syntax
var result= lstnames.Where(n => n.Contains("Anu"));
foreach(string name in result)
{
    Console.WriteLine(name);
}


IList<Customer> customers = new List<Customer>()
{
    new Customer(){Custid=111,Custname="Priya",city="Chennai"},
    new Customer(){Custid=112,Custname="Neha",city="Kovai"},
    new Customer(){Custid=113,Custname="Megha",city="Bangalore"},
    new Customer(){Custid=114,Custname="Maha",city="Chennai"},
    new Customer(){Custid=115,Custname="Shreya",city="Chennai"},
    new Customer(){Custid=116,Custname="Sunil",city="Bangalore"}

};

//Method Syntax - extension method
var lstmthd = customers.Where(x => x.Custid>114);//Deferred
//var lstmthd = customers.Where(c => c.Custid > 113).ToList();//Immediate


foreach (var cu in lstmthd)
{
    Console.WriteLine(cu.Custid+" "+cu.Custname+" "+cu.city);
}
//Query Syntax0
var lstqry = from cust in customers
             where cust.city == "Bangalore"
             select cust;
foreach (var cus in lstqry)
{
    Console.WriteLine(cus.Custid + " " + cus.Custname + " " + cus.city);
}


//LINQ Join Query
//Inner Join - Intersection - Common Values
IList<Department> lstdpt = new List<Department>()
{
    new Department(){Deptid=111,DeptName="HR"},
     new Department(){Deptid=112,DeptName="Developer"}
     // new Department(){Deptid=113,DeptName="Testing"}
};
IList<Employee> employees = new List<Employee>()
{
    new Employee(){Empid=1001,EmpName="Shri",Dname="Developer"},
    new Employee(){Empid=1002,EmpName="Raghav",Dname="HR"},
    new Employee(){Empid=1003,EmpName="Madhav",Dname="Developer"},
    new Employee(){Empid=1004,EmpName="Susheel",Dname="Developer"},
    new Employee(){Empid=1005,EmpName="Shree",Dname="Testing"}

};

//Method Syntax 
                 //outer sequence
var resultjoin = employees.Join(lstdpt,//Inner Sequence

     emp => emp.Dname, //Outer sequence key selector
   dpt => dpt.DeptName,//inner sequence key selector
    (dpt, emp) => new //Projection Result
    {
        dname = dpt.Dname,
        empdname = emp.DeptName
    }
    );

foreach (var emp in resultjoin)
{
    Console.WriteLine(emp.dname);
}
//Query Syntax
var innrjoin = from e in employees
                join dt in lstdpt
                on e.Dname equals dt.DeptName
                select new
                {
                  empdname = e.Dname,
                  empid = e.Empid,
                  empname=e.EmpName,
                  dname = dt.DeptName
                };

foreach(var emp in innrjoin )
{
    Console.WriteLine(emp.empid+" "+emp.empname+" "+emp.dname);
}

var projects = new List<Project>
{
    new Project { ProjectId = 1, Title = "FinancialApp" },
    new Project { ProjectId = 2, Title = "HealthCare" },
    new Project { ProjectId = 3, Title = "Payroll" }
};

var assignments = new List<ProjectAssigned>
{
    new ProjectAssigned { EmployeeId = 1001, ProjectId = 1 },
    new ProjectAssigned { EmployeeId = 1001, ProjectId = 2 },
    new ProjectAssigned { EmployeeId = 1002, ProjectId = 2 },
    new ProjectAssigned { EmployeeId = 1002, ProjectId = 3 },
    new ProjectAssigned { EmployeeId = 1003, ProjectId = 1 }
};

// 1. Filter: Employees assigned to at least two projects
var employeesInMultipleProjects = employees
    .Where(employee => assignments.Count(a => a.EmployeeId == employee.Empid) >= 2)
    .Select(employee => employee.EmpName)
    .ToList();

Console.WriteLine("Employees assigned to at least two projects:");
foreach (var employee in employeesInMultipleProjects)
{
    Console.WriteLine(employee);
}

// 2. Group: Employees by their department
var employeesGroupedByDepartment = employees
    .GroupBy(employee => employee.Dname)
  //  .Select(employee => employee.EmpName)
     .ToList();

/* group => new
 {
     Department = lstdpt.FirstOrDefault(d => d.DeptName == group.Key)?.DeptName,
     Employees = group.Select(employee => employee.EmpName).ToList()
 })*/


Console.WriteLine("\nEmployees grouped by department:");
foreach (var group in employeesGroupedByDepartment)
{
    Console.WriteLine($"Department: {group.Key}");//Each group has a key
    foreach (var employee in group)//Each group has inner collection
    {
        Console.WriteLine($"  {employee.EmpName}");
    }
}

// 3. Join: Departments with employees working on more than one project
var departmentsWithMultipleProjectEmployees = lstdpt
    .Select(department => new
    {
        Department = department.DeptName,
        Employees = employees
            .Where(employee => employee.Dname == department.DeptName &&
                               assignments.Count(a => a.EmployeeId == employee.Empid) > 1)
            .Select(employee => employee.EmpName)
            .ToList()
    })
    .Where(d => d.Employees.Count > 0)
    .ToList();

Console.WriteLine("\nDepartments with employees working on more than one project:");
foreach (var dept in departmentsWithMultipleProjectEmployees)
{
    Console.WriteLine($"Department: {dept.Department}");
    foreach (var employee in dept.Employees)
    {
        Console.WriteLine($"  {employee}");
    }
}

// 4. Order: Employees sorted by the number of projects they are working on
var employeesSortedByProjects = employees
    .OrderByDescending(employee => assignments.Count(a => a.EmployeeId == employee.Empid))
    .Select(employee => new
    {
        Employee = employee.EmpName,
        ProjectCount = assignments.Count(a => a.EmployeeId == employee.Empid)
    })
    .ToList();

Console.WriteLine("\nEmployees sorted by the number of projects they are working on:");
foreach (var employee in employeesSortedByProjects)
{
    Console.WriteLine($"{employee.Employee} ({employee.ProjectCount} projects)");
}