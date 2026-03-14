using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMetadatos
{
    public class ListaImagenes
    {

        private NodoImagen cabeza = null;

        public void InsertarInicio(string nom, string form, string res)
        {
            NodoImagen nuevo = new NodoImagen(nom, form, res);
            nuevo.Siguiente = cabeza;
            cabeza = nuevo;
        }

        

        public void InsertarFinal(string nom, string form, string res)
        {
            NodoImagen nuevo = new NodoImagen(nom, form, res);
            if (cabeza == null) { cabeza = nuevo; return; }
            NodoImagen actual = cabeza;
            while (actual.Siguiente != null) actual = actual.Siguiente;
            actual.Siguiente = nuevo;
        }

        public void InsertarMedio(int pos, string nom, string form, string res)
        {
            if (pos <= 0 || cabeza == null) { InsertarInicio(nom, form, res); return; }
            NodoImagen nuevo = new NodoImagen(nom, form, res);
            NodoImagen actual = cabeza;
            for (int i = 0; i < pos - 1 && actual.Siguiente != null; i++) actual = actual.Siguiente;
            nuevo.Siguiente = actual.Siguiente;
            actual.Siguiente = nuevo;
        }

        public NodoImagen Buscar(string nombre)
        {
            NodoImagen actual = cabeza;
            while (actual != null)
            {
                if (actual.NombreArchivo.ToLower() == nombre.ToLower()) return actual;
                actual = actual.Siguiente;
            }
            return null;
        }

        
        public bool Eliminar(string nombre)
        {
            if (cabeza == null) return false;
            if (cabeza.NombreArchivo == nombre) { cabeza = cabeza.Siguiente; return true; }
            NodoImagen actual = cabeza;
            while (actual.Siguiente != null && actual.Siguiente.NombreArchivo != nombre)
                actual = actual.Siguiente;

            if (actual.Siguiente != null)
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
                return true;
            }
            return false;

        }

        public List<NodoImagen> ToList()
        {
            List<NodoImagen> listaSimple = new List<NodoImagen>();
            NodoImagen actual = cabeza;

            while (actual != null)
            {
                listaSimple.Add(actual);
                actual = actual.Siguiente;
            }
            return listaSimple;
        }
    }
}
