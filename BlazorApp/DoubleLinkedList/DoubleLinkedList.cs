using System;
using BlazorApp.Models;

public class DoubleLinkedList
{
    public Nodo PrimerNodo { get; set; }
    public Nodo UltimoNodo { get; set; }
    public Nodo NodoActual { get; set; }

    public void AgregarNodoAlInicio(Nodo nuevoNodo)
    {
        if (PrimerNodo == null)
        {
            PrimerNodo = nuevoNodo;
            UltimoNodo = nuevoNodo;
        }
        else
        {
            nuevoNodo.Siguiente = PrimerNodo;
            PrimerNodo.Anterior = nuevoNodo;
            PrimerNodo = nuevoNodo;
        }
        NodoActual = PrimerNodo;
    }

    public void InsertBefore(Nodo nodoActual, Nodo nuevoNodo)
    {
        if (nodoActual == null || nuevoNodo == null)
        {
            return;
        }

        nuevoNodo.Anterior = nodoActual.Anterior;
        nuevoNodo.Siguiente = nodoActual;

        if (nodoActual.Anterior != null)
        {
            nodoActual.Anterior.Siguiente = nuevoNodo;
        }
        else
        {
            PrimerNodo = nuevoNodo;
        }

        nodoActual.Anterior = nuevoNodo;
    }

    public void InsertAfter(Nodo nodoActual, Nodo nuevoNodo)
    {
        if (nodoActual == null || nuevoNodo == null)
        {
            return;
        }

        nuevoNodo.Anterior = nodoActual;
        nuevoNodo.Siguiente = nodoActual.Siguiente;

        if (nodoActual.Siguiente != null)
        {
            nodoActual.Siguiente.Anterior = nuevoNodo;
        }
        else
        {
            UltimoNodo = nuevoNodo;
        }

        nodoActual.Siguiente = nuevoNodo;
    }
}
