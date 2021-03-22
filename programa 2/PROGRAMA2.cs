using System;

namespace programa_2
{
    public class Contacto
    {
        public string Nombre;
        public string Apellido;
        public string Cedula;
        public string Direccion;
        public string Saludar;

        public string nombre
        {
            get{return Nombre;}
            set{Nombre = value;}
        }

        public string apellido 
        {
            get {return Apellido;}
            set {Apellido = value;}
        }

        public string cedula 
        {
            get {return Cedula;}
            set {Cedula = value;}
        }

        public string direccion 
        {
            get {return Direccion;}
            set {Direccion = value;}
        }

        public string saludar 
        {
            get {return Saludar;}
            set {Saludar = value;}
        }
    }

    public class SetContacto : Contacto
        {
            public void n()
            {
            Console.Write("Introduzca el nombre: ");
            nombre = Console.ReadLine();
            }
            
            public void a()
            {
            Console.Write("Introduzca el apellido: ");
            apellido = Console.ReadLine();
            }

            public void c()
            {
            Console.Write("Introduzca la cedula: ");
            cedula = Console.ReadLine();
            }

            public void d()
            {
            Console.Write("Introduzca la cedula: ");
            direccion = Console.ReadLine();
            }
        }

    class ProbarContacto
    {
        static void Main(string[] args)
        {
            SetContacto obj = new SetContacto();
            obj.saludar = "Hola, soy";
            Console.WriteLine();
            Console.Write("Introduzca el Nombre: ");
            obj.nombre = Console.ReadLine();

            Console.Write("Introduzca el Apellido: ");
            obj.apellido = Console.ReadLine();

            Console.Write("Introduzca la Cedula: ");
            obj.cedula = Console.ReadLine();

            Console.Write("Introduzca la Direccion: ");
            obj.direccion = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(obj.saludar+ " " +obj.nombre+obj.apellido);
            Console.WriteLine("Cedula: "+obj.cedula);
            Console.WriteLine("Direccion: "+obj.direccion);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
