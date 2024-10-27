namespace BibliotecaApp.Models;

public class Usuario
{
    public string Nombre { get; set; }
    public int ID { get; set; }

    public Usuario(string nombre, int id)
    {
        Nombre = nombre;
        ID = id;
    }
}
