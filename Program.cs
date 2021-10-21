using System;

namespace AdvancedConcepts
{
    delegate int Calculator(int x);
    delegate double Onedimensional(double y);

    class MainClass
    {
        static int number = 10;

        public static int  Addtwo(int x)
        {
            return number+= x; 
        }

        public static int GetNumber()
        {
            return number;
        }

        public static int MulTwo(int x)
        {
            return number*=x;
        }

        public static double SubTwo(double y)
        {
            double k= y * y;
            Console.WriteLine("integrated value is");
            return k;
        }

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");

        //    Func<int, int> gd = new Func<int, int>(Addtwo);
        //    gd.Invoke(2);
        //    Console.WriteLine($"The Generic delegate is {GetNumber()}");


        //    Func<int,float,double> ad=delegate(int x1,float x2)
        //    {
        //        return x1 * x2;
	       // };

        //    double output1 = ad(3, 4.0f);
        //    Console.WriteLine($"The anonymous delegate is {output1}");

        //    Func<int, int, double> le = (int y1, int y2) => y1 + y2;
        //    double output2=le.Invoke(5, 6);
        //    Console.WriteLine($"The lambda expression related delegate is {output2}");

        //    Func<double, double, double> squoff = (x, y) => x * x + y;

        //    Calculator c0;
        //    Calculator c1 = new Calculator(Addtwo);
        //    Calculator c3 = new Calculator(MulTwo);
        //    Onedimensional c2 = new Onedimensional(SubTwo);
        //    Console.WriteLine($"The number is {GetNumber()}");

        //    c0 = c1;
        //    c0 += c3; 
        //    c0(8);
        //    Console.WriteLine($"Multicasted value is {GetNumber()}");
            
        //    Subclass s1 = new Subclass();
        //    s1.Integrate(3,c2);
            

        //}
    }

    class Subclass: MainClass
    {
        public void Integrate(int x, Onedimensional y)
        {
            double z=y(4.0);
            Console.WriteLine($"The number is {GetNumber(z)}");
        }

        public static double GetNumber(double c)
        {
            return c;
        }
    }
}
