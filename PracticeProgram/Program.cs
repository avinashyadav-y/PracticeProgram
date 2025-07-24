
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Channels;
using System.Transactions;
using System.Xml;
using System.Xml.Linq;

/*public class Student
{
     string names;
     string addres;
     int rolnum;
     string collage;

    public Student()
    {
        names = "Avinash Yadav";
        addres = "Akluj";
        rolnum = 74;
        collage = "Greenfingers collage Akluj";

        Console.WriteLine($"This is Name of Student :- { names}" );
        Console.WriteLine($"This is The student Address:-{addres}");
        Console.WriteLine($"Student Roll Number :- {rolnum}");
        Console.WriteLine($"Name Of the Collage :-{collage}");
    }
    static void Main(string[] args)
    {
        Student std = new Student();
    }
}
*/

/*
public class Math
{
    int i;
    int j;
    int k;
  

    public Math()
    {
        i = 50;
        j = 60;
        k = i + j;
        Console.WriteLine($"The Addition of two Numbers:-{k}");
    }
   
    static void Main(string[] args)
    {
        Math std = new Math();


    }
}
*/

/*class Program
{
    public class Employee
    {
        string Emp_name;
        int Emp_id;
        string Emp_dept;
        double Emp_salary;

        public Employee()
        {
            Emp_name = "ABCD";
            Emp_id = 77;
            Emp_dept = "Software Development";
            Emp_salary = 25000;

            Console.WriteLine($"This is Employe Name :- {Emp_name}");
            Console.WriteLine($"This is Employe Id Number :- {Emp_id}");
            Console.WriteLine($"This is Employe Department  :- {Emp_dept}");
            Console.WriteLine($"This is Employe Name :- {Emp_salary}");

        }
        static void Main(string[]args)
        {
            Employee emps = new Employee();



        }


    }
}*/


/*class Myclass
{ 
    public class Employee
    {
        string Emp_name;
        int Emp_id;
        string Emp_dept;
        double Emp_salary;

        public Employee(string Emp_name, int Emp_id, string Emp_dept, double Emp_salary)
        {
            this.Emp_name = Emp_name;
            this.Emp_id = Emp_id;
            this.Emp_dept = Emp_dept;
            this.Emp_salary = Emp_salary;
        }

        public string  getname()
        { return this.Emp_name; }

        public int getId()
        { return this.Emp_id; }

        public string  getdept()
        { return this.Emp_dept; }
        public double  getsalary()
        { return this.Emp_salary; }



        static void Main(string[]args)
        {
            Employee obj = new Employee("Avinash", 74, "Computer Science", 50000); 
            Employee obj1 = new Employee("Aditya", 75, "Electronics", 450000);
            Employee obj2 = new Employee("Rohit", 76, "Agriculture", 40000);
            Employee obj3 = new Employee("Suraj", 77, "civil", 350000);
            Employee obj4 = new Employee("Purvajit", 78, "Mechanical", 30000);

            Console.WriteLine("Employee Id:" +obj.getId());
            Console.WriteLine("Employee Name:"+obj.getname());
            Console.WriteLine("Employee Department Name:"+obj.getdept());
            Console.WriteLine("Employee Salary is :"+obj.getsalary());
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("Employee Id:" + obj1.getId());
            Console.WriteLine("Employee Name:" + obj1.getname());
            Console.WriteLine("Employee Department Name:" + obj1.getdept());
            Console.WriteLine("Employee Salary is :" + obj1.getsalary());
            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("Employee Id:" + obj2.getId());
            Console.WriteLine("Employee Name:" + obj2.getname());
            Console.WriteLine("Employee Department Name:" + obj2.getdept());
            Console.WriteLine("Employee Salary is :" + obj2.getsalary());
            Console.WriteLine( "-------------------------------------------------------");

            Console.WriteLine("Employee Id:" + obj3.getId());
            Console.WriteLine("Employee Name:" + obj3.getname());
            Console.WriteLine("Employee Department Name:" + obj3.getdept());
            Console.WriteLine("Employee Salary is :" + obj3.getsalary());
            Console.WriteLine( "--------------------------------------------------------");

            Console.WriteLine("Employee Id:" + obj4.getId());
            Console.WriteLine("Employee Name:" + obj4.getname());
            Console.WriteLine("Employee Department Name:" + obj4.getdept());
            Console.WriteLine("Employee Salary is :" + obj4.getsalary());

            Console.WriteLine( "---------------------END OF EMPLOYEE LIST------------------");
            Console.WriteLine( "                      ----Thank You-----                   ");



        }






    }




}
*/
/*

class Myclass
{
    public class Employee
    {
        public Employee(int id, string Name , double salary, string dept)
        {
             id = 1;
             Name = "Abc";
             salary = 500000;
             dept = "IT";
            Console.WriteLine($"Employee Id is ={id}");
            Console.WriteLine( $"Employee Name is ={Name}");
            Console.WriteLine( $"Employee Salary={salary}");
            Console.WriteLine( $"Employee Department Name{dept}");
        }
        static void Main( string[] args )
        {
            Employee jds = new Employee(0011, "ABC", 50000, "Automation");
        }





    }




}
*/

/*class Myclass
{
    public class Payments
    {
        public void  paymethod_1()
        {
            Console.WriteLine("This Transaction Done by GooglePay ");
        }

        public void paymethod_2()
        {
            Console.WriteLine("This Transaction Done By Phone pay");

        }
        public void paymethod_3()
        {
            int i = 250000;
            int j = 255000;
            Console.WriteLine($"Total Transaction Amount is = {i + j}");

        }

    }
    static void Main(string[] args)
    {
        Payments pyt = new Payments();
        pyt.paymethod_1();
        pyt.paymethod_2();
        pyt.paymethod_3();

    }




}
*/

/*class Myclass
{
    public class Collages
    {
        public void Student(int id, string name)
        {
            Console.WriteLine( $"This is Student Id = {id}" );
            Console.WriteLine($"This is Student name = {name}");
        }
        public void Teacher(string subject, string name, float time )
        {
            Console.WriteLine($"This is Subject of Teacher = {subject}");
            Console.WriteLine($"This is Subject of Teacher = {name}");
            Console.WriteLine( $"Lecture timing ={time } AM");




        }

    }
    static void Main(string[] args)
    {
        Collages gfc = new Collages();
        gfc.Student(11, "Aditya");
        gfc.Teacher("Asp.Net Core Mvc", "Sanjay Sir",9.30f);
    }




}
*/

/*class Program
{
    public class Cars
    {
        public Cars()
        {
            Console.WriteLine("Mahinda, Hyundai, Maruti suzuki, Audi");
            Console.WriteLine( $"This is the collection of cars with Various Brands ;");
        }


        public void Collections()
        {
            Console.WriteLine( "The our specified brands showrooms Available in Your Area");
            Console.WriteLine("Prefered Location 1 : Hadpsar");
            Console.WriteLine("Prefered Location 2 : Wagholi");
            Console.WriteLine("Prefered Location 3 : Hinjewadi");


        }



    }
    static void Main(string[] args)
    {
        Cars smt = new Cars();
        smt.Collections();


    }



}
*/

/*class Myclass
{
    public class Mathsoprations
    {
        public void Addition(int a, int b)
        {
            Console.WriteLine($"The Addition of two Numbers = {a + b}");
        }
        public void Substraction(int a, int b)
        {
            Console.WriteLine($"The Substraction Of two Numbers = {a - b}");

        }
        public void Multiplication(int a, int b)
        {
            Console.WriteLine($"The Multiplication of two Numbers = {a * b}");

        }
        public void Devision(int a, int b)
        {
            Console.WriteLine($"The Devision Of two Numbers = {a / b}");

        }
    }

    static void Main(string[] args)
    {
        Mathsoprations mth = new Mathsoprations();
        mth.Addition(50, 70);
        mth.Substraction(50, 5);
        mth.Multiplication(20, 6);
        mth.Devision(125, 5);

    }



}*/

/*class Myclass
{
    public class Calculate
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    
        
    }
        
    static void Main(string[] args)
    {

        Calculate smt = new Calculate();

        int result = smt.Add(500, 700);

        Console.WriteLine($"Addition of two Numbers =  {result}");
    }

}
*/

/*class Myclass
{
    public class Myfunctions
    {
        public void Empy(int id , string name , double salary, string dept)
        {
            id = 77;
            name = "Employee1";
            salary = 250000;
            dept = "Information Technology";

            Console.WriteLine( $"This The Employe id = {id}");
            Console.WriteLine($"This The Employe  Name = {name }");
            Console.WriteLine($"This The Employe salary = {salary }");
            Console.WriteLine($"This The Employe Department = {dept }");

            

        }
        static void Main(string[] args)
        {
            Myfunctions smt = new Myfunctions();
            smt.Empy(77, "abc", 55, "IT");
            

        }

    }


}
*/
/*
class Myclass
{
    public class student
    {
        public void Marks(float mark,string subject,int div)
        {
            Console.WriteLine( $"The Mark student obtained {mark},Subject name {subject}, devision is {div}");

        }
        

    }
    static void Main(string[]args)
    {
        student std = new student();
        std.Marks(45.12f, "english", 5);


    }





}
*/
/*
class Myclass
{
    public class Methods
    {

        public Methods()
        {
            Console.WriteLine( "The constructor is called Automatically ");
            Console.WriteLine( "constructor Name is same as Class Name ");


        }
        public void show ()
        {
            Console.WriteLine("This is student List ");
                        
        }
        public string display( string str1,string str2,string str3)
        {
            return str1 + "  " + str2 + "  " + str3 + "  ";
            


        }
        public int Add(int a ,int b )
        {
            return a + b;

        }
        
              

    }
    static void Main(string[] args)
    {
       Methods mtd = new Methods();
        mtd.show();
        

        string str = mtd.display("Avinash","Aditya","Atharv");
        Console.WriteLine( str );

      int ins= mtd.Add(500, 200);
       Console.WriteLine( ins);
                        
        
    }


}
*/

/*
class Program
{
    public string show()
    {
        int i = 12;
        string str = Convert.ToString(i);
        return str; 

    }
    public string display()
    {
        int num = 50;
        string str = Convert.ToString(num);
        return str;

    }

    static void Main(string[] args)
    {
        Program pgr = new Program();
        string s= pgr.show();
        Console.WriteLine( s);

        string sa = pgr.display();
        Console.WriteLine( sa);
       

    }
     


}*/
/*


class Myclass
{
    public class Overload
    {
        public Overload()
        {
            Console.WriteLine("This is Parameter less constructor is callled");


        }
        public Overload(int a,int b)
        {

            Console.WriteLine( "This is overloaded construction ",(a+b ));


        }
         public Overload(int a, int b, int c)
        {
            Console.WriteLine( "This is The Thired consturctor overloaded",(a+b+c ));


        }
        static void Main(string[]args)
        {
            Overload ovd = new Overload(10,20,30);
            Overload ovds = new Overload();
            Overload ovdsp = new Overload(50,50);


        }


    }



}
*/


/*namespace CodeLab
{
    class Program
{
    static void Main(string[] args)
    {

        Student.Print();
        Student.Display();
        Student.Details();


    }
    public static class Student
    {
        public static void Print()
        {
            Console.WriteLine("Static method Print");
        }
        public static void Display()
        {
            Console.WriteLine("Static method Display");
        }
        public static void Details()
        {
            Console.WriteLine("Static method Details");
        }
    }


}

}
*/
/*

namespace CodeLab
{
    class Program
    {
        static void Main(string[] args)
        {

            Student.Print();
            Student.Display();
            Student.Details();



        }
        public static class Student
        {
            public static void Print()
            {
                Console.WriteLine("Static method Print");
            }
            public static void Display()
            {
                Console.WriteLine("Static method Display");
            }
            public static void Details()
            {
                Console.WriteLine("Static method Details");
            }
        }


    }

}
*/


/*namespace CodeLab
{
    class Program
    {
        static void Main(string[] args)
        {

            Student.Print();
        }
        public static class Student
        {
            public static int x;

            static Student()
            {
                x = 90;

            }
            public static void Print()
            {
                Console.WriteLine(x);
            }
        }



    }

}
*/

/*
namespace CodeLab
{
    class Myclass
    {
        static void Main(string[] args)    // static method is called when  (class_name.metdhod_name)
        {
            Math.Sum(200, 300);
            Math.Multiplication(1,2);
            Math.Devision(5, 6);

        }
        public static class Math            // static class created 
        {
            public static int a;
            public static int b;

            public static void Sum(int a, int b)   // static method initialized
            {
                a = 500;
                b = 400;

                Console.WriteLine($"Addition of a and b is {a + b}");
            }
            public static void Multiplication(int a, int b)
            {
                a = 50;
                b = 77;
                Console.WriteLine($"Multiplication of a and b is {a*b}");


            }
            public static void Devision(int a , int b)
            {
                a = 95;
                b = 5;
                Console.WriteLine( $"Devision of a and b is {a/b }");

            }
        }


    }
}
*/


/*
class Myclass
{
    public static class Student
    {
        public static int id;
        public static string name;
        public static int age;
        public static string address;
        static Student ()
        {
            id = 77;
            name = "Avinash";
            age = 21;
            address = "Akluj";

        }
        public static void show()
        {
            Console.WriteLine($" Student id Number is = {id}");
            Console.WriteLine($"Name of the student = {name}" );
            Console.WriteLine( $"Student Age = {age}");
            Console.WriteLine( $"Student Residential Adress = {address }");


        }
        public static void Display()
        {

            Console.WriteLine( "Studenr Information Are Above Mentioned");

        }
        static void Main(string[]args)
        {
            Student.show();
            Student.Display();
        }


    }




}*/

/* //This is Example of static class with static method
class Myclass
{
    public static class vechicles
    {
       public static  string bikes;
       public static  int    bike_Price;

        public static string cars;
        public static int   cars_price;

        static vechicles()
        {
            bikes = "shine,Unicorn,Pluser";
            bike_Price = 100000;

            cars = "Scorpio";
            cars_price = 1700000;


        }
        public static void show()
        {
            Console.WriteLine( $"Bikes = {bikes }");
            Console.WriteLine( $"Bike Prices = {bike_Price }");

            
        }
        public static void display()
        {
            Console.WriteLine($" Car Name = {cars}");
            Console.WriteLine($"Car Price = {cars_price}");



        }
        


    }
    static void Main(string[]args)
    {
        vechicles.show();
        vechicles.display();

    }


}
*/
/*
 // This is example of static method 

class Myclass
{
    public class Employee
    {
        public static  int id;
        public static  string name;
         static Employee()
        {
            id = 7799;
            name = "Employee Name";
            Console.WriteLine( $"This is the static method called {id},{name }");
        
        
        
        }
        public void display()
        {
            Console.WriteLine( "ID number  of the employee ");


        }


    }
    static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp.display();





    }

}



*/

//This is static constructor Example
/*
class Program
{
    public class Myclass
    {
        public Myclass()
        {
            Console.WriteLine( "This is Public constructor called ");
            
        }


    }
    
    public class Singletone
    {
        private Singletone()
        {
            Console.WriteLine( "This is the private Constructor called ");


        }
        static void Main(string[] args)
        {
            Singletone smp = new Singletone();
            Myclass obj = new Myclass();


        }


    }
   

}
*/


//Inheritance
/*

class Program
{
    public class Animal
    {
        public void show()
        {
            Console.WriteLine( "This is base class Called");
        }


    }
    public class Dog : Animal
    {
        public void Display()
        {

            Console.WriteLine( "This is Derived class called ");

        }
     
    }
    public class Cat: Dog  
    {

        public void shows()
        {
            Console.WriteLine( "This is Multilevel Inheritance is called ");

        }
    }
    static void Main(string[]args )
    {
        Dog dg = new Dog();
        dg.Display();
        dg.show();
        Cat ct = new Cat();
        ct.shows();
        

    }


}

*/
/*
 // This is the Example of single inheritance
class Program
{

    static void Main(string[] args)
    {

        Lab lb = new Lab();

        lb.Sub(12, 34);
        lb.Add(55, 44);
        lb.Div(90, 45);
        lb.Multi(12, 56);

    }
    public class Math
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }

    }
    public class Lab : Math
    {

        public void Multi(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
    }
}

*/

// This is the Example of Multilevel inheritance
/*
class Program
{
    public class A
    {
        public void Display()
        { 
            Console.WriteLine("This is A Parent class Called" );
             
        }

    }
    public class B : A
    {
        public void Show()
        {
            Console.WriteLine( "This is B chiled Class Called ");
        }
    }
    public class C:B
    {
        public void Details()
        {
            Console.WriteLine("This is C class called ");
        }
    }
    static void Main(string[] args)
    {
        C c = new C ();
        c.Display();
        c.Show();
        c.Details();
    }

}
*/




/*
// This is Hierachical Inheritance 

class Program
{
    public class A
    {
        public void Teach()
        {
            Console.WriteLine( "This is base class  ");

        }
     
    }
    public class B : A
    { 
        public void Details()
        {
            Console.WriteLine( "This is Firest Derived class  ");
        }
    
    
    }
    public class C : A
    {
        public void show()
        {
            Console.WriteLine( "This is second derived class ");
        }
      

    }
    static void Main(string[]args)
    {
        B b = new B();
        b.Teach();
        b.Details();
        C c = new C();
        c.show();

    }



}

/*

interface A
{
    public void Add();
}
interface B
{
    public void Multi();

}
class C : A, B
{
    public void Add()
    {
        int a = 50;
        int b = 27;
        Console.WriteLine( a+b );
    }
    public void Multi()
    {
        int a = 20;
        int b = 06;
        Console.WriteLine( a-b );

    }
    static void Main(string[]args)
    {
        C c = new C ();
        c.Add();
        c.Multi();
        Console.WriteLine( "Interface Implimanted to  Access multiple methods in one single class");

    }
}

*/
/*

class Myclass
{
    static void Main(string[] args)
    {
        Console.WriteLine( "Enter A number to check Armstrong or Not ");
        int numbers = Convert .ToInt32(Console.ReadLine());
        int rem;
        int cube;
        int result=0;
        int aviholds = numbers;

        while (numbers != 0)
        {
            rem = numbers % 10;
            cube = rem * rem * rem;
            result = result + cube;
            numbers = numbers / 10;

        }
        numbers = aviholds ;
        if(numbers == result )
        {
            Console.WriteLine( "This is Armstrong Number ");


        }
        else
        {

            Console.WriteLine( "This is Not Armstrong number ");
        }




    }


}*/
/*
interface ICollage
{
    void show();

    void Show1();

}

public class Univercity : ICollage
{
    public void show()
    {
        Console.WriteLine( "This is Collage of Computer and Technology");
    }

    public void Show1()
    {
        Console.WriteLine( "Available cources:- Bsc , BCA , ");
    }
    static void Main(string[] args)
    {
        Univercity us = new Univercity();
        us .show ();
        us .Show1();

    }
}*/


/*
interface IMaths
{
    void Add(int x, int y);

    void Mul(int x, int y); 
    
    int  div(int x,int y);

}
public class Oprate : IMaths
{
    public void Add(int x, int y)
    {
        Console.WriteLine( x+y);
        
    }

    public void Mul(int x, int y)
    {
        Console.WriteLine( x*y);
    }
    public int   div(int x, int y)
    {
        int d ;
        d=x/y;
        return d;
       
            
    }

   
    static void Main(string[] args)
    {
        Oprate oprate = new Oprate();
        oprate.Mul(10, 50);
        oprate.Add (40, 66);
        int i=oprate.div(68,55);
        Console.WriteLine( i);
    }   
}
*/
/*

namespace CodLab
{
    class Program
    {
        interface IStudent1
        {

            void Information();

            void Results();

        }
        interface IStudent2
        {
            void Info(string sub , int mark );

            void Result(string grade );

        }

        public class Myclass : IStudent1, IStudent2
        {


            public void Information()
            {
                Console.WriteLine("There is student information :- ");
                Console.WriteLine("Student Name :ABC ");
            }
            public void Results()
            {
                Console.WriteLine("Result status is :- Pass A+ ");

            }


            public void Info(string sub,int mark)
            {
                Console.WriteLine("This student Na ");
            }
            public void Result(string grade )
            {
                Console.WriteLine("Result status  is :- ");

            }


        }
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass();
            myclass .Information();
            myclass .Results();
            myclass.Info("English", 80);
            myclass .Result("F");

        }


    }
}
*/
// Default Implimentation
/*
class Myclass
{
    interface IStudent
    {
        void show();
    }
    interface ITeacher
    {
        public void show1()
        {
            Console.WriteLine( "This is the Teacher Name : Salunkhe Sir "); 
        }
    }
    class Collage : IStudent, ITeacher
    {
        public void show()
        {
            Console.WriteLine( "The student Name is Avinash ");
        }
    }
    static void Main(string[] args)
    {
        Collage clg=new Collage();
        clg.show();
        ITeacher cg = new Collage();
        cg.show1();

    }
}

*/

/*
class Myclass
{
    interface IStudent
    {
        public void Display(string stud)
        {
            Console.WriteLine( $"This is student Name :- {stud } ");
        }
    }
    interface ITeacher
    {
        void show(string msg);
    }
    class Collage : IStudent, ITeacher
    {
        public void show(string msg)
        {
            Console.WriteLine( $"This is Teacher Name :- {msg}");
        }
    }
    static void Main(string[] args)
    {
        Collage clg = new Collage();
        clg.show("Salunkhe sir");
        
        IStudent std = new Collage();
        std.Display("Avinash and Tejas");
    }

}*/


// interface 
/*
class Program
{
    interface IA
    {
        void add();
        
    }
    interface IB
    {
        void add ();
       
    }
    class Myclass : IA, IB
    {
         void IA.add()
        {
            int a = 400;
            int b = 200;
            int sum=a+b;
            Console.WriteLine( sum );
        }

        
        void IB.add()
        {

            Console.WriteLine( "This is simple Method ");
            
        }
    }
    static void Main (string[] args)
    {
       IA  ms = new Myclass();
        ms.add();
       
        IB mt = new Myclass();
        mt.add();
        

    }

}*/


// Abstarct class with abstract method implimentation
/*
class Program
{
    public abstract class Student
    {


        public int Rollnum = 77;
        public int fees = 40000;

       
        public abstract void Print();     

        public virtual void show()                
        {
            Console.WriteLine( "Non Abstarct Method inside abstract class");
        }


        public class Teacher : Student
        {
            public override void Print()
            {
                Console.WriteLine($"This is student Roll Number {Rollnum}");
                Console.WriteLine( $"Student School feese {fees }");
            }
        }
        static void Main(string[] args)
        {
            Teacher td = new Teacher();
            td.Print();
            td.show ();
        }


    }

}
*/


//This is Program can use of Base keyword
/*
class Program
{

    public class Student
    {
        public  virtual void School_Name()
        {
            Console.WriteLine("Greenfingers School");
        }


    }
    public class Teacher : Student
    {
        public override void School_Name()
        {
            base.School_Name();
        }


    }
    static void Main(string[] args)
    {
        Teacher ts = new Teacher();
        ts.School_Name();
    }

}*/


//Abstarct class with abstarct and Non abstarct methods
/*
class Program
{
    public abstract class Zoo
    {
        public virtual void Animalcount()
        {
            Console.WriteLine( "This is the total count of Animals in zoo More than 1000");

        }

        public virtual void FeedsPack()
        {
            Console.WriteLine( "The Total feeds pack in Storage More than 250 packs ");
        }
        public abstract void Catcount();
        public abstract void horses();
       
    }
    public class Dog : Zoo
    {
        public override void Animalcount()
        {
            Console.WriteLine( "Animal count is More than 1000");
        }
        public override void Catcount()
        {
            Console.WriteLine( "There is Cat count is Less than 500 ");
        }
        public override void horses()
        {
            Console.WriteLine( "The horse total count is 58");
        }
    }
    static void Main(string[] args)
    {
       Dog dog = new Dog();
        dog.Animalcount();
        dog.Catcount();
        dog.horses();
        dog.FeedsPack();
    }
}

*/
       
class Myclass
{
    public abstract class Add
    {
        public abstract  int sum(int i, int j);

        public virtual void Print()
        {
            Console.WriteLine("This is non abstract virtual method");
        }
    }

    
    public class MathsOP : Add
    {
        public override int sum(int i, int j)
        {
            i = 50;
            j = 50;
            return i + j;
        }
        public override void Print()
        {
            base.Print();
        }
    }
    static void Main(string[] args)
    {
        MathsOP mt = new MathsOP();
        int i=mt.sum(50,50);
        Console.WriteLine( i);

        mt.Print();
        
    }
}

















/*
class Program
{

    abstract class Person
    {
        public string FirestName;
        public string LastName;
        public int age;
        public long PhoneNumber;
        public abstract void Printdetails();

    }
    class Student : Person
    {
        public int rollnum;
        public int feese;


        public override void Printdetails()
        {
            string name = this.FirestName + "  " + this.LastName;
            Console.WriteLine($"Student Firest name is {name}");
            Console.WriteLine("Student age is {0}", this.age);
            Console.WriteLine("Student Phone number is {0}", this.PhoneNumber);
            Console.WriteLine("Student Roll number is {0}", this.rollnum);
            Console.WriteLine("Student feese is {0}", this.feese);

        }




    }
    class Teacher : Person
    {
        public string qualification;
        public int salary;

        public override void Printdetails()
        {
            string name = this.FirestName + "  " + this.LastName;
            Console.WriteLine($"Teacher Firest name is {name}");
            Console.WriteLine("Teacher age is {0}", this.age);
            Console.WriteLine("Teacher Phone number is {0}", this.PhoneNumber);
            Console.WriteLine("Teacher Qualification is {0}", this.qualification);
            Console.WriteLine("Teacher salary is {0}", this.salary);

        }

    }
    static void Main(string[] args)
    {
        Console.WriteLine("This is The Student details ");
        Student avi = new Student();
        avi.FirestName = "Avinash ";
        avi.LastName = "Yadav";
        avi.age = 21;
        avi.PhoneNumber = 7620114166;
        avi.rollnum = 75;
        avi.feese = 40;
        avi.Printdetails();

        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.WriteLine("This is Teachers Details showed");
        Teacher san = new Teacher();
        san.FirestName = "Sanjay Sir";
        san.LastName = "salunkhe";
        san.age = 43;
        san.PhoneNumber = 9975163113;
        san.qualification = "MCA SET ";
        san.salary = 50000;


        san.Printdetails();


    }









}*/














































