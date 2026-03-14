using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca_ListasEnlazadas
{
    public class Nodo
    {
        public string Isbn { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }

        // Referencia al siguiente nodo
        public Nodo Siguiente { get; set; }

        public Nodo(string isbn, string titulo, string autor)
        {
            Isbn = isbn;
            Titulo = titulo;
            Autor = autor;
            Siguiente = null;
        }

    }
}
