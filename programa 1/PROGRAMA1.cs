using System;

namespace programa_1
{
    // 1.	Crear una clase Persona que tenga como atributos el "cedula, nombre, apellido y la edad (definir las propiedades para poder acceder a dichos atributos)". Definir como responsabilidad un método para mostrar ó imprimir. Crear una segunda clase Profesor que herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el método para imprimir su sueldo. Definir un objeto de la clase Persona y llamar a sus métodos y propiedades. También crear un objeto de la clase Profesor y llamar a sus métodos y propiedades.
    public class Persona
    {
        public string cedula;
        public string nombre;
        public string apellido;
        public int edad;
        

        public string Cedula 
        {
            get {return cedula;}
            set {cedula = value;}
        }

        public string Nombre
        {
            get {return nombre;}
            set {nombre = value;}
        }
        public string Apellido
        {
            get{return apellido;}
            set{apellido = value;}
        }

        public int Edad
        {
            get {return edad;}
            set {edad = value;}
        }
    }

    public class Profesor : Persona
    {
        public int Sueldo;

        public int sueldo
        {
            get {return Sueldo;}
            set {Sueldo = value;}
        }

    }
    class Herencia
    {
        static void Main(string[] args)
        {
            Profesor obj = new Profesor();
            obj.Cedula = "402-4345067-3";
            obj.Nombre = "Marco";
            obj.Apellido = "Mercato";
            obj.Edad = 24;
            obj.sueldo = 32000;
            Console.WriteLine();
            Console.WriteLine("La persona "+obj.Nombre+ " "+ obj.Apellido+ " de " +obj.Edad+" años");
            Console.WriteLine("Con la cedula "+obj.Cedula+ " obstenta un sueldo de RD$"+obj.sueldo+ " pesos como profesor.");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
