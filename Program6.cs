
//Classes in C#
using System;

class Customer
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

