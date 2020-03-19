
//Classes & Static and Instance Class & Inheritance & Polymorphism & Properties & Structures  & Interfaces & Abstract Classes in C#
using System;
public abstract class Student
{
    public abstract void Print();
   
}
public  class Program : Student
{
    public override void Print()
    {
        Console.WriteLine("Providing implementation for abstract class");
    }


    public static void Main()
    {
        Student S = new Program();
        S.Print();
    }
}


























/*
interface I1
{
    void Interfacemethod();
}

interface I2
{
    void Interfacemethod();
}

public class Program : I1,I2
{

     public void Interfacemethod()
    {
        Console.WriteLine("I1 interfacemethod printed by default interface implementation");
    }
     void I2.Interfacemethod()
     {
         Console.WriteLine("\nI2 interfacemethod printed by explicit interface implementation");
     }

    public static void Main()
    {
        Program P = new Program();
        P.Interfacemethod();
        ((I2)P).Interfacemethod();
        
        // I1 i1 = new Program();
        //I2 i2 = new Program();
        //i1.Interfacemethod();
        //i2.Interfacemethod();

        //((I1)P).Interfacemethod();
        //((I2)P).Interfacemethod();

       
    }
}

*/






















/*
interface IStudent
{
    void Print();
    
}

interface IStudent1 : IStudent
{
    void Print1();
}


public class Student : IStudent1
{
    public void Print()
    {
        Console.WriteLine("Output for an interface declaration");
    }

    public void Print1()
    {
        Console.WriteLine("\nClass inheriting multiple interfaces");
    }
}



public class Program
{
    public static void Main()
    {
        Student S1 = new Student();
        S1.Print();
        IStudent1 S2 = new Student();
        S2.Print1();

    }
}

*/






















/*
public struct Customer
{
    private int _id;
    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int ID
    {
        get { return this._id; }
        set { this._id = value; }
    }

    public Customer(int Id, string Name)
    {
        this._id = Id;
        this._name = Name;
    }

    public void Print()
    {   
         Console.WriteLine("Student ID -> {0}  &&  Student name -> {1}", this._id, this._name);
    }
}
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Student data printed using Structures from parameterised constructor");
            Customer C1 = new Customer(137, "Pushkar Apte");
            C1.Print();

            Console.WriteLine("\nStudent data printed using Structures from default constructor");
            Customer C2 = new Customer();
            C2.ID = 138;
            C2.Name = "Simran Lalwani";
            C2.Print();

            Console.WriteLine("\nStudent data printed using Structures from object initializer syntax");
            Customer C3 = new Customer
            {
                ID = 139,
                Name = "Payal Raghani"
            };
            C3.Print();

            
        }
    }
*/























/*
public class Student
{
    private int _id;
    private string _Name;
    private int _Passing = 35;

   public string City { get; set; }
    public int PassMark
    {
        get
        {
            return this._Passing;
        }
    }

    public string Name
    {
        set
        {

            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Student name cannot be empty");
            }
            this._Name = value;
        }
        get
        {
            return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
        }
    }    

    public string GetName()
    {
        if (string.IsNullOrEmpty(this._Name))
        {
            return "No Name";
        }
        else
        {
            return this._Name;
        }
    }

    public int ID
    {
        set
        {
            if (value <= 0)
            {
                throw new Exception("ID cannot be negative");
            }
            this._id = value;
        }
        get
        {
            return this._id;
        }
    }
    public int GetID()
    {
        return this._id;
    }
}
public class Program
{
    public static void Main()
    {
        Student S1 = new Student();
        S1.ID = 137;
        S1.Name = "Pushkar Apte";
        Console.WriteLine("Using properties to print student data");
        Console.WriteLine("Student id is {0}", S1.ID); 
        Console.WriteLine("Student name is {0}", S1.Name);
        Console.WriteLine("Passing marks is {0}", S1.PassMark);
        Console.WriteLine("Students city is {0}", S1.City);
    }
}
*/























/*
public class Employee
{
    public string firstname = "fn";
    public string lastname = "ln";

    public virtual void PrintFullName()
{
    Console.WriteLine(firstname + " " + lastname);
}
}


public class FullTimeEmployee : Employee
{
    public override void  PrintFullName()
    {
        Console.WriteLine(firstname + " " + lastname + " -> Full Time");
    }
}
public class PartTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(firstname + " " + lastname + "-> Part Time");
    }
}
public class TempTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(firstname + " " + lastname + "-> Temporary");
    }
}

public class Program
{
    public static void Main()
    {
        Employee[] employee = new Employee[4];
        employee[0] = new Employee();
        employee[1] = new FullTimeEmployee();
        employee[2] = new PartTimeEmployee();
        employee[3] = new TempTimeEmployee();
         
        foreach ( Employee e in employee)
        {
            e.PrintFullName();
        }
        
            
        }
    }


*/






















/*
public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("Parent Constructor");
    }
    public ParentClass(string Message)
    {
        Console.WriteLine(Message);
    }
}
public class ChildClass : ParentClass 
{   
    public ChildClass() : base("Parameterized constructor from base class is called instead of default")
    {
        Console.WriteLine("Child Constructor");
    }
}
class Program
{
    public static void Main()
    {
        ChildClass CC = new ChildClass();
        
    }   
} */














/*
 public class Employee
{
    public string firstname;
    public string lastname;
    public string email;
                     

    public void PrintFullName()
    {
        Console.WriteLine(firstname + " " + lastname);
        Console.WriteLine(email);
        
    }
}

public class FullTimeEmployee : Employee
{
    public float YearlySalary;
}

public class PartTimeEmployee : Employee
{
    public float HourlySalary;
}

class Program
{
    public static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.firstname = "Pushkar";
        FTE.lastname = "Apte";
        FTE.email = "xyz@gmail.com";
        FTE.YearlySalary = 500000;
        FTE.PrintFullName();
       
    }
} */

/*class Circle
{
    static float _Pi;
    int _Radius;

    static Circle()
    {
        Console.WriteLine("Static field");
        Circle._Pi = 3.141F;
    }

public Circle(int Radius)
{
    Console.WriteLine("Instance field");
this._Radius = Radius;
} 
public float CalculateArea()
{
return _Pi * this._Radius * this._Radius;
}
}
class Program 
{
    public static void Main()
    {
        Circle c1 = new Circle(10);
        float Area1 = c1.CalculateArea();
        Console.WriteLine("Area1 = {0}", Area1);

        Circle c2 = new Circle(15);
        float Area2 = c2.CalculateArea();
        Console.WriteLine("Area2 = {0}", Area2);
    }
}
*/

/* class Customer
{
    string _firstname;
    string _lastname;


     public Customer()
         : this("No firstname provided","No lastname provided")
     {
     }

    public Customer(string FirstName, string LastName)
    {

        this._firstname = FirstName;
        this._lastname = LastName;
    }

    public void PrintName()
    {
        Console.WriteLine("Full Name -> {0}", this._firstname + " " + this._lastname);
    }

    ~Customer()
    { 
        //Clean up code
    }

}

class Program
    {
        static void Main()
        {
            //Customer C1 = new Customer();
            Customer C1 = new Customer("Pushkar","Apte");
            C1.PrintName();
        }
    }
*/