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
/*      
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
}*/
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


// 
/*
class Program
{
    public class Person
    {
        public void PersonDetails()
        {
            string name = "Avinash Yadav";
            Console.WriteLine($"The person Name is {name}");

            int age = 21;
            Console.WriteLine( $"Person Age is {age} Years");
                

        }

    }
    public class Student:Person 
    {
        public void StudRoll()
        {
            int Rollnum = 77;
            Console.WriteLine( $"Student Roll Number is {Rollnum}");

        }

    }
    static void Main( string[] args)
    {
        Student stds= new Student();
        stds.PersonDetails ();
        stds .StudRoll();
    }
    


}

*/

/*
class Program
{
    public class Employee
    {
        public string Name;
        public long Salary;
        public Employee(string name, long salary)
        {
            Name = name;
            Salary = salary;
        }

        public virtual void EmpDetails()
        {
            Console.WriteLine( "This is Employe Details ");
        }


    }
    public class Manager : Employee
    {
        public string Department;
        public Manager(string name, long salary, string department) : base(name, salary)
        {
            Department = department;
        }
        public void Display()
        {
            Console.WriteLine($"Employe Name :{Name}" );
            Console.WriteLine( $"Employe salary:{Salary }" );
            Console.WriteLine($"Department : {Department }" );

            
        }
        public override void EmpDetails()
        {
            base.EmpDetails();
        }
    }
    static void Main( string[] args)
    {
        Manager mgrs = new Manager("Alice", 60000, "HR");
        mgrs.EmpDetails();
        mgrs.Display();

    }


}
*/

/*
class Program
{
    public class Animal
    {
        public void Display()
        {
            Console.WriteLine( "I am An Animal ");
        }
    }
    public class Mammal:Animal
    {
        public void Show()
        {
            Console.WriteLine( "I am Mammal");
        }
    }
    public class Dog: Mammal
    {
        public void ShowInfo()
        {
            Console.WriteLine( "I am a Dog ");
        }

    }
    static void Main(string[] args)
    {
        Dog dg = new Dog();
        dg .Display ();
        dg .Show ();
        dg .ShowInfo ();

    }
    

    
}
*/



/*
class Program
{
    abstract class Shape
    {
        public abstract double  Area();

    }
    class Circle:Shape
    {
        public double Radius;

        public Circle (double radius)
        {
            Radius = radius;
        }

        public override double  Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
    class Square : Shape
    {

        public double Side;

        public Square (double side)
        {
            Side = side;
        }
        public override double Area()
        {
            return Side * Side;
        }
    }
    static void Main(string[] args)
    {
        Circle cs = new Circle(10);
        Square sqr = new Square(10);
        Console.WriteLine("Area of Circle" + cs.Area());
        Console.WriteLine( "Area of Square "+ sqr .Area ());
        
    }
}
*/

/*

class Account
{
    public int AccountNumber;
    public double Balance;

   
    public Account(int accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }
}

class SavingsAccount : Account
{
    public double InterestRate;

    // Constructor of SavingsAccount using base
    public SavingsAccount(int accountNumber, double balance, double interestRate)
        : base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }

    // Method to calculate interest
    public double CalculateInterest()
    {
        return Balance * InterestRate / 100;
    }

    public void Display()
    {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Balance: " + Balance);
        Console.WriteLine("Interest: " + CalculateInterest());
    }
}

class Program
{
    static void Main(string [] args)
    {
        SavingsAccount acc = new SavingsAccount(123456, 10000, 5);
        acc.Display();
    }
}*/
/*
 * 
 * Method Overloading Example
 
class Program
{
    public class Student
    {
        public void Show(int roll)
        {
            Console.WriteLine( $"This is Student roll number {roll}");
        }
        public void Show(string name, long fees )
        {
                      
            Console.WriteLine( $"This is Student name : {name }");
            Console.WriteLine($"Feese : {fees }");

        }
        public void Show(string dist, string village)
        {
            Console.WriteLine( $"village : { village}" );
            Console.WriteLine( $"District: {dist }" );
        }
        

    }
    static void Main(string[] args)
    {
        Student  cg =  new Student ();
        cg.Show(77);
        cg.Show("Avinash", 50000);
        cg.Show("Solapur", "Akluj");
    }
}
*/


/*
class Program
{
    public class Employee
    {
        public virtual void Details()
        {
            String Name = "Employee1";
            int age = 25;
            Console.WriteLine($"Employee Name: {Name }" );
            Console.WriteLine( $"Employee Age: {age }");

        }
    }
    public class Manager:Employee
    {
        public override void Details()
        {
            string ManagerName = "Manager1";
            string Department = "IT";

            Console.WriteLine($"Manager Name: {ManagerName}");
            Console.WriteLine($"DepartMent :{Department}");
        }   

    }
    static void Main( string[] args)
    {
        Employee emp = new Manager();
        emp .Details();

    }

}
*/
/*
namespace codeLab
{
    class Program
    {

        public abstract class Car
        {

            public abstract void CarName();

            public abstract void Remote();
            public abstract void Engine();

            public void greet()
            {
                Console.WriteLine( "Thank You ");
            }
                      
                                                
        }
        public class Car_Details : Car
        {
            public override void CarName()
            {
                Console.WriteLine( "Mahindra Scorpio ");
            }

            public override void Engine()
            {
                Console.WriteLine( "This is 2500cc Mhoak Enginee");
                Console.WriteLine( "This Powerfull Engine Can generate 900 nm Torque");
            }

            public override void Remote()
            {
                Console.WriteLine( "Remote is On=> Engine is started ");
              
            }
            static void Main(string[] args)
            {
                Car cr = new Car_Details();
                cr.CarName ();
                cr.Remote ();
                cr.Engine();
                cr.greet ();
            }

        }


  /*
class Program
{
    static void Main(string[] args)
    {
        IBank bank = new Bank();

        bank.BankName();
        bank.Account_Number();
        bank.Account_Bal();

    }
}
interface IBank
{
    void Account_Bal();
    void Account_Number();

    void BankName()
    {
        Console.WriteLine("HDFC");
    }
}
public class Bank : IBank
{
    public void Account_Bal()
    {
        Console.WriteLine("1200000");
    }

    public void Account_Number()
    {
        Console.WriteLine("8767390012");
    }


}

*/

// This is an Example of Encapsulation => Hiding a data
// prevention of data to Accesss every where we can use Easily or modified it 


/*
class Program
{
    public class BankAccount
    {
        private int Bal = 10000;

        public void Deposit(int DepositAmount)
        {
            Bal += DepositAmount;
        }
        public void Withdraw(int WithdrawAmount)
        {
            Bal -= WithdrawAmount;
        }
        public int GetBal()
        { return Bal; }
    }
    static void Main(string[] args)
    {
        BankAccount bank = new BankAccount();
        bank.Deposit(50000);
        bank.Withdraw(30000);
        int i= bank.GetBal();
        Console.WriteLine($"The Remaining Account Balance is {i}");



    }
}

*/
/*

class Myclass
{
    public class Student
    {
        private int Fees = 40000;

        public void Feese(int feesPaid)
        {
            Fees += feesPaid;

        }
        public void RetFeese(int feesReturn)
        {
            Fees -= feesReturn;
        }
        public int getFeese()
        {
            return Fees;
        }

    }
    static void Main(string[] args)
    {
        Student student = new Student();
        student.Feese(50000);
        student.RetFeese(25000);

        int i = student.getFeese();
        Console.WriteLine($"Total Feese Paid By Student:- {i}");
    }


}*/

/*
class Program
{
    static void Main()
    {
        Information information = new Information();

        string s = information.Name;

        Console.WriteLine(s);
    }

    public class Information
    {
        private string Password = "abc123";

        public String Name
        {
            get { return Password; }//For read and Return

            set { Password = value; }// set for Field value

        }
    }

}*/
/*
class Program
{
    public class BankAccount
    {
        private decimal bal;

        public decimal Bal
        {

            get { return bal; }

            set { bal = value; }

        }

        public void  Deposite(decimal amount)
        {

            Bal = Bal + amount;
            Console.WriteLine(amount);
        }
        public void Withdraw(decimal amount)
        {
            bal = bal - amount;
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();
        account.Deposite(5000);
        account.Withdraw(2000);
        Console.WriteLine($"The Remaining Balance is {account.Bal}");
    } 
}
*/
/*

public class Student
{
    private string username;

    private string password;

    private int Age;

    public  string Username
    {
        get { return username; }
        set { username = value; }
    }
    public string Password
    {
        get { return password; }
                
        set
        {
            if (value.Length > 5 )
            {
                password = value;
            }
            else
            {
                Console.WriteLine("password must be greater than 5 character ");
            }

        }


    }
    public int Age1
    {
        get { return Age; }

        set { 
            if (value>18)
            {
                Age = value;
            }
            else
            {
                Console.WriteLine("Age must be greater than 18");
            }

        }
           
        
    }
    public void Display()
    {
        Console.WriteLine($"Username: {Username}");
        Console.WriteLine($"Password: {Password}");
        Console.WriteLine( $"Age{ Age}");
    }
    static void Main(string[] args)
    {
        Student student = new Student();
        student.Username = "Avinash";
        student.Password = "123456";
        student.Age1 = 21;
        student.Display();
    }
}
*/
/*
public class Person
{
    private string name;
    private int age;
    private string address;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }

    }
    public string Address { get { return address ; }
        set { address = value; }
    }

    static void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "Avinash Yadav";
        person.Age = 21;
        person.Address = "Akluj, Solapur";
        Console.WriteLine($"Person Name  is {person.Name}");
        Console.WriteLine($"Person Age  is {person.Age}");
        Console.WriteLine($"Person address is {person.address }");


    }
}*/

// =>--------------------Exception Handling Example --------------------------------------<=
/*
 * 
 * 
class Program
{


    static void Main(string[] args)
    {

        Student s = new Student();

        s.Info();

    }
    public class Student
    {
        public void Info()
        {
            try
            {
                int num1 = 10;
                int num2 = 0;


                Console.WriteLine(num1 / num2); // error


            }

            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine(ex.Message);

                Console.WriteLine("Child class");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                Console.WriteLine("base class");
            }

        }


    }


}*/
/*
class Program
{
   
    public class Student
    {
        public void Info()
        {

            try
            {
                int[] num = { 1, 2, 3, 4 };

                Console.WriteLine(num[6]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Child class");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Base class");
            }


        }


    }
    static void Main(string[] args)
    {

        Student s = new Student();

        s.Info();

    }
}
*/
/*
class Program
{
    static void Main(string[] args)
    {
        try
        {
           string addres = "Akluj";
            Console.WriteLine( addres );

            string name = null ;
            Console.WriteLine( name.Length );


        }
        catch (NullReferenceException   ex)
        {

            Console.WriteLine(ex.Message );
        }
       
        finally
        {
            Console.WriteLine("This is finally block");
        }
        Program program = new Program();


    }
}*/


// creating Example of single cast Delegate
/*
namespace MyCode
{
    public delegate void MyDelegate();
    class Myclass
    {
        public void show()
        {
            Console.WriteLine( "This is show Method called ");
        }

        public void Display()
        {
            Console.WriteLine( "This is Display Method Called in Delegate ");
        }

        public static void Details()
        {
            Console.WriteLine( "This is the static method call using class name.Method name ");
        }
        static void Main(string[] args)
        {
            Myclass std = new Myclass();

            MyDelegate Del = new MyDelegate (std.show );
            MyDelegate Del2 = new MyDelegate(std.Display);
            MyDelegate del3 = new MyDelegate (Myclass.Details);

            Del();
            Del2();
            del3(); 
            Console.WriteLine("This is the Example of Delegate");

        }

    }
}
*/
/*
public delegate void del(int x, int y);

class Program
{

    static void Main(string[] args)
    {
        Student std = new Student();

        del d = new del(std.Add);
        del d2 = new del(std.Sub);

        d(4, 6);
        d2(10, 5);

    }

}
public class Student
{
    public void Add(int x, int y)
    {
        int z = x + y;

        Console.WriteLine(z);

    }
    public void Sub(int a, int b)
    {
        Console.WriteLine(a - b);
    }
}
*/
/*
class Program
{
    internal delegate void Del();

    static void Main(string[] args)
    {
        Math mt = new Math();

        Del d = new Del(mt.Print);

        d();

    }

}
public class Math
{
    public void Print()
    {
        Console.WriteLine("Math oprations");
    }
}
*/

/*
namespace Mathcode
{
    public delegate void del(int i, int j);
    
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();

            del d = new del(std.English_Mark);

            del d2 = new del(std.Math_Mark);

            del d3 =  d + d2; // Multicast Delegate




        }
    }

    public class Student
    {

        public void Math_Mark(int x, int y)
        {
            int i = x + y;
            Console.WriteLine(i);
        }
        public void English_Mark(int a, int b)
        {
            int j = a + b;
            Console.WriteLine(j);
        }

    }

}
*/
/*
class Program
{
    public delegate void Mydel();

    public class  Student
    {
        public void Student_Details()
        {
            Console.WriteLine("Name :- ABC ");
            Console.WriteLine( "Student ID :- 779920062004");
            Console.WriteLine( "Cource Name:- Bachlores in computer science ");
            Console.WriteLine( "Year : TY 2025 ");
        }
        public void Colege_Details()
        {
            Console.WriteLine("College Name : Greenfingers Collage ");
            Console.WriteLine("Collage ID : 123456789");
            Console.WriteLine("Collage Address : Akluj, Solapur");
        }

        public void Student_Marks()
        {
            Console.WriteLine("Marks in Advanced Python : 80");
            Console.WriteLine("Marks in React Redux     : 75");
            Console.WriteLine("Marks in Asp.Net Core : 90");
        }
        static void Main(string[] args)
        {
            Student std = new Student();

            Mydel md = new Mydel(std.Colege_Details);
            Mydel md2 = new Mydel(std.Student_Details);
            Mydel md3= new Mydel (std.Student_Marks);

            md();
            md2();
            md3();

        }

    }
}*/
// This is the Example of Multicast Delegate


using System.Collections;
using System.Runtime.CompilerServices;
/*
class Myclass
{

    public delegate void Muldel();

    public class Employee
    {
        public void Emp_Details()
        {
            Console.WriteLine( "Employee Name:- Emp1 ");
            Console.WriteLine( "Employee Id :- 7799");
            Console.WriteLine( "Employee Department :- IT ");
            Console.WriteLine( "Employee Salary :- 5000000 ");

        }
        public void Com_Details()
        {
            Console.WriteLine( "Company Name : Tata Counsltancy Services ");
            Console.WriteLine( "Company Location: Pune Sahyadri IT Park  ");
            Console.WriteLine( "Shift Timing : Morning Shift");

        }
        public void Com_Dept()
        {
            Console.WriteLine( "Departments:.....");
            Console.WriteLine( "HR ");
            Console.WriteLine( "IT ");
            Console.WriteLine( "SALES");
            Console.WriteLine( "MANAGEMENT");

        }
        static void Main(string[] args)
        {
            Employee Emp = new Employee ();

            Muldel md = new Muldel(Emp.Emp_Details);
            Muldel md2 = new Muldel(Emp.Com_Dept);
            Muldel md3 = new Muldel (Emp.Com_Details );

            Muldel md4 = md + md2 + md3;
            md4();

        }

    }
}
*/

/*
class Program
{
    public delegate string  Mydel( string names);

    public class Student
    {
        public string Show(string name)
        {
            Console.WriteLine( name );
            return name;
        }
        public string Show1(string LastName)
        {
            Console.WriteLine( LastName );
            return LastName;
        }
        public string Display(string SName)
        {
            Console.WriteLine( SName );
            return SName;
        }

        static void Main(string[] args)
        {
            Student std = new Student();

            Mydel md = new Mydel(std.Show);
            Mydel md2 = new Mydel(std.Show1);
            Mydel md3 = new Mydel(std.Display);

            md("Avinash Yadav");
            md2 ("Sanket Madane");
            md3 ("Sharad");
            Mydel md4 = md + md2 + md3; 





        }   
    }
}*/
/*
class Program
{
    public delegate int Del(int a, int b);
    
    public class Math
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }

    }
    static void Main(string[] args)
    {
        Math m = new Math();

        Del d = new Del(m.Add);

        int i = d(10, 20);

        Console.WriteLine(i);

        Del d1 = new Del(m.Sub);

        int j = d1(30, 10);

        Console.WriteLine(j);


    }




}
*/

/*
class Program
{
    public delegate void Mydel(int x, int y);
    public class Math
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"Addition is {a + b}");
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine($"Subtraction is {a - b}");
        }
    }
    static void Main(string[] args)
    {
        Math m = new Math();
        Mydel md = new Mydel(m.Add);
        Mydel md2 = new Mydel(m.Sub);
        md += m.Sub;
        
        md(10, 20);
    }
}
*/
// Delegate Example with anonymous method :- 
/*
public delegate string  Del(string name);

class Program
{
    static void Main(string[] args)
    {
        Del del = delegate (string name)
        {
           
            return name;
        };

       string i= del("Avinash");
        Console.WriteLine( i);
        

    }

}
*/

/*
public delegate string Del( int x , int y);

class Program
{
    static void Main(string[] args)
    {
        Del del = delegate (int x , int y)
        {
           return $"The sum of {x} and {y} is {x + y}";
        };
    }
}
*/
/*
class Program
{
    public delegate string Del(string Addres);
    static void Main(string[] args)
    {
        Del del = delegate (string Addres)
        {
            return Addres;
            Console.WriteLine( Addres );
        };
        del("Akluj");


    }
}
*/
/*
class Example
{
    public static void ShowArray<T>(T[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    
}
class Program
{
    static void Main(string[] args)
    {

        int[] numbers = new int[3];
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;

        string[] names = {
            "Avinash",
            "Sanket",
            "Sharad"
        };

        double [] prices = { 10.5, 20.75, 30.99 };  
        Example.ShowArray(numbers);
        Example.ShowArray(names);
        Example.ShowArray(prices);




    }
}
*/

/*class Program 
{


    static void Main(string[] args)
    {
        string[] first_Name = new string[3];

        first_Name[0] = "Amar";
        first_Name[1] = "Jay";      //string s
        first_Name[2] = "Komal";


        //Console.WriteLine(first_Name[1]);//"Jay"

        foreach (string s in first_Name)
        {
            Console.WriteLine(s);
        }

    }
}
*/
/*
// Example of Array list in C#
ArrayList arrayList = new ArrayList();



arrayList.Insert(,"");

//arrayList.RemoveAt(2);


foreach (var i in arrayList)
{
Console.WriteLine(i);
}
*/


// Param keyword used to Pass multiple parameters inside the method 
/*
static void Main()
{
    Print("Pratima", "Vivek", "Harshal", "Neha", "Komal", "Amit");

}
//string
static void Print(params string[] str)
{

    foreach (string s in str)
    {
        Console.WriteLine(s);
    }
}

*/
/*
static void Main()
{

    Mark("Ruchira", 90, 95, 70, 80);


}
//string
static void Mark(string name, params int[] number)
{
    if (number == null)
    {
        Console.WriteLine("Kindly pass marks inputs");
    }
    int avg = 0;

    foreach (int m in number)
    {
        avg += m;
    }

    avg = avg / number.Length;

    Console.WriteLine($"Avg mark {name} is {avg}");

}
*/
/*
static void Main()
{

    Mark("Ruchira");


}
//string
static void Mark(string name, params int[] number)
{
    try
    {
        if (number == null)
        {
            Console.WriteLine("Kindly pass marks inputs");
        }
        int avg = 0;

        foreach (int m in number)
        {
            avg += m;
        }

        try
        {
            avg = avg / number.Length;
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Kindly pass marks inputs");
        }



        Console.WriteLine($"Avg mark {name} is {avg}");

    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }


}
*/
class Program
{
    static void Main()
    {
        //Contiue

        // 1 to 10 

        string[] str = new string[4];

        str[0] = "A";
        str[1] = "B";
        str[2] = "C";
        str[3] = "D";


        foreach (string str2 in str)
        {
            if (str2 == "C")
            {
                continue;
            }

            Console.WriteLine(str2);
        }
    }

}








