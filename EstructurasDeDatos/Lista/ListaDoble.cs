using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos.Lista
{
    public class ListaDoble<Item> : IEnumerable<Item>
    {
        private NodoDoble primero;
        private NodoDoble ultimo;
        int N;

        public ListaDoble()
        {
            
        }

        private class NodoDoble
        {
            public Item item;
            public NodoDoble sig;
            public NodoDoble ant;
        }

        public bool EstaVacia() { return primero == null; }
        public int Tamaño() { return N; }

        public void Add(Item item)
        {
            AgregarAlFinal(item);
        }

        public void Agregar(Item item)
        {
            AgregarAlFinal(item);
        }

        public void AgregarAlInicio(Item item)
        {
            if (EstaVacia())
            {
                primero = new NodoDoble();
                primero.item = item;
                primero.sig = null;
                primero.ant = null;
                ultimo = primero;
            }
            else {
                NodoDoble oldprimero = primero;
                primero = new NodoDoble();
                primero.item = item;
                primero.sig = oldprimero;
                primero.ant = null;
                oldprimero.ant = primero;
            }
            N++;
        }

        public void AgregarAlFinal(Item item)
        {
            if (EstaVacia())
            {
                ultimo = new NodoDoble();
                ultimo.item = item;
                ultimo.sig = null;
                ultimo.ant = null;
                primero = ultimo;
            }
            else {
                NodoDoble oldultimo = ultimo;
                ultimo = new NodoDoble();
                ultimo.item = item;
                ultimo.sig = null;
                ultimo.ant = oldultimo;
                oldultimo.sig = ultimo;
            }
            N++;
        }

        public Item RemoverrDelInicio()
        {
            if (EstaVacia()) throw new InvalidOperationException("List Underflow");
            Item item;
            if (Tamaño() == 1)
            {
                item = primero.item;
                primero = null;
                ultimo = null;
            }
            else {
                item = primero.item;
                primero = primero.sig;
                primero.ant = null;
            }
            N--;
            return item;
        }

        public Item RemoverrDelFinal()
        {
            if (EstaVacia()) throw new InvalidOperationException("List Underflow");
            Item item;
            if (Tamaño() == 1)
            {
                item = ultimo.item;
                ultimo = null;
                primero = ultimo;
            }
            else {
                item = ultimo.item;
                ultimo = ultimo.ant;
                ultimo.sig = null;
            }
            N--;
            return item;
        }

        public void Remover(Item item)
        {
            if (EstaVacia()) throw new InvalidOperationException("List is Empty");

            NodoDoble head = primero;

            // if primero element in list equals to item, Remover
            if (head.item.Equals(item))
            {
                primero = primero.sig;
                if (primero != null) primero.ant = null;
                N--;
            }

            while (head.sig != null)
            {
                if (head.sig.item.Equals(item))
                {
                    head.sig = head.sig.sig;
                    if (head.sig != null) head.sig.ant = head;
                    else ultimo = head;
                    N--;
                    continue;
                }
                head = head.sig;
            }
        }

        // Este codigo sirve para poder recorrer la lista con un foreach
        public IEnumerator<Item> GetEnumerator()
        {
            NodoDoble actual = primero;
            int size = N;

            while (actual != null)
            {
                yield return actual.item;
                actual = actual.sig;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    /*
    private int n;        // number of elements on list
    private Node pre;     // sentinel before first item
    private Node post;    // sentinel after last item

    public ListaDoble()
    {
        pre = new Node();
        post = new Node();
        pre.next = post;
        post.prev = pre;
    }

    // linked list node helper data type
    private class Node
    {
        public Item item;
        public Node next;
        public Node prev;
    }

    public bool isEmpty() { return n == 0; }
    public int size() { return n; }

    // add the item to the list
    public void add(Item item)
    {
        Node last = post.prev;
        Node x = new Node();
        x.item = item;
        x.next = post;
        x.prev = last;
        post.prev = x;
        last.next = x;
        n++;
    }

    public override string ToString()
    {
        StringBuilder s = new StringBuilder();
        foreach (Item item in this)
            s.Append(item + " ");
        return s.ToString();
    }

    public IEnumerator<Item> GetEnumerator()
    {
        Node actual = pre;
        int size = n;

        while (actual != null)
        {
            yield return actual.item;
            actual = actual.next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    */
}

