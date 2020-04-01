using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDemo.Models
{
    public interface IIntegranteFamilia
    {
        string Nombre { set; get; }
        int Edad { set; get; }

        void AgregarHijo(IIntegranteFamilia hijo);

        IEnumerable<IIntegranteFamilia> ObtenerHijos();

        void ImprimirArbol();

        void EdadPromedio();
    }
}
