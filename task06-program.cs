//using System;

//#region Struct Point Basic
//public struct Point
//{
//    public int X;
//    public int Y;

//    public Point()
//    {
//        X = 0;
//        Y = 0;
//    }

//    public Point(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public override string ToString()
//    {
//        return $"({X}, {Y})";
//    }
//}
//#endregion

//#region TypeA Access Modifiers
//public class TypeA
//{
//    private int F = 10;
//    internal int G = 20;
//    public int H = 30;

//    public int GetF()
//    {
//        return F;
//    }
//}
//#endregion

//#region Employee Encapsulation
//public struct Employee
//{
//    private int EmpId;
//    private string Name;
//    private double Salary;

//    public Employee(int id, string name, double salary)
//    {
//        EmpId = id;
//        Name = name;
//        Salary = salary;
//    }

//    public string GetName()
//    {
//        return Name;
//    }

//    public void SetName(string name)
//    {
//        Name = name;
//    }

//    public double SalaryProperty
//    {
//        get { return Salary; }
//        set { Salary = value; }
//    }
//}
//#endregion

//#region Constructor Overloading Point
//public struct PointOverload
//{
//    public int X;
//    public int Y;

//    public PointOverload(int x)
//    {
//        X = x;
//        Y = 0;
//    }

//    public PointOverload(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }
//}
//#endregion

//#region Value vs Reference Type
//public class EmployeeRef
//{
//    public int Salary;
//}
//#endregion

//#region Copy Constructor
//public class Person
//{
//    public string Name;

//    public Person(string name)
//    {
//        Name = name;
//    }

//    public Person(Person other)
//    {
//        Name = other.Name;
//    }
//}
//#endregion

//#region Indexer
//public class Company
//{
//    private string[] employees = new string[3];

//    public string this[int index]
//    {
//        get { return employees[index]; }
//        set { employees[index] = value; }
//    }
//}
//#endregion

//#region Test Program
//class Program
//{
//    static void ModifyPoint(Point p)
//    {
//        p.X = 100;
//    }

//    static void ModifyEmployee(EmployeeRef e)
//    {
//        e.Salary = 10000;
//    }

//    static void Main()
//    {
//        Point p = new Point(5, 6);
//        Console.WriteLine(p);

//        TypeA obj = new TypeA();
//        Console.WriteLine(obj.GetF());
//        Console.WriteLine(obj.G);
//        Console.WriteLine(obj.H);

//        Employee emp = new Employee(1, "Ali", 5000);
//        Console.WriteLine(emp.GetName());
//        emp.SetName("Omar");
//        emp.SalaryProperty = 7000;
//        Console.WriteLine(emp.GetName());
//        Console.WriteLine(emp.SalaryProperty);

//        ModifyPoint(p);
//        Console.WriteLine(p.X);

//        EmployeeRef empRef = new EmployeeRef { Salary = 5000 };
//        ModifyEmployee(empRef);
//        Console.WriteLine(empRef.Salary);
//    }
//}
//#endregion
