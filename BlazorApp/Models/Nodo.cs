namespace BlazorApp.Models
{
    public class Nodo
    {
        public Nodo Anterior { get; set; }
        public Nodo Siguiente { get; set; }
        public string Informacion { get; set; }

        public Nodo(string informacion)
        {
            Informacion = informacion;
        }
    }

    public class DoubleLinkedList
    {
        public Nodo PrimerNodo { get; set; }
        public Nodo UltimoNodo { get; set; }
        public Nodo NodoActual { get; set; }

        public DoubleLinkedList()
        {
        }

        public string AgregarNodoAlInicio(Nodo nuevoNodo)
        {
            if (PrimerNodo == null)
            {
                PrimerNodo = nuevoNodo;
                UltimoNodo = nuevoNodo;
                NodoActual = nuevoNodo;
            }
            else
            {
                nuevoNodo.Siguiente = PrimerNodo;
                PrimerNodo.Anterior = nuevoNodo;
                PrimerNodo = nuevoNodo;
            }

            return "Nodo agregado exitosamente al inicio.";
        }

        public void Siguiente()
        {
            if (NodoActual != null && NodoActual.Siguiente != null)
            {
                NodoActual = NodoActual.Siguiente;
            }
        }

        public void Anterior()
        {
            if (NodoActual != null && NodoActual.Anterior != null)
            {
                NodoActual = NodoActual.Anterior;
            }
        }
    }
}

