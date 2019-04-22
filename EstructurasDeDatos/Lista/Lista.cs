using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos.Lista
{
     public class Lista<Tipo> : IEnumerable<Tipo>
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

         public bool EstaVacia() { return _primero == null; }
         public int Tamaño() { return _n; }

        public void Add(Tipo dato)
        {
            Agregar(dato);
        }

        public void Agregar(Tipo dato)
         {
             Nodo viejoultimo = _ultimo;
             _ultimo = new Nodo(dato);
             _ultimo.siguiente = null;
             _n++;
             if (EstaVacia()) _primero = _ultimo;
             else viejoultimo.siguiente = _ultimo;
         }

         public Tipo Remover()
         {
             if (EstaVacia())
                 throw new InvalidOperationException("Overflow en la cola");

             Tipo dato = _primero.dato;
             _primero = _primero.siguiente;
             _n--;
             if (EstaVacia()) _ultimo = null;
             return dato;
         }

         // Recorre la lista y regresa un string con cada elemento
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

         // Este codigo sirve para poder recorrer la lista con un foreach
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
