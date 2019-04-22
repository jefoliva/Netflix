using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstructurasDeDatos.Pila
{
    public class Pila<Tipo> : IEnumerable<Tipo>
    {
        private Nodo primero;
        int n;

        private class Nodo
        {
            public Tipo dato;
            public Nodo siguiente;

            public Nodo(Tipo dato)
            {
                this.dato = dato;
            }
        }

        public bool EstaVacia() { return primero == null;  }
        public int Tamaño() { return n; }

        public void Push(Tipo dato)
        {
            Nodo viejoprimero = primero;
            primero = new Nodo(dato);
            primero.siguiente = viejoprimero;
            n++;
        }

        public Tipo Pop()
        {
            if (EstaVacia()) throw new InvalidOperationException("Underflow de pila.");
            Tipo dato = primero.dato;
            primero = primero.siguiente;
            n--;
            return dato;
        }
        
        // Recorre la pila y regresa un string con cada elemento
        public override string ToString()
        {
            Nodo actual = primero;
            string salida = "";

            while (actual != null)
            {
                salida = actual.dato.ToString() + "  " + salida;
                actual = actual.siguiente;
            }

            return salida;
        }

        // Este codigo sirve para poder recorrer la pila con un foreach
        public IEnumerator<Tipo> GetEnumerator()
        {
            Nodo actual= primero;

            while (actual != null)
            {
                yield return actual.dato;
                actual= actual.siguiente;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
