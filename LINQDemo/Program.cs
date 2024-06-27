using LINQDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        List<Employee> emplist = new List<Employee>()
        { new Employee{Empid=1,Empname="Jack",city="pune"},
          new Employee{Empid=1,Empname="Ankita",city="Nashik"},
          new Employee{Empid=1,Empname="Shankari",city="Mumbai"},

        };

        var findEmplyees=(from e in emplist
                         orderby e.Empname ascending
                         select e).ToList();
        foreach (Employee emp in findEmplyees)
        {
            Console.WriteLine(emp.Empid);
            Console.WriteLine(emp.Empname);
            Console.WriteLine(emp.city);
        }
        int[] arr=new int[10] { 1,2,3,4,5,6,7,8,9,10};
        var evenNos = from a in arr
                      where a%2 == 0
                      select a;
        foreach (int i in evenNos)
        {
            Console.WriteLine(i);
        }
    }
}