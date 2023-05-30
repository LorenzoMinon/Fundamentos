using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentoCSHARP.Models
{
    class Bebida
    {
        public string Nombre { get; set; } // Si no le ponemos public, tiene por defecto el modificador internal
        
        public int Cantidad { get; set; }

        public Bebida(string Nombre, int Cantidad) // siempre tiene que tener el constructor  de la clase
        {// el constructor por defectos es el que no recibe nada
            //con constructor si o si recibir parametros
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }
        public void Beberse(int CuantoBebio)
        {
            this.Cantidad -= CuantoBebio;

        }
    }
}
