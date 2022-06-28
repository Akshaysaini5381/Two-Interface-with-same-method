using System;

namespace Two_Interface_with_same_method
{
    interface F1
    {
        public abstract void M1();
    }
    interface F2
    {
        void M1();
    }
    class Program:F1,F2
    {
        public void M1()
        {
            Console.WriteLine("Same Mehtod :");
        }
      
    }
    class main:Program
    {
        static void Main(string[] args)
        {
            F1 obj = new Program();
            F2 obj1 = new Program();
            obj.M1();
            obj1.M1();
            Program obj2 = new Program();
            main obj3 = new main();
            obj2.M1();
            obj3.M1();
        }
    }
}
