using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDemo.Models
{
    public class Persona : IIntegranteFamilia
    {
        public string Nombre { get ; set ; }
        public int Edad { get; set; }

        private List<IIntegranteFamilia> integrantes;


        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
            integrantes = new List<IIntegranteFamilia>();
        }

        public void AgregarHijo(IIntegranteFamilia hijo)
        {
            integrantes.Add(hijo);
        }

        public IEnumerable<IIntegranteFamilia> ObtenerHijos()
        {
            return integrantes;
        }

        public void ImprimirArbol()
        {
            Console.WriteLine($"{this.Nombre}({this.Edad})");
            ObtenerHojas("", this);
        }

        private void ObtenerHojas(string separador, IIntegranteFamilia persona)
        {
            separador += " ";
            foreach (var hijo in persona.ObtenerHijos())
            {
                Console.WriteLine($"{separador}{hijo.Nombre}({hijo.Edad})");
                ObtenerHojas(separador, hijo);
            }
        }

        public void EdadPromedio()
        {
            var totIntegrantes = TotIntegrantes(this)+1;
            var totSuma = SumaEdadesIntegrantes(this)+this.Edad;
            Console.WriteLine($"{totSuma / totIntegrantes}");
        }

        private int TotIntegrantes(IIntegranteFamilia persona)
        {
            var tot = 0;
            foreach(var hijo in persona.ObtenerHijos())
            {
                tot++;
                tot = tot + TotIntegrantes(hijo);
            }
            return tot;
        }

        private int SumaEdadesIntegrantes(IIntegranteFamilia persona)
        {
            var suma = 0;
            foreach (var hijo in persona.ObtenerHijos())
            {
                suma += hijo.Edad;
                suma = suma + SumaEdadesIntegrantes(hijo);
            }
            return suma;
        }
    }
}
