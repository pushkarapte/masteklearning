
//Classes Static Instance Inheritance in C#
using System;

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
}














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