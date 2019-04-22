using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstructurasDeDatos.Cola 
{
    public class Cola<Tipo> : IEnumerable<Tipo>
    {
        private Nodo _primero;
        private Nodo _ultimo;
        private int _n;

        private class Nodo
        {
            public Tipo dato;
            public Nodo siguiente;

            public Nodo(Tipo dato)
            {
                this.dato = dato;
            }
        }

        public bool EstaVacia() { return _primero == null;  }
        public int Tamaño() { return _n; }

        public void Enqueue(Tipo dato)
        {
            Nodo viejoultimo = _ultimo;
            _ultimo = new Nodo(dato);
            _ultimo.siguiente = null;
            _n++;
            if (EstaVacia()) _primero = _ultimo;
            else viejoultimo.siguiente = _ultimo;
        }

        public Tipo Dequeue()
        {
            if (EstaVacia())
                throw new InvalidOperationException("Overflow en la cola");

            Tipo dato = _primero.dato;
            _primero = _primero.siguiente;
            _n--;
            if (EstaVacia()) _ultimo = null;
            return dato;
        }

        // Recorre la cola y regresa un string con cada elemento
        public override string ToString()
        {
            Nodo actual = _primero;
            string salida = "";

            while (actual != null)
            {
                salida += actual.dato.ToString() + "  ";
                actual = actual.siguiente;
            }

            return salida;
        }

        // Este codigo sirve para poder recorrer la cola con un foreach
        public IEnumerator<Tipo> GetEnumerator()
        {
            Nodo actual = _primero;

            while (actual != null)
            {
                yield return actual.dato;
                actual = actual.siguiente;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
