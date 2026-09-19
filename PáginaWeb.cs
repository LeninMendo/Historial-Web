public class PaginaWeb
{
    private string url;
    private string titulo;

    public PaginaWeb(string url, string titulo)
    {
        this.url = url;
        this.titulo = titulo;
    }

    public string Url
    {
        get { return url; }
        set { url = value; }
    }

    public string Titulo
    {
        get { return titulo; }
        set { titulo = value; }
    }
}