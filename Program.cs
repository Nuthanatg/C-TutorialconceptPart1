using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;
//class Program
//{
//ctrl+f5 to run 
//1.basic structure of c#
//static void Main1()
//{
//    Console.WriteLine("Welcome to C# Training1");
//}

//static void Main()
//{
// Console.WriteLine("Welcome to C# Training");
//Main1();
//}

//2.Reading and writing to console
//static void Main()
//{
//    Console.WriteLine("Please enter your name:");

//    string UserName = Console.ReadLine();

//    //Console.WriteLine("Hello " + UserName);
//    Console.WriteLine("Hello {0},{1}", UserName);//0 is 1st placeholder, 1 is 2nd
//}

//3.Builtin type in c#
//1,Boolean type
//static void Main()
//{
//    bool b = true;
//    //b = 123;

//    int i = 0;
//    Console.WriteLine("min = {0}",int.MinValue);
//    Console.WriteLine("max = {0}", int.MaxValue);
//    //Console.ReadLine();
//    // escape sequence for character\
//    string name = "\"nuthana\"";
//    Console.WriteLine(name);

//    //
//    string Name = @"C:\nuthana\DotNet\Training\Csharp";
//    Console.WriteLine(Name);
//}

//Null coalescing operater
//static void Main()
//{
//    int? TicketOnSale = 100;
//    int AvaialableTickets;
//    if(TicketOnSale == null)
//    {
//        AvaialableTickets = 0;
//    }
//    else
//    {
//        AvaialableTickets = (int)TicketOnSale;//TicketOnSale.Value;
//    }
//    Console.WriteLine("AvaialableTickets={0}", AvaialableTickets);
//}

//switch,break,goto

//while for printing even number ex 10 it will print 0,2,4,6,8,10

//do while loop part-14
//static void Main()
//{
//    string UserChoice = string.Empty;
//    do
//    {
//        Console.WriteLine("Please enter your target?");
//        int UserTarget = int.Parse(Console.ReadLine());
//        int Start = 0;

//        while (Start <= UserTarget)
//        {
//            Console.Write(Start + " ");
//            Start = Start + 2;
//        }

//        do
//        {
//            Console.WriteLine("Do you want to continue - Yes or No?");

//            UserChoice = Console.ReadLine().ToUpper();
//            if (UserChoice != "YES" && UserChoice != "NO")
//            {
//                Console.WriteLine("Invalid choice, please say Yes or No");
//            }
//        } while (UserChoice != "YES" && UserChoice != "NO");
//    } while (UserChoice == "YES");
//}

//for loop part-15
//static void Main()
//{
//    int[] Numbers = new int[4];
//    Numbers[0] = 101;
//    Numbers[1] = 102;
//    Numbers[2] = 103;
//    Numbers[3] = 104;

//    foreach (int k in Numbers)
//    {
//        Console.WriteLine("foreach-{0}", k);
//    }

//    for (int j = 0; j <= Numbers.Length; j++)
//    {
//        Console.WriteLine(Numbers[j]);
//    }

//    int i = 0;//i act as a counter to the loop through the array
//    while (i < Numbers.Length)
//    {
//        Console.WriteLine(Numbers[i]);
//        i++;
//    }

//    for (int i = 0; i <= 20; i++)//if we want to print only even numbers we have several way like int i = 0; i <= 20; i = i+2 but by using continue
//    {
//        //Console.WriteLine(i);
//        //if (i == 10)
//        //    break;

//        if (i % 2 == 1)
//            continue;

//        Console.WriteLine(i);
//    }
//}

////part-16-methods in c#
//public static void Main()//this is static method
//{
//    //we can have our own method and call it for ex
//    //if we want to invoke instance we need to create an instance of the class(instance is nothing but an object of the class)
//    //Program p = new Program();
//    //p.EvenNumbers();

//    Program.EvenNumbers(30);//we use thhis if method is static

//    Program p = new Program();
//    int Sum = p.Add(10, 20);
//    Console.WriteLine("sum-{0}", Sum);
//}

//public int Add(int FN, int SN)
//{
//    return FN + SN;
//}
//public static void EvenNumbers(int Target)//this function or method is call instance ,ethod because it doesnot have static key word
//{
//    int Start = 0;
//    while (Start <= Target)//20)
//    {
//        Console.WriteLine(Start);
//        Start = Start + 2;
//    }
//}

//part 17 types of method parameters
//public static void Main()
////ex for valuee and reference parameter
////{
////    int i = 0;
////    Program.SimpleMethod(ref i);
////    //or SimpleMethod(i);
////    Console.WriteLine(i);
////}
////public static void SimpleMethod(ref int j)
////{
////    j = 101;
////}

//////ex for out parameter
////{
////    int Total = 0;
////    int Product = 0;
////    Calculate(10, 20, out Total, out Product);
////    Console.WriteLine("Sum={0} && Product={1}", Total, Product);
////}

//////here we can return only one value i.e sum value of FN and SN , but if want to return product of those 2 values means we go for out parameter
////public static void Calculate(int FN, int SN, out int Sum, out int Product)
////{
////    Sum = FN + SN;
////    Product = FN * SN;
////}

////ex for parameter Array
//{
//    int[] Numbers = new int[3];
//    Numbers[0] = 101;
//    Numbers[1] = 102;
//    Numbers[2] = 103;

//    //ParamsMethod();
//    ParamsMethod(Numbers);
//    //ParamsMethod(1,2,3,4,5);
//}

//public static void ParamsMethod(params int[] Numbers) //1 thing is we need to pass params (parameter array) in last in case if we have so many parameters , we cann't have other parameter in the end 
//{
//    Console.WriteLine("There are {0} elements", Numbers.Length);
//    foreach (int i in Numbers)
//    {
//        Console.WriteLine(i);
//    }
//}

//part-18 namespaces
//    public static void Main()
//    {
//        //ProjectA.TeamA.ClassA.Print();or at top  we can have "using ProjectA.TeamA;" and use below
//        //ProjectA.TeamA.ClassA.Print();
//        //ProjectA.TeamB.ClassA.Print();//one way we use fully qualified name to avoid ambiguty because if we give only ClassA.Print() and declare using ProjectA.TeamB; at top the complier will not understand which one to consider it will give error
//        //2nd is using alias for namespace like below
//        //PATA.ClassA.Print();
//        //PATB.ClassA.Print();
//        //Console.ReadLine();

//        //after created 2 other project and in main we have nothing if we run project they will execute in there own 'assembles' , the ClassA are there in there own assembly
//        //and i want to use those 2 assembles in this project how can we do -> go to project right click Add References 
//        PATA.ClassA.Print();
//        PATB.ClassA.Print();
//        Console.ReadLine();
//    }
//}

//this code we are removing from here and placing in ProjectA.TeamA.ClassA
//namespace ProjectA
//{
//    namespace TeamA // nested namespace
//    {
//        class ClassA
//        {
//            public static void Print()
//            {
//                Console.WriteLine("Team A Print Method");
//            }
//        }
//    }
//}

//this code we are removing from here and placing in ProjectA.TeamB.ClassA
//namespace ProjectA
//{
//    namespace TeamB
//    {
//        class ClassA
//        {
//            public static void Print()
//            {
//                Console.WriteLine("Team B Print Method");
//            }
//        }
//    }
//}


//part-19 Classes
//class Customer
//{
//    //class fields
//    string _firstName;
//    string _lastName;

//    public Customer() 
//        : this("No FN Provided","No LN Provided")
//    {
//    }

//    //constructor - used ti initialize the class fields
//    public Customer(string FirstName, string LastName)
//    {
//        this._firstName = FirstName;
//        this._lastName = LastName;
//    }

//    //class behavior or method
//    public void PrintFullName()
//    {
//        Console.WriteLine("Full Name = {0}", this._firstName + " " + this._lastName);
//    }

//    //destructor
//    ~Customer()
//    {
//        //clean uo code goes here
//    }
//}
//class Program
//{
//    public static void Main()
//    {
//        //i need to use above class in main method by creating instance of the class Customer
//        //Customer C1 = new Customer("Nuthana", "T G");
//        Customer C1 = new Customer();
//        C1.PrintFullName();

//        Customer C2 = new Customer("Nuthana", "T G");
//        C2.PrintFullName();
//        Console.ReadLine();
//    }
//}

//part-20 static and instance class members
//class Circle
//{
//    //static field
//    //static float _PI = 3.14F;
//    static float _PI;
//    //instance field
//    int _Radius;

//    //static constructor
//    static Circle()
//    {
//        Circle._PI = 3.14F;
//    }

//    //instance constructor
//    public Circle(int Radius)
//    {
//        this._Radius = Radius;
//    }

//    //static method
//    public static void Print()
//    {
//        //
//    }

//    //instance method
//    public float CalculateArea()
//    {
//        return Circle._PI * this._Radius * this._Radius;
//    }
//}

//class Program
//{
//    public static void Main()
//    {
//        Circle c1 = new Circle(5);
//        float Area = c1.CalculateArea();
//        Console.WriteLine("Area={0}", Area);

//        Circle c2 = new Circle(6);
//        float Area1 = c2.CalculateArea();
//        Console.WriteLine("Area={0}", Area1);
//        Console.ReadLine();
//    }
//}

////part21- inheritance

//public class Employee
//{
//    public string FN;
//    public string LN;
//    public string Email;
//    public void PrintFullName()
//    {
//        Console.WriteLine(FN + " " + LN);
//    }
//}

//public class FullTimeEmployee : Employee
//{
//    public float YearlySalary;
//}

//public class PartTimeEmployee : Employee //: Employee,A // notpossible to inherit multiple classes
//{
//    public float HourlyRate;
//}

//public class A : PartTimeEmployee //multi level class inheritance is possible now here the class A as acesses to all properties and code available in PartTimeEmployee + Employee class
//{

//}
//public class Program
//{
//    public static void Main()
//    {
//        A A1 = new A();
//        A1. // as the properties and code available in PartTimeEmployee + Employee class

//        FullTimeEmployee FTE = new FullTimeEmployee();
//        FTE.FN = "Nuthana";
//        FTE.LN = "T G";
//        FTE.Email = "nuthana.com";
//        FTE.YearlySalary = 40000;
//        FTE.PrintFullName();

//        PartTimeEmployee PTE = new PartTimeEmployee();
//        PTE.FN = "Part";
//        PTE.LN = "Time";
//        PTE.HourlyRate = 4000;
//        PTE.PrintFullName();
//    }
//}

//example fpr parent class constructor executes before childclass constructor 
//public class ParentClass
//{
//    public ParentClass()
//    {
//        Console.WriteLine("ParentClass Constructor called");
//    }
//    public ParentClass(string Message)
//    {
//        Console.WriteLine(Message);
//    }
//}

//public class ChildClass : ParentClass
//{
//    public ChildClass() : base("Derived class controlling Parent class") //here we specifing that we need to execute the custructor that we prefered by using base keyword by passing Message
//    {
//        Console.WriteLine("ChildClass Constructor called");
//    }
//}
//public class Program
//{
//    public static void Main()
//    {
//        ChildClass CC = new ChildClass();
//    }
//}

////part22- method hiding in c#

//public class Employee
//{
//    public string FN;
//    public string LN;
//    public void PrintFullName()
//    {
//        Console.WriteLine(FN + " " + LN);
//    }
//}

//public class PartTimeEmployee : Employee
//{
//    public new void PrintFullName() // now here we have PrintFullName method in parentclass and child class but when we instansiate PartTimeEmployee class it will hide PrintFullName in parentclass and execute PrintFullName that is in childclass 
//    {
//        base.PrintFullName();// 1st way to call hiden method
//        //Console.WriteLine(FN + " " + LN + " - Contractor");
//    }
//}

//public class FullTimeEmployee : Employee
//{

//}

//public class Program
//{
//    public static void Main()
//    {
//        FullTimeEmployee FTE = new FullTimeEmployee();
//        FTE.FN = "FullTime";
//        FTE.LN = "Employee";
//        FTE.PrintFullName();

//        //PartTimeEmployee PTE = new PartTimeEmployee();
//        //PTE.FN = "PartTime";
//        //PTE.LN = "Employee";
//        ////PTE.PrintFullName();
//        //((Employee)PTE).PrintFullName();// 2nd way - we use a typecast operator and convert that of the type Employee and converted object we call PrintFullName method

//        //3rd way to call hidden method
//        Employee PTE = new PartTimeEmployee(); //using parent class as refering variable 
//        PTE.FN = "PartTime";
//        PTE.LN = "Employee";
//        //PTE.PrintFullName();
//        ((Employee)PTE).PrintFullName();

//        //and we also thinking can we do this 
//        PartTimeEmployee PTE = new Employee();//we cann't do this this will give you compiler error because an employee object cannot fullfill all the responsibilty of a PartTimeEmployee this is not possible visaversa is possible
//        //a parentclass reference variable can point to child class object whereas visaversa is not possible
//    }
//}

//part-23 Polymorphism in C#

//public class Employee
//{
//    public string FN = "fn";
//    public string LN = "ls";
//    public virtual void PrintFullName()
//    {
//        Console.WriteLine(FN + " " + LN);
//    }
//}

//public class PartTimeEmployee : Employee
//{
//    //public new void PrintFullName()
//    //{
//    //    Console.WriteLine(FN + " " + LN + " - PartTime");
//    //}
//    public override void PrintFullName()
//    {
//        Console.WriteLine(FN + " " + LN + " - PartTime");
//    }
//}

//public class FullTimeEmployee : Employee
//{
//    public override void PrintFullName()
//    {
//        Console.WriteLine(FN + " " + LN + " - FullTime");
//    }
//}

//public class TemporaryEmployee : Employee
//{
//    public override void PrintFullName()
//    {
//        Console.WriteLine(FN + " " + LN + " - Temporary");
//    }
//}
//public class Program
//{
//    public static void Main()
//    {
//        Employee[] Employees = new Employee[4];

//        Employees[0] = new Employee();
//        Employees[1] = new PartTimeEmployee();
//        Employees[2] = new FullTimeEmployee();
//        Employees[3] = new TemporaryEmployee();

//        foreach(Employee e in Employees)
//        {
//            e.PrintFullName();
//        }
//    }
//}

////part-24 Method overriding VS method Hiding
//public class BaseClass
//{
//    public virtual void Print()
//    {
//        Console.WriteLine("I am a Base Class Print Method");
//    }
//}

//public class DerivedClass : BaseClass
//{
//    public override void Print() // method overriding
//    {
//        Console.WriteLine("I am a Derived Class Print Method");
//    }

//    //public override void Print() // method hiding
//    //{
//    //    Console.WriteLine("I am a Derived Class Print Method");
//    //}
//}
//public class Program
//{
//    public static void Main()
//    {
//        BaseClass B = new DerivedClass();
//        B.Print();

//        //////for method hiding calling DerivedClass method not hidden class
//        ////DerivedClass D = new DerivedClass();
//        ////D.Print();
//    }
//}

////part-25 method overloading
//public class Program
//{
//    public static void Main()
//    {
//       // Add()
//    }

//    public static void Add(int FN,int SN)
//    {
//        Console.WriteLine("Sum = {0}", FN + SN);
//    }

//    //public static void Add(int FN, int SN, int TN)
//    //{
//    //    Console.WriteLine("Sum = {0}", FN + SN);
//    //}

//    public static void Add(int FN, float SN)
//    {
//        Console.WriteLine("Sum = {0}", FN + SN);
//    }

//    public static void Add(int FN, int SN,out int Sum)
//    {
//        Console.WriteLine("Sum = {0}", FN + SN);
//        Sum = FN + SN;
//    }

//    //the signature of a method does not include the returntype and params modifier,so it is not possible to overload a function just based on the returntype and params modifier give error
//    //1.the returntype
//    public static void Add(int FN, int SN, int TN)
//    {
//        Console.WriteLine("Sum = {0}", FN + SN);
//    }

//    public static int Add(int FN, int SN, int TN)
//    {
//        Console.WriteLine("Sum = {0}", FN + SN);
//        return FN + SN + TN;
//    }

//    //2.params modifier
//    public static void Add(int FN, int SN,params int[] TN)
//    {
//        Console.WriteLine("Sum = {0}", FN + SN);
//    }

//    public static void Add(int FN, int SN,int[] TN)
//    {
//        Console.WriteLine("Sum = {0}", FN + SN);
//    }
//}

////part-26 Properties

//public class Student
////{
////    public int ID;
////    public string Name;
////    public int Passmark = 35;
////}
////public class Program
////{
////    public static void Main()
////    {
////        Student C1 = new Student();
////        C1.ID = -101;
////        C1.Name = null;
////        C1.Passmark = 0;

////        Console.WriteLine("ID = {0} && Name = {1} && PassMark = {2}", C1.ID, C1.Name, C1.Passmark);
////    }
////}
//{
//    private int ID;
//    private string Name;
//    private int Passmark = 35;

//    public void SetId(int Id)
//    {
//        if (Id <= 0)
//        {
//            throw new Exception("Student Id connot be negative");
//        }
//        this.ID = Id;
//    }

//    public int GetId()
//    {
//        return this.ID;
//    }

//    public void SetName(string name)
//    {
//        if (string.IsNullOrEmpty(name))
//        {
//            throw new Exception("Name connot be null or empty");
//        }
//        this.Name = name;
//    }

//    public string GetName()
//    {
//        return string.IsNullOrEmpty(this.Name) ? "No name" : this.Name;
//        //if (string.IsNullOrEmpty(this.Name))
//        //{
//        //    return "No name";
//        //}
//        //else
//        //{
//        //    return this.Name;
//        //}
//    }

//    public int GetPassMark()
//    {
//        return this.Passmark;
//    }

// }
//public class Program
//{
//    public static void Main()
//    {
//        Student C1 = new Student();
//        //C1.ID = -101;
//        //C1.Name = null;
//        //C1.Passmark = 0;

//        //Console.WriteLine("ID = {0} && Name = {1} && PassMark = {2}", C1.ID, C1.Name, C1.Passmark);

//        C1.SetId(101);//-101
//                      // C1.SetName(null);
//        C1.SetName("Nuthana");

//        Console.WriteLine("ID = {0}", C1.GetId());
//        Console.WriteLine("Name = {0}", C1.GetName());
//        Console.WriteLine("Marks = {0}", C1.GetPassMark());
//    }
//}

////part-27 proteries in c#
//public class Student
//{
//    private int ID;
//    private string Name;
//    private int Passmark = 35;

//    ////like this we need to write huge code so we use auto implemented properties
//    //private string city;
//    //private string email;

//    //public string City
//    //{
//    //    get
//    //    {
//    //        return this.city;
//    //    }
//    //    set
//    //    {
//    //        this.city = value;
//    //    }
//    //}
//    //public string Email
//    //{
//    //    get
//    //    {
//    //        return this.email;
//    //    }
//    //    set
//    //    {
//    //        this.email = value;
//    //    }
//    //}

//    //like this we need to write huge code so we use auto implemented properties we comment fields
//    //private string city;
//    //private string email;

//    public string City // compiler will automatically create private field city and give read and write accces
//    {
//        get;
//        set;
//    }
//    public string Email{get;set;}

//    public int Id//we use properties instead of getter and setter method and pass return type as int instead od void and will not send the parameters 
//    {
//        set
//        {
//            if (value <= 0) // value is a keyword used to store value data 
//            {
//                throw new Exception("Student Id connot be negative");
//            }
//            this.ID = value;
//        }
//        get
//        {
//            return this.ID;
//        }
//    }

//    public string name
//    {
//        set
//        {
//            if (string.IsNullOrEmpty(value))
//            {
//                throw new Exception("Name connot be null or empty");
//            }
//            this.Name = name;
//        }
//        get
//        {
//            return string.IsNullOrEmpty(this.Name) ? "No name" : this.Name;
//        }
//    }

//    public int PassMark
//    {
//        get
//        {
//            return this.Passmark;
//        }
//    }

//}
//public class Program
//{
//    public static void Main()
//    {
//        Student C1 = new Student();
//        C1.Id = 101;//-101
//        C1.name = "Nuthana";

//        Console.WriteLine("ID = {0}", C1.Id);
//        Console.WriteLine("Name = {0}", C1.name);
//        Console.WriteLine("Marks = {0}", C1.PassMark);
//    }
//}

////part-28 structures in c#

//public struct Customer
//{
//    private int _id;
//    private string _name;

//    public int ID
//    {
//        get { return this._id; }
//        set { this._id = value;}
//    }

//    public string Name { get => _name; set => _name = value; }//right click on field and select encapsulates feilds

//    //constructor
//    public Customer(int Id,string Name)
//    {
//        this._id = Id;
//        this._name = Name;
//    }

//    //methods
//    public void PrintDetails()
//    {
//        Console.WriteLine("Id={0} && Name={1}", this._id, this._name);
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        //tocreate instance of stuct we use same syntax as class
//        Customer C1 = new Customer(101, "Nuthana");
//        C1.PrintDetails();
//        //new ayntax to create instance that is called object inisilaizser syntax here we are using public properties to create
//        Customer C2 = new Customer();
//        C2.ID = 102;
//        C2.Name = "new";
//        C2.PrintDetails();

//        Customer C3 = new Customer
//        {
//            ID = 103,
//            Name = "anotherway to create instance"
//        };
//        C3.PrintDetails();
//    }
//}

////part-29 classes vs struct
////simple example for stack and heap

////structs can't have destructors but classes have destructors

////public struct Customer
//public sealed class Customer
//{
//    public int ID { get; set; }
//    public string Name { get; set; }

//    //structs can't have destructors but classes have destructors
//    //~Customer()
//    //{

//    //}

//    //structs cannot have explicit parameter less constructors where as class can
//    public Customer()
//    {

//    }
//}

//public class Program : Customer
//{
//    public static void Main()
//    {
//        //int i = 10;
//        //if (i == 10)
//        //{
//        //    int j = 20;
//        //    Customer C1 = new Customer();
//        //    C1.ID = 101;
//        //    C1.Name = "Nuthana";// after this line j value will destroied in memory as soon the scope is lossed
//        //}
//        //Console.WriteLine("Hello");

//        //// the storing the copy of the struct value into anthor sturct(value type)i.e copying value i to j value type what happen in memory in book
//        //int i = 10;
//        //int j = i;
//        //j = i + 1;
//        //Console.WriteLine("i={0} && j={1}", i, j);

//        ////what happen when we copy a reference type
//        //Customer C1 = new Customer();
//        //C1.ID = 101;
//        //C1.Name = "Number";

//        //Customer C2 = C1;

//        //C2.Name = "Nuthana";

//        //Console.WriteLine("C1.Name={0} && C2.Name={1}", C1.Name, C2.Name);


//    }
//}

////part-30 introduction to interface
//interface ICustomer
//{
//    //int ID;//interface cannot have fields classes can have
//    void Print();//this is interface member , member is public by default no need to write public explicitly it will give error
//    //{
//    //    Console.WriteLine("Hello");// in interface we only have declaration not implementation
//    //}
//}

//interface I2 : ICustomer
//{
//    void I2Method();
//}
//public class Customer : I2  //now Customer inherting from Inferface2 so that is inherting from ICustomer so we need to implement all menthods in both interface //ICustomer,I2 //here class Customer inherits and implementing interface ICustomer
//{
//    public void I2Method()
//    {
//        Console.WriteLine("I2 Method");
//    }

//    public void Print() // the signature of class should match the signature of the interface public void Print(int Name) is diffrent signature
//    {
//        Console.WriteLine("Interface Print Method");
//    }
//}

//public class Sample
//{

//}
//public class Program //: Customer,Sample
//{
//    public static void Main()
//    {
//        Customer C1 = new Customer();
//        C1.Print();
//        C1.I2Method();

//        //ICustomer Cust = new ICustomer; // language doesn't allow to create instance of interface because we don't have the implementation for interface only declaration what we can do
//        // here Cust is a reference variable of type ICustomer now Customer class actually inherting from the interface
//        ICustomer Cust = new Customer();
//        Cust.Print();
//        I2 Cust1 = new Customer();
//        Cust1.Print();
//        Cust1.I2Method();
//    }
//}

////Part-31-Explicit interface implemantation
//interface I1
//{
//    void InterfaceMethod();
//}

//interface I2
//{
//    void InterfaceMethod();
//}
//public class Program : I1,I2
//{
//    public void InterfaceMethod()// here we are implemanting implicitly and this is default implemantation
//    //void I1.InterfaceMethod()//explicitly implementing interface
//    {
//        Console.WriteLine("I1 Interface Method");
//    }

//    void I2.InterfaceMethod()
//    {
//        Console.WriteLine("I2 Interface Method");
//    }
//    public static void Main()
//    {
//        Program P = new Program();
//        P.InterfaceMethod();
//        ((I1)P).InterfaceMethod();//type casting
//        ((I2)P).InterfaceMethod();//type casting
//        //or

//        I1 i1 = new Program();
//        I2 i2 = new Program();
//        i1.InterfaceMethod();
//        i2.InterfaceMethod();
//    }
//}

////part32 abstract classes // part-33 abstract class vs interface
////abstract class used as a base class if we use sealed then class is not able to inherite it means abstract class is not base class so we not do both abstract an d sealed for a class
////public abstract sealed class Customer
//public abstract class Customer   //abstarct class and members are incomplete classes because they don't have the implemantation // we are not able to create a instance of abstract classes because they are incomplete classes
//{
//      int ID;
//    //public abstract void Print();
//    public void Print()
//    {
//        Console.WriteLine("print method inside abstarct class");
//    }
//}
//// option2 : public abstract class Program : Customer
//public class Program : Customer
//{
//    //public override void Print()
//    //{
//    //    Console.WriteLine("Abstract print method");
//    //}
//    public static void Main()
//    {
//        //Program P = new Program();
//        //P.Print();
//        ////or
//        Customer C = new Program();
//        C.Print();
//    }
//}

////part-34 problems of multiple class inheritance
//class A
//{
//    public virtual void Print()
//    {
//        Console.WriteLine("A implementation");
//    }
//}

//class B : A
//{
//    public override void Print()
//    {
//        Console.WriteLine("B implementation");
//    }
//}

//class C : A
//{
//    public override void Print()
//    {
//        Console.WriteLine("C implementation");
//    }
//}

//class D : B, C
//{

//}

//class Program
//{
//    public static void Main()
//    {
//        D d = new D();
//        d.Print();
//    }
//}

////part-35 Implementation of multiple class inheritance using interface
//interface IA
//{
//    void AMethod();
//}
//class A : IA
//{
//    public void AMethod()
//    {
//        Console.WriteLine("A");
//    }
//}

//interface IB
//{
//    void BMethod();
//}
//class B : IB
//{
//    public void BMethod()
//    {
//        Console.WriteLine("B");
//    }
//}

//class AB : IA, IB
//{
//    A a = new A();
//    B b = new B();
//    public void AMethod()
//    {
//        a.AMethod();
//    }

//    public void BMethod()
//    {
//        b.BMethod();
//    }
//}
//class Program
//{
//    public static void Main()
//    {
//        AB ab = new AB();
//        ab.AMethod();
//        ab.BMethod();
//    }
//}

////part-36 Delegates
//public delegate void HelloFunctionDelegate(string Message);
//class Program
//{
//    public static void Main()
//    {
//        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
//        del("Hello from Delegate");
//        //A delegate is a type safe function pointer

//        //like we are thinking why we are doing all the above complex code instead we can do 
//        Hello("Hello from Delegate");//will do the same but delegates will give lot of flexibility in realtime projects
//    }

//    public static void Hello(string strMessage)
//    {
//        Console.WriteLine(strMessage);
//    }
//    //public static string Hello(string strMessage) //so here we can see the signature is diffrent from delegate to function so giving error that's why delegates are called as type safe function pointer
//    //{
//    //    Console.WriteLine(strMessage);
//    //}
//}

////part-37,38 delegates usage

//class Program
//{
//    public static void Main()
//    {
//        List<Employee> empList = new List<Employee>();

//        empList.Add(new Employee() { ID = 101, Name = "Nuthana", Salary = 50000, Experience = 5 });
//        empList.Add(new Employee() { ID = 102, Name = "AB", Salary = 40000, Experience = 4 });
//        empList.Add(new Employee() { ID = 103, Name = "CD", Salary = 30000, Experience = 3 });
//        empList.Add(new Employee() { ID = 104, Name = "EF", Salary = 65000, Experience = 6 });

//        //Employee.PromoteEmployee(empList);

//        //here we are using delegates
//        // IsPromotable isPromotable = new IsPromotable(Promote); //if we use lamda function we can getrid of this code
//        //Employee.PromoteEmployee(empList, isPromotable);
//        Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);//we can use inline lamda expression
//    }

//    //public static bool Promote(Employee emp) //if we use lamda function we can getrid of this code
//    //{
//    //    if (emp.Experience >= 5)
//    //    {
//    //        return true;
//    //    }
//    //    else
//    //    {
//    //        return false;
//    //    }
//    //}
//}

//delegate bool IsPromotable(Employee empl);// delegate return ture or false for passed employee if eligible or not
//class Employee // here we need to reuse this class like now we are hardcoded based on their experience if we want using by salary to pomote
//               //so i want this PromoteEmployee method nut then it is felexible enough pleople to plugin the logic they want to promote their employees 
//{
//    public int ID { get; set; }
//    public string Name { get; set; }
//    public int Salary { get; set; }
//    public int Experience { get; set; }

//    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)//here we are passing delegate as parameter to the PromoteEmployee method anytime if you want to pass function as parameter then think of delegate
//    {
//        foreach (Employee employee in employeeList)
//        {
//            // if (employee.Experience >= 5) //here we are replacing this logic with delegate and their is no hardcoded logic
//            if (IsEligibleToPromote(employee))
//            {
//                Console.WriteLine(employee.Name + " promoted");
//            }
//        }
//    }
//}

////part-39 Multicast Delegates
////public delegate void SampleDelegate();
////to match with method method returning the value
////public delegate int SampleDelegate();
////usig with out parameter
//public delegate void SampleDelegate(out int Integer);
//public class Program
//{
//    public static void Main()
//    {
//        ////SampleDelegate del = new SampleDelegate(SampleMethodOne);
//        ////del();

//        ////2 ways to create multicast delegate one is create more than one instance
//        //SampleDelegate del1, del2, del3, del4;
//        //del1 = new SampleDelegate(SampleMethodOne);// delegate del1 pointing to SampleMethodOne method
//        //del2 = new SampleDelegate(SampleMethodTwo);
//        //del3 = new SampleDelegate(SampleMethodThree);

//        ////del4 = del1 + del2 + del3;//here now delegate 4 del4 pointing to all of the methods that are pointing by del1,del2,del3 // we do multicast delegate by chaining the delegates together with puls sign
//        ////del4();//when we invoke this delegate4 it will invoke all 3 methods ,since this(del4) delegate pointing to 3 different functions this del4 is called as a multicast delegate
//        //del4 = del1 + del2 + del3 - del2;//unchaining the delegate2
//        //del4();

//        //other way to create multicast delegate no need to create so many instances
//        //SampleDelegate del = new SampleDelegate(SampleMethodOne);
//        //del += SampleMethodTwo; //here we are use += to register the SampleMethodTwo method with delegate del
//        //del += SampleMethodThree;
//        //del -= SampleMethodTwo;//to remove a delegate we use minus sign
//        //del();

//        //invoking method returning value
//        //SampleDelegate del = new SampleDelegate(SampleMethodOne);
//        //del += SampleMethodTwo;
//        //int DelegateReturnedValue = del();
//        //Console.WriteLine("DelegateReturnedValue = {0}", DelegateReturnedValue);//when delegate has return value and if d is a md it will invoke only last invoked method will be returned

//        //using out parameter
//        SampleDelegate del = new SampleDelegate(SampleMethodOne);
//        del += SampleMethodTwo;
//        int DelegateReturnedOutputParameterValue = -1;
//        del(out DelegateReturnedOutputParameterValue);
//        Console.WriteLine("DelegateReturnedOutputParameterValue = {0}", DelegateReturnedOutputParameterValue); // when delegate has out parameter it will invoke only last invoked method will be returned
//    }
//    //public static void SampleMethodOne()
//    //{
//    //    Console.WriteLine("SampleMethodOne Invoked");
//    //}
//    //public static void SampleMethodTwo()
//    //{
//    //    Console.WriteLine("SampleMethodTwo Invoked");
//    //}
//    //public static void SampleMethodThree()
//    //{
//    //    Console.WriteLine("SampleMethodThree Invoked");
//    //}

//    //what if the method return a value like 
//    //public static int SampleMethodOne()
//    public static void SampleMethodOne(out int Number)
//    {
//        Number = 1;
//    }
//    //public static int SampleMethodTwo()
//    public static void SampleMethodTwo(out int Number)
//    {
//        Number = 2;
//    }
//}

////part-40 Exception handling
//using System.IO;
//class Program
//{
//    public static void Main()
//    {
//        StreamReader streamReader = null;
//        try
//        {
//            //StreamReader streamReader = new StreamReader(@"D:\Sample1Files\Data.txt");//or "D:\\Smple Files\\Data.txt" backlash as a special meaning we need to escape with other backlash or use the webetral litral
//            streamReader = new StreamReader(@"D:\Sample Files\Data1.txt");
//            Console.WriteLine(streamReader.ReadToEnd());//if the file as deleted or file name changed then it will give error
//          //streamReader.Close();
//        }
//        //catch (Exception ex)//this is wrong it should be in buttom
//        //{
//        //    Console.WriteLine(ex.Message);
//        //}
//        //catch(Exception ex)
//        catch (FileNotFoundException ex)//more specific exceptions are at top and general ones are at buttom
//        {
//            //Console.WriteLine(ex.Message);
//            //Console.WriteLine();
//            //Console.WriteLine();
//            //Console.WriteLine(ex.StackTrace);//StackTrace tell you which line throwing the exception 

//            //we log the details to the DB
//            Console.WriteLine("Please check if the file {0} exists", ex.FileName);
//        }
//        catch(Exception ex)//this is base exception class generalone
//        {
//            Console.WriteLine(ex.Message);
//        }

//        //if (streamReader != null) //we can also do like this without finally but
//        //{
//        //    streamReader.Close();
//        //}
//        //Console.WriteLine("finally block"); // if we do that if any exception occur in catch block suppose then after that no code will excecute that's why we use finally

//        finally
//        {
//           if(streamReader != null)
//            {
//                streamReader.Close();
//            }
//            Console.WriteLine("finally block");
//        }
//    }
//}

////part-41 inner exception
//using System.IO;
//class InnerException
//{
//    public static void Main()
//    {
//        try
//        {
//            try
//            {
//                Console.WriteLine("Enter First Number");
//                int FN = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Enter Second Number");
//                int SN = Convert.ToInt32(Console.ReadLine());

//                int Result = FN / SN;

//                Console.WriteLine("Result = {0}", Result);
//            }
//            catch (Exception ex)
//            {
//                string filePath = @"D:\Sample Files C#\log.txt";
//                if (File.Exists(filePath))
//                {
//                    StreamWriter streamWriter = new StreamWriter(filePath);
//                    streamWriter.Write(ex.GetType().Name);
//                    streamWriter.WriteLine();
//                    streamWriter.Write(ex.Message);
//                    streamWriter.WriteLine();
//                    streamWriter.Write(ex.StackTrace);
//                    streamWriter.Close();
//                    Console.WriteLine("There is a problem, Please try later");
//                }
//                else
//                {
//                    throw new FileNotFoundException(filePath + "is not present", ex);
//                }
//            }
//        }
//        catch (Exception exception)
//        {
//            Console.WriteLine("Current Exception - {0}", exception.GetType().Name);
//            if (exception.InnerException != null)
//            {
//                Console.WriteLine("Inner Exception - {0}", exception.InnerException.GetType().Name);
//            }
//        }
//    }
//}

////part-42 Custom exception
//using System.IO;
//using System.Runtime.Serialization;//this are namespaces
//public class CustomExceptions
//{
//    public static void Main()
//    {
//        //throw new FileNotFoundException("File XYZ not found");
//        try
//        {
//            throw new UserAlreadyLoggedInException("User is logged in - no duplicate session allowed");//,);//we get pass and get inner ex by passing that parameter to constructor
//        }
//        catch(UserAlreadyLoggedInException ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}

//[Serializable]
//public class UserAlreadyLoggedInException : Exception
//{
//    public UserAlreadyLoggedInException(): base()
//    {
//    }
//    public UserAlreadyLoggedInException(string message) : base(message)
//    {
//    }
//    public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)//passing inner exception to construtor
//    {
//    }
//    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)//customer exception as serializable 
//    {
//    }
//}

////part-43 ExceptionHandlingAbuse and 44-ExceptionHandlingAbuse sloved
//public class ExceptionHandlingAbuse
//{
//    public static void Main()
//    {
//        try
//        {
//            //Console.WriteLine("Please enter Numerator");
//            //int Numrator = Convert.ToInt32(Console.ReadLine());
//            //Console.WriteLine("Please enter Denominator");
//            //int Denominator = Convert.ToInt32(Console.ReadLine());

//            //int Result = Numrator / Denominator;

//            //Console.WriteLine("Result = {0}", Result);

//            Console.WriteLine("Please enter Numerator");
//            int Numrator;
//            bool IsNumeratorConversionSucessful=Int32.TryParse(Console.ReadLine(), out Numrator);
//            if (IsNumeratorConversionSucessful)
//            {
//                Console.WriteLine("Please enter Denominator");
//                int Denominator;
//                bool IsDenominatorConversionSucessful = Int32.TryParse(Console.ReadLine(), out Denominator);
//                if (IsDenominatorConversionSucessful && Denominator != 0)
//                {
//                    int Result = Numrator / Denominator;
//                    Console.WriteLine("Result = {0}", Result);
//                }
//                else
//                {
//                    if(Denominator == 0)
//                    {
//                        Console.WriteLine("Denominator cannot be Zero");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Denominator should be a valid number between {0} && {1}", Int32.MinValue, Int32.MaxValue);
//                    }
//                }
//            }
//            else
//            {
//                Console.WriteLine("Numerator should be a valid number between {0} && {1}", Int32.MinValue, Int32.MaxValue);
//            }
//        }
//        //we are checking on program logically
//        //catch (FormatException)
//        //{
//        //    Console.WriteLine("Please enter a number");
//        //}
//        //catch (OverflowException)
//        //{
//        //    Console.WriteLine("Only numbers between {0} && {1} are allowed", Int32.MinValue, Int32.MaxValue);
//        //}
//        //catch (DivideByZeroException)
//        //{
//        //    Console.WriteLine("Denominator cannot be zero");
//        //}
//        catch(Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//    //above what we have done is wrong we are abusing exception handling instead of using all above exceptions to handle this senarios we use error checking mechanism like using Convert.ToInt32 instead use int.tryparse method
//}

////part-45 why enums and part-46 enums example and 47-enums
//public class Enums
//{
//    public static void Main()
//    {
//        Customer[] customers = new Customer[3]; //3rd change in Customer object itself
//        customers[0] = new Customer
//        {
//            Name = "Mark",
//            Gender = Gender.Male
//        };
//        customers[1] = new Customer
//        {
//            Name = "Mary",
//            Gender = Gender.Female
//        };
//        customers[2] = new Customer
//        {
//            Name = "Sam",
//            Gender = Gender.Unknown
//        };

//        foreach (Customer customer in customers)
//        {
//            Console.WriteLine("Name={0} && Gender={1}", customer.Name, GetGender(customer.Gender));
//        }

//        //47 let say i want to get the values of this enum how do i get actually within the .net farework base class library we have a class called Enum class
//        //and it except to pass the type , type can be our class,our enum,stucture anything but here get the values for enum we pass the Gender type, Gender is the name of enum to get the type we have to use typeof method
//        //int[] Values= (int[])Enum.GetValues(typeof(Gender));
//        short[] Values = (short[])Enum.GetValues(typeof(Gender));//converting to short
//        foreach (short value in Values) // change int to short
//        {
//            Console.WriteLine(value);
//        }

//        //if we want symbolic name for those 0,1 and 2 we can use GetName function
//        string[] Names = Enum.GetNames(typeof(Gender));
//        foreach(string name in Names)
//        {
//            Console.WriteLine(name);
//        }
//        //2nd point in book
//        //enumscalled strongly typed constants and there are 2 reasons
//        // 1 is can i create a Gender
//        //Gender gender = 3;//Gender containing underline type as integer i am trying to assign an integer value to gender getting error so the compiler complining cannot convered to type Gender implitly and telling to cast explicitly,
//        //so they are called strongly typed though the underline  type of the enum is integer , the Underline type and enum are implicitly interchangable we cannot assign integer directly to the enum and vise versa
//        //to do so we needto explicitly cast
//        Gender gender = (Gender)3;
//        //again this is not possible
//        //int Num = Gender.Unknown;
//        int Num = (int)Gender.Unknown;

//        // now for Gender and Season Underline type are same can i do this
//        //Gender gender1 = Season.Winter;//can we do this no ,we know that Underline type Gender is integer and e know that Underline type Season is integer we need to do explicit cast
//        Gender gender1 = (Gender)Season.Winter;// for this reason we called it as Stronly typed
//    }
//   // public static string GetGender(int gender)
//    public static string GetGender(Gender gender)//2nd change in method insead of passing integer we pass enum
//    {
//        switch (gender)
//        {
//            //case 0:
//            //    return "Unknow";
//            //    break;
//            //case 1:
//            //    return "Male";
//            //    break;
//            //case 2:
//            //    return "FeMale";
//            //    break;
//            //default:
//            //    return "Invaild data detected";

//            //now the switch statement is more readable
//            case Gender.Unknown:
//                return "Unknown";
//            case Gender.Male:
//                return "Male";
//            case Gender.Female:
//                return "FeMale";
//            default:
//                return "Invaild data detected";
//        }
//    }
//}

////47-this is our enum if you don't specify anything if we create an enum like this it using the defaults meaning the underline data type of this enum is actually integer and the values for enums(unkown,male and female) start at 0
//public enum Gender : short//creating enum // now thw default underline data type is short
//{
//    //it is possiblw to customise the value that is enum contains for ex the default value starts at 0 but we can change it to 1 and the moment we put 1 there what happens is no need to specify value for other members what gone happen male become 2 and female=3
//    Unknown = 1,
//    Male = 235, 
//    Female= 1155
//}
//public enum Season//47 2 point
//{
//    Winter = 1,
//    Spring = 2,
//    Summer = 3
//}
////if gender is 0 - Unknown
////1-Male
////2-Female
//public class Customer
//{
//    public string Name { get; set; }
//    //public int Gender { get; set; }
//    public Gender Gender { get; set; }//using enums 1st we change the type of enum to int to gender
//}

//part-48 diffrence b/w types and type members

//public class Customer
//{
//    #region Fields
//    private int _id;
//    private string _firstName;
//    private string _lastName;
//    #endregion
//    #region Properties
//    public int Id
//    {
//        get
//        {
//            return _id;
//        }
//        set
//        {
//            _id = value;
//        }
//    }
//    public string FirstName
//    {
//        get
//        {
//            return _firstName;
//        }
//        set
//        {
//            _firstName = value;
//        }
//    }
//    public string LastName
//    {
//        get
//        {
//            return _lastName;
//        }
//        set
//        {
//            _lastName = value;
//        }
//    }
//    #endregion
//    #region Methods
//    public string GetFullName()
//    {
//        return this._firstName + " " + this._lastName;
//    }
//    #endregion
//}

////49-Access Modifiers

//public class Customer
//{
//    private int _id;

//    public int ID
//    {
//        get { return _id; }
//        set { _id = value; }
//    }

//    protected int Id;
//}

//public class CorporateCustomer : Customer
//{
//    public void PrintID()
//    {
//        CorporateCustomer CC = new CorporateCustomer();
//        CC.Id = 101;
//        // or we can use base class keyword
//        base.Id = 101;
//        //or we can use this keyword
//        this.Id = 101;
//    }
//}
//public class MainClass
//{
//    private static void Main()
//    {
//        Customer customer = new Customer();
//        Console.WriteLine(customer.Id);//1st customer.ID
//    }
//}

////part-50-Access modifier(assemblies),51- in projects ProjectA.TeamA and ProjectA.TeamB
//public class MainClass
//{
//    public static void Main()
//    {

//    }
//}

////part-52 Attributes, 
//using System.Collections.Generic;
//public class MainClass
//{
//    public static void Main()
//    {
//        Calculator.Add(10, 20);
//        Calculator.Add(new List<int>() { 10, 20, 30 });
//    }
//}

//public class Calculator
//{
//    //[ObsoleteAttribute] same
//    [Obsolete("Use Add(List<int> Numbers) Method",false)]//here we are customize the attribute message to customer by passing as parameter
//    public static int Add(int FirstNumber, int SecondNumber)
//    {
//        return FirstNumber + SecondNumber;
//    }

//    public static int Add(int FirstNumber, int SecondNumber, int ThirdNumber)
//    {
//        return FirstNumber + SecondNumber + ThirdNumber;
//    }
//    //now we need to tell user to use new method how can we do by using attributes so we use obsolete attribte to say the above methods are outdated,it will give waring
//    //if user want add more number like 20 ,30 requriments are changed in future so we are using list
//    public static int Add(List<int> Numbers)
//    {
//        int Sum = 0;
//        foreach(int Number in Numbers)
//        {
//            Sum = Sum + Number;
//        }
//        return Sum;
//    }
//}

////53-Reflection ex in video
//using System.Reflection;
//namespace Pragim
//{
//    public class MainClass
//    {
//        private static void Main()
//        {
//            //Type T = Type.GetType("Pragim.Customer");
//            //or
//            //Type T = typeof(Customer);
//            //or
//            Customer C1 = new Customer();
//            Type T = C1.GetType();
//            Console.WriteLine("Full Name == {0}", T.FullName);
//            Console.WriteLine("Just the Name == {0}", T.Name);
//            Console.WriteLine("Just the Namespace = {0}", T.Namespace);

//            Console.WriteLine();
//            Console.WriteLine("Properties in Customers");
//            PropertyInfo[] properties = T.GetProperties();
//            foreach (PropertyInfo property in properties)
//            {
//                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
//            }

//            Console.WriteLine();
//            Console.WriteLine("Methods in Customers class");
//            MethodInfo[] methods = T.GetMethods();
//            foreach (MethodInfo method in methods)
//            {
//                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
//            }

//            Console.WriteLine();
//            Console.WriteLine("Constructors in Customers class");
//            ConstructorInfo[] constructors = T.GetConstructors();
//            foreach (ConstructorInfo constructor in constructors)
//            {
//                Console.WriteLine(constructor.ToString());
//            }
//        }
//    }
//    public class Customer
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public Customer(int ID, string Name)
//        {
//            this.Id = ID;
//            this.Name = Name;
//        }
//        public Customer()
//        {
//            this.Id = - -1;
//            this.Name = string.Empty;
//        }

//        public void PrintID()
//        {
//            Console.WriteLine("ID = {0}", this.Id);
//        }
//        public void PrintName()
//        {
//            Console.WriteLine("Name e = {0}", this.Name);
//        }
//    }
//}
////all the above data will be in metadata 
///

////part 54- REflection Example
//using System.Windows.Forms;
//using System.Reflection;
//namespace ReflectionDemo
//{ 
//    public partial class Reflection : Form {
//        public Reflection() {
//            InitializeComponent();
//        }
//private void btnDiscoverTypeInformation_Click(object sender, EventArgs e) { 
//            string TypeName = txtTypeName.Text;
//Type T = Type.GetType(TypeName);
//            MethodInfo[] methods = T.GetMethods();
//            foreach (MethodInfo method in methods) {
//                lstMethods.Items.Add(method.ReturnType.Name + " " + method.Name);
//            }
//                PropertyInfo[] properties = T.GetProperties();
//            foreach (PropertyInfo property in properties) {
//                lstMethods.Items.Add(method.ReturnType.Name + " " + method.Name);

//            } incomplete

////part 55-late binding using reflection
//using System.Reflection;
//namespace Pragim
//{
//    public class MainClass
//    {
//        private static void Main()
//        {
//            //Customer C1 = new Customer();
//            //string fullName = C1.GetFullName("Pragim", "Tech");//here if we change method name or parameter chaning type in early binding retun type all these had detected at compile time itself,so the probability of runtime exceptions is very rare ,main thing program won't run only
//            //Console.WriteLine("Full Name = {0}", fullName);
//            //above is called early binding,at compile time we have the information about this customer class we know about that class
//            //so we are creating that instance of that class

//            //late binding
//            Assembly executingAssembly = Assembly.GetExecutingAssembly();

//            Type customerType = executingAssembly.GetType("Pragim.Customer");

//            object customerInstance = Activator.CreateInstance(customerType);

//            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullNames");//if we missspell method and try to invoke it will build or compile but at runtime it will give error.

//            string[] parameters = new string[2];
//            parameters[0] = "Pragim";
//            parameters[1] = "Technologies";

//            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);
//            Console.WriteLine("Full Name = {0}", fullName);

//        }
//    }
//    //late binding 1st we comment thos and after that at runtime we need to uncomment this
//    public class Customer
//    {
//        public string GetFullName(string FirstName, string LastName)
//        {
//            return FirstName + " " + LastName;
//        }
//    }
//}

////part-56 Generics
//public class MainClass
//{
//    private static void Main()
//    {
//        // bool Equal = Calculator.AreEqual(1, 2);
//        //bool Equal = Calculator.AreEqual<string>("A", "B");//specificing the type is string for T
//        bool Equal = Calculator<int>.AreEqual(10,10);//making the class generic
//        if (Equal)
//        {
//            Console.WriteLine("Equal");
//        }
//        else
//        {
//            Console.WriteLine("Not Equal");
//        }
//    }
//}
//public class Calculator<T>//making the class generic
//{
//    // public static bool AreEqual(int Value1, int Value2)//here method is basically now tightly coupled with the data type that it operates on,so how can we do pass any datatype one way by passing object instead int
//    //public static bool AreEqual(object Value1, object Value2)
//    //public static bool AreEqual<T>(T Value1, T Value2)//we are passing T what is T , T can we any anything it could be int,string enum ect
//    public static bool AreEqual(T Value1, T Value2)//making the class generic
//    {
//        return Value1.Equals(Value2);
//    }
//}

////part-57- why should we overrride Tostring()
//namespace Pragim {
//    public class MainClass {
//        private static void Main()
//        {
//            int Number = 10;
//            Console.WriteLine(Number.ToString());

//            Customer C1 = new Customer();
//            C1.FirstName = "Simon";
//            C1.LastName = "Tan";

//            //Console.WriteLine(C1.ToString());//or
//            Console.WriteLine(Convert.ToString(C1));
//        }
//    }
//    public class Customer {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public override string ToString()
//        {
//            //return base.ToString();
//            return this.LastName + "," + this.FirstName;//overrriding Tostring()
//        }
//    }
//}

////part-58
//namespace Pragim
//{
//    public class MainClass
//    {
//        private static void Main()
//        {
//            int i = 10;
//            int j = 10;

//            Console.WriteLine(i == j);
//            Console.WriteLine(i.Equals(j));


//            Direction direction1 = Direction.East;
//            Direction direction2 = Direction.East;
//            Direction direction3 = Direction.West;

//            Console.WriteLine(direction1 == direction2);
//            Console.WriteLine(direction1.Equals(direction2));
//            Console.WriteLine(direction1.Equals(direction3));

//            //however for value type == and Equals() works same

//            //for reference class
//            Customer C1 = new Customer();
//            C1.FirstName = "Simon";
//            C1.LastName = "Tan";

//            //Customer C2 = C1;

//            //now here we are creating new instance(an other new Customer this time) creating another new object 
//            //C1 and C2 are pointing to two diffrent objects together so reference to diffrent object and reference equalty is diffrence i.e == ,but the value is same
//            //if reference equality is true then obviously the value equality will also true ,but on other hand value equality does not granteey reference equality
//            ////remeber when it comes to reference types by default the double equals comparison operator gives us reference equality,Equals() method gives the value equality
//            /// but when we run both gives flase it doesn't makes any sense this is the reason o override the equals method to ensure we get what we expect
//            /// the reason why we get false is that because of the default implementation,default implementation that's coming from base class design now what probably is to
//            /// check for the Equality okay that's when we will override that inherited virtual equals method from system.object

//            Customer C2 = new Customer();
//            C2.FirstName = "Simon";
//            C2.LastName = "Tan";

//            Console.WriteLine(C1 == C2);
//            Console.WriteLine(C1.Equals(C2));

//        }
//    }

//    public enum Direction
//    {
//        East = 1,
//        West = 2,
//        North = 3,
//        South = 4

//    }

//    public class Customer
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }

//        public override bool Equals(object obj)
//        {
//            if (obj == null)
//            {
//                return false;
//            }
//            if (!(obj is Customer))
//            {
//                return false;
//            }

//            return this.FirstName == ((Customer)obj).FirstName &&
//                 this.LastName == ((Customer)obj).LastName;

//        }

//        public override int GetHashCode()//to get ride of waring
//        {
//            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
//        }
//    }
//}

////part-59  diffrence b/w Convert.ToString and ToString()
//namespace Pragim {
//    public class MainClass {
//        private static void Main() {
//            //Customer C1 = new Customer();
//            Customer C1 = null;
//            //string str = C1.ToString(); //ToString() will used to get the string representation of the object
//            //other way to get string representation of the object is
//            string str = Convert.ToString(C1);
//            Console.WriteLine(str);//default output is namespace.classname
//        }
//            }
//    public class Customer
//    {
//        public string Name { get; set; }
//    }
//}

////Part 60-Difference between System.String and System.Text.StringBuilder
//using System.Text;
//namespace Pragim
//{
//    public class MainClass
//    {
//        public static void Main()
//        {
//            //string userString = "C#";
//            //userString += " Video";
//            //userString += " Tutorial";
//            //userString += " for";
//            //userString += " Beginners";
//            //Console.WriteLine(userString);

//            //StringBuilder userString = new StringBuilder("C#");
//            //userString.Append(" Video");
//            //userString.Append(" Tutorial");
//            //userString.Append(" for");
//            //userString.Append(" Beginners");
//            //Console.WriteLine(userString);

//            //string userString = string.Empty;
//            //for (int i = 1; i <= 10000; i++)
//            //{
//            //    userString += i.ToString() + " ";
//            //}
//            //Console.WriteLine(userString);

//            StringBuilder userStringBuilder = new StringBuilder();

//            for (int i = 1; i <= 10000; i++)
//            {
//                userStringBuilder.Append(i.ToString()).Append(" ");
//            }

//            string userString = userStringBuilder.ToString();
//            Console.WriteLine(userString);

//        }
//    }
//}

//part-61 Partial classes in c#
////PART-63 Partial Methods in c#
//namespace PartialMethodsDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            SamplePartialClass SPC = new SamplePartialClass();
//            SPC.PublicMethod();
//        }
//    }
//}

//Part 64,65,66 - How and where are indexers used in .net in AdoDemopart-61

////part-67 optional parameters,Part 68 - Making method parameters optional using method overloading
//using System.Runtime.InteropServices;
//class Program
//{
//    public static void Main()
//    {
//        AddNumbers(10, 20);//for this 3rd parameter is optional because it is params
//        AddNumbers(10, 20, 30, 40, 50);
//        AddNumbers(10, 20, new object[] { 30, 40, 50 });

//        //part-68
//        AddNumbers1(10, 20);
//        AddNumbers1(10, 20, new int[] { 30, 40 });

//        //part-69
//        AddNumbers2(10, 20, new int[] { 30, 40 });
//        //passing named parameter
//        Test(1);
//        Test(1, 2);
//        Test(1, c: 2);

//        //part-70
//        AddNumbers3(10, 20);
//        AddNumbers3(10, 20, new int[] { 30, 40, 50 });
//    }
//    public static void AddNumbers(int firstNumber, int secondNumber, params object[] restOfNumbers)
//    {
//        int result = firstNumber + secondNumber;
//        if (restOfNumbers != null)
//        {
//            foreach (int i in restOfNumbers)
//            {
//                result += i;
//            }
//            Console.WriteLine("Sum = " + result);
//        }
//    }

//    //part-68
//    public static void AddNumbers1(int firstNumber, int secondNumber)
//    {
//        AddNumbers1(firstNumber, secondNumber, null);
//    }
//    public static void AddNumbers1(int firstNumber, int secondNumber, int[] restOfNumbers)
//    {
//        int result = firstNumber + secondNumber;
//        if (restOfNumbers != null)
//        {
//            foreach (int i in restOfNumbers)
//            {
//                result += i;
//            }
//            Console.WriteLine("Sum = " + result);
//        }
//    }

//    //part-69
//    //public static void AddNumbers2(int firstNumber, int[] restOfNumbers = null, int secondNumber)
//    public static void AddNumbers2(int firstNumber, int secondNumber, int[] restOfNumbers = null)//here we are specifing pamameter default as null
//    {
//        int result = firstNumber + secondNumber;
//        if (restOfNumbers != null)
//        {
//            foreach (int i in restOfNumbers)
//            {
//                result += i;
//            }
//            Console.WriteLine("Sum = " + result);
//        }
//    }

//    //passing named parameter
//    public static void Test(int a, int b = 10, int c = 20) {
//        Console.WriteLine("a== " + a);

//        Console.WriteLine("b== " + b);

//        Console.WriteLine("c== " + c);
//    }


//    //part-70 using optionalAttribute
//    public static void AddNumbers3(int firstNumber, int secondNumber, [Optional] int[] restOfNumbers)
//    {
//        int result = firstNumber + secondNumber;
//        if (restOfNumbers != null)
//        {
//            foreach (int i in restOfNumbers)
//            {
//                result += i;
//            }
//        }
//        Console.WriteLine("Sum = " + result.ToString());
//    }
//}

////part-71 code snippets in visual studio
//namespace Demo
//{
//    class Program
//    {
//        public static void Main()
//        {
//            for (int i = 0; i < 10; i++)
//            {

//            }
//            //inabove we are typing the code for for loop so here we can use code snippets for saving typing time
//            for (int j = 0; j < 10; j++)
//            {

//            }

//            for (int i = 0; i < 10; i++)
//            {

//            }
//        }
//    }
//}

////part-72 Dictionary in c# learn about Dictionary object
//using System.Collections.Generic;
//using System.Linq;

//namespace Demo
//{
//    class Program
//    {
//        public static void Main()
//        {
//            Customer customer1 = new Customer()
//            {
//                ID = 101,
//                Name = "Mark",
//                Salary = 4000
//            };
//            Customer customer2 = new Customer
//            {
//                ID = 110,
//                Name = "Pam",
//                Salary = 6500
//            };
//            Customer customer3 = new Customer()
//            {
//                ID = 119,
//                Name = "John",
//                Salary = 6800
//            };

//            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
//            dictionaryCustomers.Add(customer1.ID, customer1);
//            dictionaryCustomers.Add(customer2.ID, customer2);
//            dictionaryCustomers.Add(customer3.ID, customer3);
//            //part-72
//            //dictionaryCustomers.Add(customer1.ID, customer3);
//            //add key values should be unique
//            if (!dictionaryCustomers.ContainsKey(customer1.ID))
//            {
//                dictionaryCustomers.Add(customer1.ID, customer3);
//            }

//            //retriving the non-present key will give runtime exception
//            if (dictionaryCustomers.ContainsKey(135))
//            {
//                Customer cust = dictionaryCustomers[135];
//            }

//            Customer customer119 = dictionaryCustomers[119];
//            //Console.WriteLine("ID  = {0}, Name = {1}, Salary = {2}", customer119.ID, customer119.Name, customer119.Salary);

//            //foreach (KeyValuePair<int, Customer> customerKeyValuePair in dictionaryCustomers)
//            //foreach (var customerKeyValuePair in dictionaryCustomers)
//            //foreach (int key in dictionaryCustomers.Keys)//only getting key values
//            foreach (Customer cust in dictionaryCustomers.Values)
//            {
//                //    Console.WriteLine("Key={0}", customerKeyValuePair.Key);
//                //Customer cust = customerKeyValuePair.Value;
//                //Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
//                //Console.WriteLine("--------------------------------------------------------------------");
//                //Console.WriteLine(key);
//                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
//                Console.WriteLine("--------------------------------------------------------------------");
//            }

//            //part-73
//            //TryGetValue() function-if u not sure dictionary contains a specific key it returns a value associated with the key
//            //and don't want to get exception we use TryGetValue()
//            Customer customer;
//            if (dictionaryCustomers.TryGetValue(100, out customer))
//            {
//                Console.WriteLine("ID = {0}, Name = 11, Salary ={2}", customer.ID, customer.Name, customer.Salary);
//            }
//            else
//            {
//                Console.WriteLine("The key is not found");
//            }

//            //count
//            Console.WriteLine("Total Items = {0}", dictionaryCustomers.Count);//herewe are using count property
//            Console.WriteLine("Total Items = {0}", dictionaryCustomers.Count(kvp => kvp.Value.Salary > 4000));//kvp-key value pair //using count function

//            //remove
//            dictionaryCustomers.Remove(999);//remove one item from dictionary
//            dictionaryCustomers.Clear();//remove all items from dictionary

//            //converting array into dictionary
//            //Customer[] customers = new Customer[3];
//            //customers[0] = customer1;
//            //customers[1] = customer2;
//            //customers[2] = customer3;

//            List<Customer> customers = new List<Customer>();
//            customers.Add(customer1);
//            customers.Add(customer2);
//            customers.Add(customer3);//cpnverting list to dictionary same as array like below

//            Dictionary<int, Customer> dict = customers.ToDictionary(cust => cust.ID, cust => cust);
//            foreach (KeyValuePair<int, Customer> kvp in dict)
//            {
//                Console.WriteLine("Key= {0}", kvp.Key);
//                Customer cust = kvp.Value;
//                Console.WriteLine("ID = {0}, Name = 11, Salary ={2}", cust.ID, cust.Name, cust.Salary);
//            }

//            //Part-74 list collection class
//            //Customer[] customr = new Customer[2];
//            //customr[0] = customer1;
//            //customr[1] = customer2;
//            //customr[2] = customer3;
//            //using List
//            List<Customer> customrs1 = new List<Customer>();
//            customrs1.Add(customer1);
//            customrs1.Add(customer2);
//            customrs1.Add(customer3);
//            //we can insert items at specified position
//            customrs1.Insert(0, customer3);
//            Console.WriteLine("Index of {0}",customrs1.IndexOf(customer3,1,3));//2nd parameter to search start ,3rd parameter is within range from 1st 2 it will check if give 3 it prints 3 as index ,4 runtime exception

//            //Customer c= customrs1[0];
//            //foreach (Customer c in customrs1)
//            for (int i = 0; i <= customrs1.Count - 1; i++)
//            {
//                Customer c = customrs1[i];//for for loop
//                Console.WriteLine("List : ID={0},Name={1},Salary={2}", c.ID, c.Name, c.Salary);
//            }

//            //what do you mean by List classes(generic classes) are strongly type
//            //customrs1.Add(101);// we cannot add an object of a different types
//            //we can add same type and class inherit from it
//            SavingsCustomer sc = new SavingsCustomer();
//            customrs1.Add(sc);

//            //part-75
//            if (customrs1.Contains(customer3))
//            {
//                Console.WriteLine("Customer3 object exists in the list");
//            }
//            else
//            {
//                Console.WriteLine("Customer3 object not exists in the list");
//            }

//            if (customrs1.Exists(cust => cust.Name.StartsWith("P")))//it recives a predicate means lambda expression
//            {
//                Console.WriteLine("Customer3 object exists in the list");
//            }
//            else
//            {
//                Console.WriteLine("Customer3 object not exists in the list");
//            }
//            //find
//            //Customer c1 = customrs1.Find(cust => cust.Salary > 5000);//find 1st matching item
//            //Console.WriteLine("Fined employee name is {0}", c1.Name);
//            //Customer c1 = customrs1.FindLast(cust => cust.Salary > 5000);//find last matching item
//            //Console.WriteLine("Fined employee name is {0}", c1.Name);
//            List<Customer> c1 = customrs1.FindAll(cust => cust.Salary > 5000);
//            foreach(Customer c in c1)
//            {
//                Console.WriteLine("FindAll employee name is {0}", c.Name);
//            }

//            //int index = customrs1.FindIndex(2,cust => cust.Salary > 5000);
//            //Console.WriteLine("Index= " + index);
//            int index = customrs1.FindLastIndex(2, cust => cust.Salary > 5000);
//            Console.WriteLine("Index= " + index);
//        }
//    }
//    public class Customer
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public int Salary { get; set; }
//    }

//    public class SavingsCustomer : Customer
//    {

//    }
//}

////part-76 watch in video only
////part-77 sorting simple list
////numbers.Sort();
////numbers.Reverse();//desecending order
////part-78 sorting complex type
//namespace Demo
//{
//    class Program
//    {
//        public static void Main()
//        {
//            Customer customer1 = new Customer()
//            {
//                ID = 101,
//                Name = "Mark",
//                Salary = 4000
//            };
//            Customer customer2 = new Customer
//            {
//                ID = 110,
//                Name = "Pam",
//                Salary = 7000
//            };
//            Customer customer3 = new Customer()
//            {
//                ID = 119,
//                Name = "John",
//                Salary = 6800
//            };

//            List<Customer> listCustomers = new List<Customer>();
//            listCustomers.Add(customer1);
//            listCustomers.Add(customer2);
//            listCustomers.Add(customer3);

//            Console.WriteLine("before sorting");
//            foreach (Customer c in listCustomers)
//            {
//                Console.WriteLine(c.Salary);
//            }
//            listCustomers.Sort();
//            listCustomers.Reverse();
//            Console.WriteLine("after sorting");
//            foreach (Customer c in listCustomers)
//            {
//                Console.WriteLine(c.Salary);
//            }

//            SortByName sortByName = new SortByName();
//            listCustomers.Sort(sortByName);
//            Console.WriteLine("sorting by name");
//            foreach (Customer c in listCustomers)
//            {
//                Console.WriteLine(c.Name);
//            }

//            //part-79
//            //Comparison<Customer> customerComparer = new Comparison<Customer>(CompareCustomer);

//            Console.WriteLine("Before Sorting");
//            foreach (Customer c in listCustomers)
//            {
//                Console.WriteLine(c.ID);
//            }

//            //listCustomers.Sort(customerComparer);//or
//            listCustomers.Sort(delegate (Customer c1, Customer c2) { return c1.ID.CompareTo(c2.ID); });
//            listCustomers.Sort((x, y) => x.ID.CompareTo(y.ID));//here we are using lambda expressions

//            Console.WriteLine("After Sorting");
//            foreach (Customer c in listCustomers)
//            {
//                Console.WriteLine(c.ID);
//            }


//            //part-80
//            List<Customer> listCustomers80 = new List<Customer>(100);
//            listCustomers80.Add(customer1);
//            listCustomers80.Add(customer2);
//            listCustomers80.Add(customer3);

//            Console.WriteLine("Capacity before trimming= " + listCustomers80.Capacity);
//            listCustomers80.TrimExcess();
//            Console.WriteLine("Capacity after trimming= " + listCustomers80.Capacity);


//            Console.WriteLine("Are all salaries greater than 3000 = " + listCustomers80.TrueForAll(x => x.Salary > 3000));

//            ReadOnlyCollection<Customer> readonlyCustomers = listCustomers80.AsReadOnly();
//            Console.WriteLine("Items= " + readonlyCustomers.Count); //we can only retrive details of item we cannot do add or remove modification
//        }

//        //private static int CompareCustomer(Customer x, Customer y)
//        //{
//        //    return x.ID.CompareTo(y.ID);
//        //}
//    }

//    public class SortByName : IComparer<Customer>
//    {
//        public int Compare(Customer x, Customer y)
//        {
//            return x.Name.CompareTo(y.Name);
//        }
//    }
//    public class Customer : IComparable<Customer>
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public int Salary { get; set; }

//        public int CompareTo(Customer other)
//        {
//            //if (this.Salary > other.Salary)
//            //    return 1;
//            //else if (this.Salary < other.Salary)
//            //    return -1;
//            //else
//            //    return 0;
//            //or because the comparable method is already there for int that is returning above in method 
//            return this.Salary.CompareTo(other.Salary);//we can sort on Name
//        }
//    }
//}


////part-81 when to use Dictionary over list
//using System.Collections.Generic;
//using System.Linq;
//using System.Collections.ObjectModel;
//namespace Demo
//{
//    public class Program
//    {
//        public static void Main()
//        {
//            Country country1 = new Country() { Code = "AUS", Name = "AUSTRALIA", Capital = "Canberra" };
//            Country country2 = new Country() { Code = "IND", Name = "INDIA", Capital = "New Delhi" };
//            Country country3 = new Country() { Code = "USA", Name = "UNITED STATES", Capital = "Washington D.C." };
//            Country country4 = new Country() { Code = "GBR", Name = "UNITED KINGDOM", Capital = "London" };
//            Country country5 = new Country() { Code = "CAN", Name = "CANADA", Capital = "Ottawa" };
//            //using List
//            //    List<Country> listCountries = new List<Country>(); //List will find all items to search for item if we have too many items it will take much time to check untill it find that ite so we go for dictionary //but it comes to dictionary they are very efficient while finding object using keys
//            //    listCountries.Add(country1);
//            //    listCountries.Add(country2);
//            //    listCountries.Add(country3);
//            //    listCountries.Add(country4);
//            //    listCountries.Add(country5);

//            //    string strUserChoice = string.Empty;

//            //    do
//            //    {
//            //        Console.WriteLine("Please enter country code");
//            //        string strCountryCode = Console.ReadLine().ToUpper();
//            //        Country resultCountry = listCountries.Find(country => country.Code == strCountryCode);

//            //        if (resultCountry == null)
//            //        {
//            //            Console.WriteLine("Country code not valid");
//            //        }
//            //        else
//            //        {
//            //            Console.WriteLine("Name = {0}, Capital = {1}", resultCountry.Name, resultCountry.Capital);
//            //        }
//            //        do
//            //        {
//            //            Console.WriteLine("Do you want to continue - YES or NO?");
//            //            strUserChoice = Console.ReadLine().ToUpper();
//            //        } while (strUserChoice != "YES" && strUserChoice != "NO");
//            //    }
//            //    while (strUserChoice == "YES");


//            //using Dictionary
//            Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();
//            dictionaryCountries.Add(country1.Code, country1);
//            dictionaryCountries.Add(country2.Code, country2);
//            dictionaryCountries.Add(country3.Code, country3);
//            dictionaryCountries.Add(country4.Code, country4);
//            dictionaryCountries.Add(country5.Code, country5);

//            string strUserChoice = string.Empty;
//            do
//            {
//                Console.WriteLine("Please enter country code");
//                string strCountryCode = Console.ReadLine().ToUpper();
//                Country resultCountry = dictionaryCountries.ContainsKey(strCountryCode) ? dictionaryCountries[strCountryCode] : null;
//                if (resultCountry == null)
//                {
//                    Console.WriteLine("Country code not valid");
//                }
//                else
//                {
//                    Console.WriteLine("Name = {0}, Capital = {1}", resultCountry.Name, resultCountry.Capital);
//                }
//                do
//                {
//                    Console.WriteLine("Do you want to continue - YES or NO?");
//                    strUserChoice = Console.ReadLine().ToUpper();
//                } while (strUserChoice != "YES" && strUserChoice != "NO");
//            }
//            while (strUserChoice == "YES");
//        }
//    }
//    public class Country
//    {
//        public string Name { get; set; }
//        public string Code { get; set; }
//        public string Capital { get; set; }
//    }
//}


////Part-82 Queue collection class
//namespace Demo
//{
//    public class Program
//    {
//        public static void Main()
//        {
//            Customer customer1 = new Customer()
//            {
//                ID = 101,
//                Name = "Mark",
//                Gender = "Male"
//            };
//            Customer customer2 = new Customer()
//            {
//                ID = 102,
//                Name = "Pam",
//                Gender = "Female"
//            };
//            Customer customer3 = new Customer()
//            {
//                ID = 103,
//                Name = "John",
//                Gender = "Male"
//            };
//            Customer customer4 = new Customer()
//            {
//                ID = 104,
//                Name = "Ken",
//                Gender = "Male"
//            };
//            Customer customer5 = new Customer()
//            {
//                ID = 105,
//                Name = "Valarie",
//                Gender = "Female"
//            };

//            Queue<Customer> queueCustomers = new Queue<Customer>();
//            queueCustomers.Enqueue(customer1);
//            queueCustomers.Enqueue(customer2);
//            queueCustomers.Enqueue(customer3);
//            queueCustomers.Enqueue(customer4);
//            queueCustomers.Enqueue(customer5);

//            //Customer c1 = queueCustomers.Dequeue();
//            //Console.WriteLine(c1.ID + "-" + c1.Name);
//            //Console.WriteLine("Total Items in the Queue = " + queueCustomers.Count);

//            //Customer c2 = queueCustomers.Dequeue();
//            //Console.WriteLine(c2.ID + " - " + c2.Name);
//            //Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

//            //Customer c3 = queueCustomers.Dequeue();
//            //Console.WriteLine(c3.ID + " - " + c3.Name);
//            //Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);
//            //Customer c4 = queueCustomers.Dequeue();
//            //Console.WriteLine(c4.ID + "-" + c4.Name);
//            //Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

//            //Customer c5 = queueCustomers.Dequeue();
//            //Console.WriteLine(c5.ID + " - " + c5.Name);
//            //Console.WriteLine("Items left in the Queue " + queueCustomers.Count);

//            //foreach (Customer c in queueCustomers) //we can do foreach loop to iterate the items but it won't remove the items
//            //{
//            //    Console.WriteLine(c.ID + "-" + c.Name);
//            //    Console.WriteLine("Total Items in the Queue = " + queueCustomers.Count);
//            //}

//            Customer c = queueCustomers.Peek();//peek method return the begining item and won't remove the item like Dequeue
//            Console.WriteLine(c.ID + " - " + c.Name);
//            Console.WriteLine("Total Items in the Queue = " + queueCustomers.Count);

//            Customer c2 = queueCustomers.Peek();//if we use peek method how many time it will return only 1st item because it won't remove item 
//            Console.WriteLine(c2.ID + " - " + c2.Name);
//            Console.WriteLine("Total Items in the Queue = " + queueCustomers.Count);

//            if (queueCustomers.Contains(customer1))
//            {
//                Console.WriteLine("customer1 exists");
//            }
//            else
//            {
//                Console.WriteLine("customer1 doe not exist");
//            }
//        }
//    }

//    public class Customer
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public string Gender { get; set; }
//    }
//}

////Part-82 Generic Stack collection class
//namespace Demo
//{
//    public class Program
//    {
//        public static void Main()
//        {
//            Customer customer1 = new Customer()
//            {
//                ID = 101,
//                Name = "Mark",
//                Gender = "Male"
//            };
//            Customer customer2 = new Customer()
//            {
//                ID = 102,
//                Name = "Pam",
//                Gender = "Female"
//            };
//            Customer customer3 = new Customer()
//            {
//                ID = 103,
//                Name = "John",
//                Gender = "Male"
//            };
//            Customer customer4 = new Customer()
//            {
//                ID = 104,
//                Name = "Ken",
//                Gender = "Male"
//            };
//            Customer customer5 = new Customer()
//            {
//                ID = 105,
//                Name = "Valarie",
//                Gender = "Female"
//            };

//            Stack<Customer> stackCustomers = new Stack<Customer>();
//            stackCustomers.Push(customer1);
//            stackCustomers.Push(customer2);
//            stackCustomers.Push(customer3);
//            stackCustomers.Push(customer4);
//            stackCustomers.Push(customer5);

//            //Customer c1 = stackCustomers.Pop();
//            //Console.WriteLine(c1.ID + " - " + c1.Name);
//            //Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

//            //Customer c2 = stackCustomers.Pop();
//            //Console.WriteLine(c2.ID + " - " + c2.Name);
//            //Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

//            //Customer c3 = stackCustomers.Pop();
//            //Console.WriteLine(c3.ID + " - " + c3.Name);
//            //Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

//            //Customer c4 = stackCustomers.Pop();
//            //Console.WriteLine(c4.ID + " - " + c4.Name);
//            //Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

//            //Customer c5 = stackCustomers.Pop();
//            //Console.WriteLine(c5.ID + " - " + c5.Name);
//            //Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

//            //foreach(Customer c1 in stackCustomers)
//            //{
//            //    Console.WriteLine(c1.ID + " - " + c1.Name);
//            //    Console.WriteLine("Items left in the stack = " + stackCustomers.Count);
//            //}

//            Customer c1 = stackCustomers.Peek();
//            Console.WriteLine(c1.ID + " - " + c1.Name);
//            Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

//            if (stackCustomers.Contains(customer1))
//            {
//                Console.WriteLine("customer1 exists");
//            }
//            else
//            {
//                Console.WriteLine("customer1 doe not exist");
//            }
//        }
//    }

//    public class Customer
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public string Gender { get; set; }
//    }
//}

//part-83,84 are web applications watch in video

//part-86,87,88,89,90,91,92,93,94 in video Multithreading in c#

////part-95 Deadlocks
//public class Account
//{
//    double _balance; int _id;
//    public Account(int id, double balance)
//    {
//        this._id = id; this._balance = balance;
//    }
//    public int ID
//    {
//        get { return _id; }
//    }
//    public void Withdraw(double amount)
//    {
//        _balance -= amount;
//    }
//    public void Deposit(double amount)
//    {
//        _balance += amount;
//    }
//}

//public class AccountManager
//{
//    Account _fromAccount; Account _toAccount; double _amountToTransfer;
//    public AccountManager(Account fromAccount, Account toAccount, double amountToTransfer)
//    {
//        this._fromAccount = fromAccount;
//        this._toAccount = toAccount;
//        this._amountToTransfer = amountToTransfer;
//    }
//    public void Transfer()
//    {
//        Console.WriteLine(Thread.CurrentThread.Name + " trying to acquire lock on " + _fromAccount.ID.ToString());
//        lock (_fromAccount)
//        {
//            Console.WriteLine(Thread.CurrentThread.Name + "acquired lock on " + _fromAccount.ID.ToString());
//            Console.WriteLine(Thread.CurrentThread.Name + " suspended for 1 second");
//            Thread.Sleep(1000);
//            Console.WriteLine(Thread.CurrentThread.Name + "back in action and trying to acquire lock on " + _toAccount.ID.ToString());
//            lock (_toAccount)
//            {
//                Console.WriteLine("This code will not be executed");
//                _fromAccount.Withdraw(_amountToTransfer);
//                _toAccount.Deposit(_amountToTransfer);
//            }
//        }
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Console.WriteLine("Main Started");
//        Account accountA = new Account(101, 5000);
//        Account accountB = new Account(102, 3000);

//        AccountManager accountManagerA = new AccountManager(accountA, accountB, 1000);
//        Thread T1 = new Thread(accountManagerA.Transfer);
//        T1.Name = "T1";

//        AccountManager accountManagerB = new AccountManager(accountB, accountA, 2000);
//        Thread T2 = new Thread(accountManagerB.Transfer);
//        T2.Name = "T2";

//        T1.Start();
//        T2.Start();

//        T1.Join();
//        T2.Join();

//        Console.WriteLine("Main Completed");
//    }
//}


////part-98,99 anonymous methods
//using System.Linq;
//class Program
//{
//    public static void Main()
//    {
//        List<Employee> listEmployees = new List<Employee>()
//        {
//            new Employee { ID = 101, Name = "Mark" },
//            new Employee { ID = 102, Name = "John" },
//            new Employee { ID = 103, Name = "Mary"},
//        };
//        //step 2 we create an instance of Predicate<Employee> delegate and pass the method name as an argument to the delegate constructor
//        //Predicate<Employee> employeePredicate = new Predicate<Employee>(FindEmployee);

//        //step 3 we passed the delegate instance as a parameter to the find method
//        //Employee employee = listEmployees.Find(emp => FindEmployee(emp));
//        //Employee employee = listEmployees.Find(delegate (Employee emp)
//        //{
//        //    return emp.ID == 102;
//        //});
//        //part-99
//        Employee employee = listEmployees.Find((Employee x) => x.ID == 102); // x is applicable only in this scope so we use after this 
//        Console.WriteLine("Id = {0}, Name = {1}", employee.ID, employee.Name);

//        int count = listEmployees.Count(x => x.Name.StartsWith("M"));
//        Console.WriteLine("Count" + count);

//        //part-100 func delegate
//        Func<Employee, string> selector = employeename => "Name = " + employeename.Name;
//        IEnumerable<string> names = listEmployees.Select(selector); //here for list employyes we are invoking the link function select
//        //or we can also use lambda expressions
//        //IEnumerable<string> names = listEmployees.Select(selectoremployeename => "Name = " + employeename.Name //here for list employyes we are invoking the link function select

//        foreach (string name in names)
//        {
//            Console.WriteLine(name);
//        }
//    }

//    //step 1 we created a method/function whose signature matches with the signature of Predicate<Employee> delegate
//    //public static bool FindEmployee(Employee Emp)
//    //{
//    //    return Emp.ID == 102;
//    //}
//    public class Employee
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//    }
//}

//part-101 in project AsyncExample
namespace CSharpProgram
{
    class Program
    {
        // Main function, execution entry point of the program  
        static void Main(string[] args) // string type parameters  
        {
            // Command line arguments  
            Console.WriteLine("Argument length: " + args.Length);
            Console.WriteLine("Supplied Arguments are:");
            foreach (Object obj in args)
            {
                Console.WriteLine(obj);
            }
        }
    }
}













