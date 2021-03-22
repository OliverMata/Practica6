using System;

namespace Programa_3
{
        public class A
    {
        public A()
        {
            Console.WriteLine("Constructor de la clase A");
        }
    }

    public class B : A 
    {
        public B()
        {
            Console.WriteLine("Constructor de la clase B");
        }
    }

    public class C : B
    {
        public C()
        {
            Console.WriteLine("Constructor de la clase C");
        }
    }

    class Objeto_C
    {
        static void Main(string[] args)
        {
            C obj = new C();
            Console.ReadKey();
        }
    }
}
