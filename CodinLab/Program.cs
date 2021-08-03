using System;
using System.Reflection;
using CodinLab.Attribute;

namespace CodinLab
{
    // https://www.tutorialsteacher.com/csharp/csharp-delegates
    /*
     Points to Remember :
    1. Delegate is the reference type data type that defines the signature.
    2. Delegate type variable can refer to any method with the same signature as the delegate.
    3. Syntax: [access modifier] delegate [return type] [delegate name]([parameters])
    4. A target method's signature must match with delegate signature.
    5. Delegates can be invoke like a normal function or Invoke() method.
    6. Multiple methods can be assigned to the delegate using "+" or "+=" operator and removed using "-" or "-=" operator. It is called multicast delegate.
    7. If a multicast delegate returns a value then it returns the value from the last assigned target method.
    8. Delegate is used to declare an event and anonymous methods in C#.
     */
    public delegate void MyDelegate(string msg); //declaring a delegate
    public delegate int MyDelegateTwo();
    class Program
    {
        //static main for delegate
        /*static void Main(string[] args)
        {
           /* MyDelegate del = ClassA.MethodA;
            InvokeDelegate(del);
            
            del = ClassB.MethodB;
            InvokeDelegate(del);

            del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            InvokeDelegate(del);
           
           // Adding or removing (combinning) delegates
           MyDelegate del1 = ClassA.MethodA;
           MyDelegate del2 = ClassB.MethodB;

           MyDelegate del = del1 + del2; // combines del1 + del2
           del("Hello World");

           MyDelegate del3 = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
           del += del3; // combines del1 + del2 + del3
           del("Hello World");

           del = del - del2; // removes del2
           del("Hello World");

           del -= del1; // removes del1
           del("Hello World");#1#
           
           //delegate to a return method
           
           MyDelegateTwo del1 = ClassA.MethodA2;
           MyDelegateTwo del2 = ClassB.MethodB2;

           var del = del1 - del2; 
           Console.WriteLine(del1() + " - "+ del2() +" - "+del());// returns 200
        }
        
        static void InvokeDelegate(MyDelegate del) // MyDelegate type parameter
        {
            del("Hello World");
        }
        */


        
        /*vodi main for funcional delegate
            c# contain an inbuilt generic delegate function that can be use to
            declare a delegate
            
            public delegate TResult Func<in T, out TResult>(T arg);
            
            it has two parameters the input and the out put
            the input can be as zero or atmost 16 of same type, but the output must be one
            
            example:
            The following Func delegate takes two input parameters of int type and returns a value of int
            
            Func<int, int, int> sum;
            
            And this has no input just output
            Func<int> getRandomNumber;
            
            
             Points to Remember :
            Func is built-in delegate type.
            Func delegate type must return a value.
            Func delegate type can have zero to 16 input parameters.
            Func delegate does not allow ref and out parameters.
            Func delegate type can be used with an anonymous method or lambda expression.
            
        
        
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Func<int,int, int> add = Sum;

            int result = add(10, 10);

            Console.WriteLine(result);
            
            //anonymous delegate function to a method
            Func<int> getRandomNumber = delegate()
            {
                Random rnd = new Random();
                return rnd.Next(1, 100);
            };
            
            Console.WriteLine(getRandomNumber.Invoke());
            
            //using lambda expresiion
            Func<int> getRandomNumbertwo = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumbertwo.Invoke());

            Func<int, int, int> Sumy = (x, y) => x + y;
            Console.WriteLine(Sumy(30,10));
        }
         */

        /* Action Delegate
         similar to func delegate but doesnt return a value
        
        public delegate void Print(int val);

        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }

        static void Main(string[] args)
        {           
            Print prnt = ConsolePrint;
            prnt(10);
            // or use an action delegate diretly
            Action<int> printActionDel = ConsolePrint;
            Action<int> printActionDeltwo = new Action<int>(ConsolePrint);
            printActionDel(10);
            printActionDeltwo(40);
            
            // Or anonymous method.
            Action<int> printActionDelThree = delegate(int i)
            {
                Console.WriteLine(i);
            };

            printActionDelThree(100);
            
            //or lssmbda
            Action<int> printActionDelFour = i => Console.WriteLine(i);
       
            printActionDelFour(135);

        }
        */
        /*Predicate Delegate
         Predicate is the delegate like Func and Action delegates. 
         It represents a method containing 
         a set of criteria and checks whether the passed parameter meets
          those criteria. A predicate delegate methods must take one input 
          parameter and return a boolean - true or false
          
          Points to Remember:
        1. Predicate delegate takes one input parameter and boolean return type.
        2. Anonymous method and Lambda expression can be assigned to the predicate delegate.
         */
        
        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

        static void Main(string[] args)
        {
            Predicate<string> isUpper = IsUpperCase;

            bool result = isUpper("hello world!!");

            Console.WriteLine(result);
            
            //with anonymous method
            Predicate<string> isUpperTwo = delegate(string s) { return s.Equals(s.ToUpper());};
            bool resulttwo = isUpperTwo("hello world!!");
            
            Console.WriteLine(resulttwo);
            
            Predicate<string> isUpperThree = s => s.Equals(s.ToUpper());
            bool resultThree = isUpperThree("HELLO!!");
            Console.WriteLine(resultThree);
            
            
        }
        
    }

    class ClassA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
        public static int MethodA2()
        {
            return 120;
        }
    }

    class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
        
        public static int MethodB2()
        {
            return 100;
        }
    }
}