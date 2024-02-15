//using DelegateFromUkbek;
//using System.Data.SqlTypes;

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Money money = new Money(1000000);
//        MoneyOperator moneyOperator = new MoneyOperator();
//        Money.MoneyDelegate moneyDelegate = new Money.MoneyDelegate(moneyOperator.Uzs2Usd);
//        moneyOperator.Send(money, "KapitalBank", moneyDelegate);
//        Console.WriteLine(moneyDelegate.Method.Name);
//        Console.ReadLine();
//    }
//}

//class Person_InitExample
//{
//    private int _yearOfBirth;

//    public int YearOfBirth
//    {
//        get { return _yearOfBirth; }
//        init { _yearOfBirth = value; }
//    }
//}

//using System;
//namespace DelegateFromUkbek
//{
//    class Program
//    {
//        public delegate void MyDelegate(string msg);
//        public static void Main(string[] args) 
//        {
//            MyDelegate delegatcha1 = new MyDelegate(MethodA);

//            MyDelegate delegatcha2 = MethodA;

//            MyDelegate delegatcha3 = (string msg) => Console.WriteLine(msg);

//            Console.ReadKey();
//        }
//        static void MethodA (string massage)
//        {
//            Console.WriteLine(massage);
//        }
//    }
//}

//using System;
//namespace Delegate
//{
//    public delegate void MyDelegate(string msg);
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MyDelegate del = ClassA.MethodA;
//            del("Salom Patsan");

//            del = ClassB.MethodB;
//            del("Hello Baby Shark");

//            del = (string msg) => Console.WriteLine("Lambda ifoda ishlatilishi: " + msg);
//            del("Hello Makrid City");

//            Console.ReadLine();
//        }
//        class ClassA
//        {
//            public static void MethodA(string message)
//            {
//                Console.WriteLine("ClassA.MethodA() metodi chiqarildi: " + message);
//            }
//        }
//        class ClassB
//        {
//            public static void MethodB(string message)
//            {
//                Console.WriteLine("ClassB.MethodB() methodi Chaqirildi: " + message);
//            }
//        }
//    }
//}

//using System;
//using System.Threading.Channels;
//namespace Delegate
//{
//    public delegate void MyDelegate(string msg);

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MyDelegate del = ClassA.MethodA;
//            InvokeDelegate(del);

//            del = ClassB.MethodB;
//            InvokeDelegate(del);

//            del = (string msg) => Console.WriteLine("Lambda ifoda ishlatilishi: " + msg);
//            InvokeDelegate(del);
//        }
//        static void InvokeDelegate(MyDelegate del) //My Delegate prametrlar turi
//        {
//            del("Hello vvoorrlldd");
//        }
//    }
//    class ClassA
//    {
//        public static void MethodA(string message)
//        {
//            Console.WriteLine("ClassA.MethodA() metodi chaqirildi: " + message); ;
//        }
//    }
//    class ClassB
//    {
//        public static void MethodB (string message)
//        {
//            Console.WriteLine("ClassB.MethodB()metodi chaqirildi: " + message);


//        }
//    }
//}

//using System;
//using System.Threading.Channels;
//namespace Dars_TryCatch_Delegate
//{
//    public class Student
//    {
//        public int Age { get; set; }
//        public string Name { get; set; }
//        public int EnrolNumber { get; set; }

//    }
//    public class Program
//    {
//        public delegate void Feedback(string Message);
//        //public delegate TResult MyDelegate<T, TResult>(T value);
//        public static void Main(string[] args)
//        {
//            Feedback feedback = new Feedback(FeedbackToConsole);
//            feedback.Invoke("Salom hammaga!"); // => feedback("Salom hammaga!"); ConvertCharArrayToString
//        }
//        public static void FeedbackToConsole(string message)
//        {
//            Console.WriteLine(message);
//        }
        //public static int Increment(int arg)
        //{
        //    return ++arg;
        //}
        //MyDelegate<int, int> myDelegate = new MyDelegate<int, int>(Increment);
        //Console.WriteLine(myDelegate(1));

//        List<Student> students = new()
//        {
//            new() { Age =24, Name = "Falonchi", EnrolNumber = 2018 },
//            new() { Age =26, Name = "Pistonchi", EnrolNumber = 2022},
//        };

//        Func<Student, string> stdNam = student => student.Name;
//        IEnumerable<string> studentsNames = students.Select(stdNam);

//        foreach(var name in studentsNames)
//        {
//            Console.WriteLine(name);
//        }

//        Action<Student> studentAction = student => Console.WriteLine(student.Name);
//        students.ForEach(studentAction);

//        Pridecate<Student> isAdult = student => student.Age > 18;

//        List<Student> adultStudents = students.FindAll(isAdult);

//        foreach(var student in adultStudents)
//        {
//            Console.WriteLine(Student.Age);
//        }
//    }
//}
 

//namespace DelegatgaMisol
//{
//    public class Program
//    {

//        //signature - metodning input va output tipini bildiradi

//        public delegate int Calculation(int a, int b);
//        public static void Main(string[] args)
//        {
//            Calculation calculate = new Calculation(Multiplication);
//            Console.WriteLine(calculate.Invoke(6, 7)); 
//        }
//        private static int Multiplication(int x, int y)
//        {
//            return x * y;
//        }
//    }
//}

