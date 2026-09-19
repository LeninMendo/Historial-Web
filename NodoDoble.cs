public class NodoDoble
{
    private PaginaWeb dato;
    private NodoDoble siguiente;
    private NodoDoble anterior;

    public NodoDoble(PaginaWeb dato)
    {
        this.dato = dato;
        this.siguiente = null;
        this.anterior = null;
    }

    public PaginaWeb Dato
    {
        get { return dato; }
        set { dato = value; }
    }

    public NodoDoble Siguiente
    {
        get { return siguiente; }
        set { siguiente = value; }
    }

    public NodoDoble Anterior
    {
        get { return anterior; }
        set { anterior = value; }
    }
}