using System.Windows.Input;
using BibliotecaApp.Services;
using BibliotecaApp.Models;

public class AgregarLibroViewModel
{
    private readonly BibliotecaService _bibliotecaService;

    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public int CantidadCopias { get; set; }
    public ICommand AgregarLibroCommand { get; }

    // Define un evento para notificar que se ha agregado un libro
    public event Action<Libro> LibroAgregado;

    public AgregarLibroViewModel(BibliotecaService bibliotecaService)
    {
        _bibliotecaService = bibliotecaService;
        AgregarLibroCommand = new Command(AgregarLibro);
    }

    private void AgregarLibro()
    {
        var libro = new Libro(Titulo, Autor, ISBN, CantidadCopias);
        _bibliotecaService.AddLibro(libro); // Agrega el libro al servicio
        
        // Dispara el evento para notificar que se ha agregado un libro
        LibroAgregado?.Invoke(libro);
    }
}
