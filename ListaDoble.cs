public class ListaDoble
{
    private NodoDoble cabeza;
    private NodoDoble cola;

    public ListaDoble()
    {
        cabeza = null;
        cola = null;
    }

    public bool EstaVacia()
    {
        return cabeza == null;
    }

    public void AgregarAlInicio(PaginaWeb pagina)
    {
        NodoDoble nuevo = new NodoDoble(pagina);
        if (EstaVacia())
        {
            cabeza = nuevo;
            cola = nuevo;
        }
        else
        {
            nuevo.Siguiente = cabeza;
            cabeza.Anterior = nuevo;
            cabeza = nuevo;
        }
    }

    public void AgregarAlFinal(PaginaWeb pagina)
    {
        NodoDoble nuevo = new NodoDoble(pagina);
        if (EstaVacia())
        {
            cabeza = nuevo;
            cola = nuevo;
        }
        else
        {
            cola.Siguiente = nuevo;
            nuevo.Anterior = cola;
            cola = nuevo;
        }
    }

    public void Eliminar(string url)
    {
        if (EstaVacia())
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        NodoDoble actual = cabeza;
        while (actual != null)
        {
            if (actual.Dato.Url == url)
            {
                if (actual == cabeza && actual == cola)
                {
                    cabeza = null;
                    cola = null;
                }
                else if (actual == cabeza)
                {
                    cabeza = cabeza.Siguiente;
                    cabeza.Anterior = null;
                }
                else if (actual == cola)
                {
                    cola = cola.Anterior;
                    cola.Siguiente = null;
                }
                else
                {
                    actual.Anterior.Siguiente = actual.Siguiente;
                    actual.Siguiente.Anterior = actual.Anterior;
                }
                Console.WriteLine("Página eliminada del historial.");
                return;
            }
            actual = actual.Siguiente;
        }
        Console.WriteLine("Página no encontrada.");
    }

    public void ImprimirAdelante()
    {
        if (EstaVacia())
        {
            Console.WriteLine("Historial vacío.");
            return;
        }
        Console.WriteLine("\n--- HITSORIAL (Inicio a Fin) ---");
        NodoDoble actual = cabeza;
        while (actual != null)
        {
            Console.WriteLine("[" + actual.Dato.Titulo + " - " + actual.Dato.Url + "]");
            actual = actual.Siguiente;
        }
    }

    public void ImprimirAtras()
    {
        if (EstaVacia())
        {
            Console.WriteLine("Historial vacío.");
            return;
        }
        Console.WriteLine("\n--- HISTORIAL (Fin a Inicio) ---");
        NodoDoble actual = cola;
        while (actual != null)
        {
            Console.WriteLine("[" + actual.Dato.Titulo + " - " + actual.Dato.Url + "]");
            actual = actual.Anterior;
        }
    }

    public NodoDoble Cabeza
    {
        get { return cabeza; }
    }

    public NodoDoble Cola
    {
        get { return cola; }
    }
}