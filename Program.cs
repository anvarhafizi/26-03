using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
       {
           Console.WriteLine("26.03");
           Console.WriteLine("Exercise 2");
           double n=Convert.ToDouble(Console.ReadLine());
           if (n>=500 && n<=1000)
           {
               Console.WriteLine("Discount on 3%");
               Console.WriteLine("Discount="+(n-(n*0.03)));
           }
           if (n>=1000)
           {
               Console.WriteLine("Discount on 5%");
               Console.WriteLine("Discount="+(n-(n*0.05)));
           }
           if(n<500)
           Console.Write("Not discount="+n);
           Console.ReadKey();
           
           Console.WriteLine("---------------------");
           Console.WriteLine("Exercise 3");
           Console.WriteLine("Enter numbers A,B,C,D");
           int A,B,C,D;
           A=Convert.ToInt32(Console.ReadLine());
           B=Convert.ToInt32(Console.ReadLine());
           C=Convert.ToInt32(Console.ReadLine());
           D=Convert.ToInt32(Console.ReadLine());
           if (A<B && B<C && C<D)
           {
               Console.WriteLine("location number ascending");
           }
           if (A==B && B==C && C==D)
           {
               Console.WriteLine("multiplay="+(A*B*C*D));
           }
           else
           {
                int min1=Math.Min(Math.Min(A,B),Math.Min(C,D));
                Console.WriteLine("the small number="+min1);
           }
           Console.ReadKey();

        Console.WriteLine("---------------------");
         Console.WriteLine("Exercise 4");
           int a,b,c,s;
         Console.Write("first number=");
         a=Convert.ToInt32(Console.ReadLine());

         Console.Write("second number=");
         b=Convert.ToInt32(Console.ReadLine());

         Console.Write("third number=");
         c=Convert.ToInt32(Console.ReadLine());

         int  max=Math.Max(Math.Max(a,b),c),min=Math.Min(Math.Min(a,b),c);
         s=a+b+c; a=max; b=s-max-min; c=min;
         Console.WriteLine($"number descendings={a},{b},{c}");
         Console.ReadKey();
        }
    }
}
