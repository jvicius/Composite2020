using CompositeDemo.Models;
using System;

namespace CompositeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona1 = new Persona("Jose", 78);
            var persona2 = new Persona("Juan", 60);
            var persona3 = new Persona("Hugo", 40);
            var persona4 = new Persona("Mayra", 20); 
            var persona5 = new Persona("Diana", 10);

            var persona6 = new Persona("Luisa", 50);
            var persona7 = new Persona("Azucena", 50);
            var persona8 = new Persona("Sergio", 50);

            persona1.AgregarHijo(persona2);
            persona1.AgregarHijo(persona3);
            persona3.AgregarHijo(persona4);
            persona4.AgregarHijo(persona5);

            persona1.AgregarHijo(persona6);
            persona6.AgregarHijo(persona7);
            persona6.AgregarHijo(persona8);            

            persona1.ImprimirArbol();
            persona1.EdadPromedio();

            persona3.ImprimirArbol();

        }
    }
}
