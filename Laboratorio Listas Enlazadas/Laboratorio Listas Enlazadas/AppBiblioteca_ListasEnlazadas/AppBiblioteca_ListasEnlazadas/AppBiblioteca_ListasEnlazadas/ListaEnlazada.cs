using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca_ListasEnlazadas
{
    public class ListaEnlazada
    {

        private Nodo cabeza; // El primer elemento

        // 1. Insertar al Inicio
        public void InsertarInicio(string isbn, string titulo, string autor)
        {
            Nodo nuevo = new Nodo(isbn, titulo, autor);
            nuevo.Siguiente = cabeza;
            cabeza = nuevo;
        }

        // 2. Insertar al Final
        public void InsertarFinal(string isbn, string titulo, string autor)
        {
            Nodo nuevo = new Nodo(isbn, titulo, autor);
            if (cabeza == null) { cabeza = nuevo; return; }

            Nodo actual = cabeza;
            while (actual.Siguiente != null) actual = actual.Siguiente;
            actual.Siguiente = nuevo;
        }

        // 3. Insertar al Medio (Después de una posición específica)
        public void InsertarMedio(int posicion, string isbn, string titulo, string autor)
        {
            if (posicion <= 0) { InsertarInicio(isbn, titulo, autor); return; }

            Nodo nuevo = new Nodo(isbn, titulo, autor);
            Nodo actual = cabeza;
            for (int i = 0; i < posicion - 1 && actual != null; i++) actual = actual.Siguiente;

            if (actual != null)
            {
                nuevo.Siguiente = actual.Siguiente;
                actual.Siguiente = nuevo;
            }
        }

        // 4. Eliminar por ISBN
        public bool Eliminar(string isbn)
        {
            if (cabeza == null) return false;
            if (cabeza.Isbn == isbn) { cabeza = cabeza.Siguiente; return true; }

            Nodo actual = cabeza;
            while (actual.Siguiente != null && actual.Siguiente.Isbn != isbn)
                actual = actual.Siguiente;

            if (actual.Siguiente != null)
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
                return true;
            }
            return false;
        }

        // 5. Buscar un registro
        public Nodo Buscar(string isbn)
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                if (actual.Isbn == isbn) return actual;
                actual = actual.Siguiente;
            }
            return null;
        }

        // Método extra para mostrar en el DataGridView o ListBox
        public List<Nodo> ToList()
        {
            List<Nodo> listaSimple = new List<Nodo>();
            Nodo actual = cabeza;
            while (actual != null) { listaSimple.Add(actual); actual = actual.Siguiente; }
            return listaSimple;
        }
        // Método de apoyo para saber si el código ya existe
        public bool ExisteCodigo(string codigo)
        {
            return Buscar(codigo) != null;
        }
    }
}
