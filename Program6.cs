

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;




















/*
public class Program
{
    public static void Main()
    {
        StringBuilder userstring = new StringBuilder("C#");
        userstring.Append(" Hello");
        userstring.Append(" to");
        userstring.Append(" Learning");
        userstring.Append(" Video");
        Console.WriteLine(userstring);
    }
}
*/























/*
public class Program
{
    public static void Main()
    {
        Customer C1 = new Customer();
        C1.Firstname = "Pushkar";
        C1.Lastname = "Apte";
        Customer C2 = new Customer();
        C2.Firstname = "Pushkar";
        C2.Lastname = "Apte";
        
        Console.WriteLine("Showing reference and value equality");
        Console.WriteLine();
        Console.WriteLine(C1 == C2);
        Console.WriteLine(C1.Equals(C2));
    }
}

public class Customer
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }
        if (!(obj is Customer))
        {
            return false;
        }
       return this.Firstname == ((Customer)obj).Firstname &&
                this.Lastname == ((Customer)obj).Lastname;
    } 
     
    public override int  GetHashCode()
{
    return this.Firstname.GetHashCode() ^ this.Lastname.GetHashCode();
}
    }
*/
















/*
public class Program
{
    public static void Main()
    {
        bool Equal = Calculator<int>.AreEqual(10, 10);
        if (Equal)
        {
            Console.WriteLine("Checked using Generics for string");
            Console.WriteLine("\nEqual");
        }
        else
        {
            Console.WriteLine("Checked using Generics for string");
            Console.WriteLine("\nNot Equal");
        }

    }
}
public class Calculator<T>
{
    public static bool AreEqual(T Value1, T Value2)
    {
        return Value1.Equals(Value2);
    }
}
*/



















/*
public class Program
{
    private static void Main()
    {
        Calculator.Multiply(20,30);
    }
}
public class Calculator 
{  
    [ObsoleteAttribute("Use Multiply(List<int> numbers)",true)]
    public static int Multiply(int fn,int sn)
    {
        return fn * sn;
     }
    public static int Multiply(List<int> numbers)
    {
        int Multiply = 0;
        foreach (int number in numbers)
        {
            Multiply = Multiply * number;
     }
        return Multiply;
    }
   
    
}
*/






















/*
class Program
{
    public static void Main()
    {
        Student[] students = new Student[3];
        students[0] = new Student
        {
            Name = "Pushkar",
            Subject = Subject.Unknown
        };

        students[1] = new Student
        {
            Name = "Harsh",
            Subject = Subject.BDA
        };
        students[2] = new Student
        {
            Name = "Preet",
            Subject = Subject.R
        };
        foreach (Student student in students)
        {
            Console.WriteLine("Name is {0} then subject is {1}", student.Name, student.Subject);
        }
    }
    public static string GetSubject(Subject subject)
    {
        switch (subject)
        {
            case Subject.Unknown:
                return "Unknown";
            case Subject.BDA:
                return "BDA";
            case Subject.R:
                return "R";
             default:
                return "Invalid Subject";
        }
    }

    public enum Subject
    {
        Unknown,
        BDA,
        R
    }
    public class Student
    {
        public string Name { get; set; }
        public Subject Subject { get; set; }
    }
}

*/


















/*
class InnerException
{
    public static void Main()
    {
        try
        {
            try
            {
                Console.WriteLine("Please enter the first number");
                int fn = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the second number");
                int sn = Convert.ToInt32(Console.ReadLine());

                int result = fn / sn;
                Console.WriteLine("Result -> {0}", result);
            }
            catch (Exception ex)
            {
                string filepath = "C:\\Sample Files\\Log1";
                if (File.Exists(filepath))
                {
                    StreamWriter sw = new StreamWriter(filepath);
                    sw.Write(ex.GetType().Name);
                    sw.Write(ex.Message);
                    sw.Close();
                    Console.WriteLine("Please try again");
                }
                else
                {
                    throw new FileNotFoundException(filepath + "does no exist", ex);
                }
            }
            
         }
        catch (Exception exception)
        {
            Console.WriteLine("Current Exception -> {0}", exception.GetType().Name);
            if (exception.InnerException != null)
            {
                Console.WriteLine("Inner Exception -> {0}", exception.InnerException.GetType().Name);
            }
            }
    }
}

*/





















/*
class ExceptionHandling
{
    public static void Main()
    {
        StreamReader streamreader = null;
        try
        {
             streamreader = new StreamReader("C:\\Sample Files\\Data1.txt");
            Console.WriteLine(streamreader.ReadToEnd());
            
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Please check if the file {0} exist", ex.FileName);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (streamreader != null)
            {
                streamreader.Close();
            }
                Console.WriteLine("Resources Released in finally block");

            
        }
    }
}*/

























/*
public delegate void PrintDelegate(string Message);

class Pushkar
{
    public static void Main()
    {
        
        Print("Printing message using delegate");
        // delegate is a type safe fucntion pointer
    }

    public static void Print(string Message)
    {
        Console.WriteLine(Message);
    }
} */
























/*
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
*/

























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