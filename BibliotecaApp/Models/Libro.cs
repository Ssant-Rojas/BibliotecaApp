namespace BibliotecaApp.Models;

public class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public int CantidadCopias { get; set; }

    public Libro(string titulo, string autor, string isbn, int cantidadcopias)
    {
        Titulo = titulo;
        Autor = autor;
        ISBN = isbn;
        CantidadCopias = cantidadcopias;
    }
}

