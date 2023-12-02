using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    public class Nodo
    {
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        /// <param name="pNombre">Enviamos solamente un dato (Por Ejemplo: Factura)</param>
        public Nodo(String pNombre)
        {
            this.Nombre = pNombre; //Nos quedaría un nodo de tipo HOJA, porque no tiene hijos...
        }

        /// <summary>
        /// Constructor con Nodos izq y der
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pIzq"></param>
        /// <param name="pDer"></param>
        public Nodo(String pNombre, Nodo pIzq = null, Nodo pDer = null) : this(pNombre)
        {
            this.Izq = pIzq;
            this.Der = pDer;
        }
        public String Nombre { get; set; } //->Clase Alumno/Producto/MateriaPrima, numeros...
        public Nodo Izq { get; set; }
        public Nodo Der { get; set; }
    }
}
