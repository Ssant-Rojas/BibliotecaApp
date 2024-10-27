using BibliotecaApp.Models;
using BibliotecaApp.Services;
using System.Collections.ObjectModel;

namespace BibliotecaApp.ViewModels
{
    public class MostrarCatalogoViewModel
    {
        private readonly BibliotecaService _bibliotecaService;
        private BibliotecaService bibliotecaService;

        public ObservableCollection<Libro> Libros { get; private set; }

        public MostrarCatalogoViewModel(BibliotecaService bibliotecaService, AgregarLibroViewModel agregarLibroViewModel)
        {
            _bibliotecaService = bibliotecaService;
            Libros = new ObservableCollection<Libro>(_bibliotecaService.GetLibros());

            // Suscribirse al evento para recibir notificaciones de nuevos libros
            agregarLibroViewModel.LibroAgregado += OnLibroAgregado;
        }

        public MostrarCatalogoViewModel(BibliotecaService bibliotecaService)
        {
            this.bibliotecaService = bibliotecaService;
        }

        private void OnLibroAgregado(Libro libro)
        {
            // Agregar el libro a la colección observable
            Libros.Add(libro);
        }
    }
}
