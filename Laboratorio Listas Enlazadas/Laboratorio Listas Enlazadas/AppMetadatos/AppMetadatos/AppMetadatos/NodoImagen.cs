using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMetadatos
{
    public class NodoImagen
    {

        public string NombreArchivo { get; set; }
        public string Formato { get; set; }  
        public string Resolucion { get; set; } 

        
        public NodoImagen Siguiente { get; set; }

        public NodoImagen(string nombre, string formato, string resolucion)
        {
            NombreArchivo = nombre;
            Formato = formato;
            Resolucion = resolucion;
            Siguiente = null;
        }
    }
}
