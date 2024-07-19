using System;
using ChapterOne;
using lab1;

class App
{
    public static void Main(string[] args)
    {
        //Creating a comstructor:
        Console.WriteLine("This is a constructor:");
        Book book1  = new Book("Anish's Diary",500,"Anish Baraily");
        book1.DisplayBookInfo();

        //Inheritance:
        Console.WriteLine("\nInheritence:");
        Chef chef1 = new Chef();
        chef1.skill1();
        chef1.skill2();

        //Polymorphism

        //Static Polymerphism
        Console.WriteLine("\nStatic Polymorphism");
        StaticPolyMorph ob1 = new();
        ob1.Print(101);
        ob1.Print("Anish Baraily");

        //Dynamic Polymerphism
        Console.WriteLine("\nDynamic Polymorphism");
        Animal A1 = new();
        A1.Speak();

        Dog D1 = new();
        D1.Speak("barked");

        //Exception handling
        Console.WriteLine("\nException Handling:");
        CustomExceptionHandler Ex1 = new CustomExceptionHandler();
        double res = Ex1.Divide(2, 0);
        Console.WriteLine("Division result = {0}", res);

        //Linq
        Console.WriteLine("\nLINQ");
        int[] number_list = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] even_list;
        int[] odd_list; 

        Linq L1 = new();

        L1.NumberList(number_list);

        even_list = L1.GetEvenList(count: true);
        foreach (var number in even_list)
            Console.WriteLine(number);

        odd_list = L1.GetOddList(count: false);
        foreach (var number in odd_list)
            Console.WriteLine(number);

        //Abstract class
        Console.WriteLine("\nAbstract Class");
        
        NormalClass obj1 = new NormalClass();

        obj1.AbstractMethod();
        obj1.NormalMethod();

        //Interface
        Console.WriteLine("\nInterface");
        Class Obj = new Class();
        
        Obj.Method();

        //Delegate event Handler
        Console.WriteLine("\nDelegate and Event Handler");
        EventPublisher publisher = new EventPublisher();
        publisher.MyEvent += PrintMessage;
        publisher.TriggerEvent("Event is triggered.");

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        //File Handling

        Console.WriteLine("\nFile Handeling:");
        Student S1 = new Student();
        S1.GetData();
        S1.Write();
        S1.Read();
        S1.DisplayFileContents();

    }

}
