using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using BibliotecaApp.Models;
using BibliotecaApp.Services;
using Microsoft.Maui.Controls;

namespace BibliotecaApp.ViewModels
{
    public class BibliotecaViewModel : INotifyPropertyChanged
    {
        private readonly BibliotecaService _bibliotecaService;
        public ObservableCollection<Libro> Libros { get; }
        public ObservableCollection<Usuario> Usuarios { get; }

        public BibliotecaViewModel()
        {
            _bibliotecaService = new BibliotecaService();
            Libros = new ObservableCollection<Libro>(_bibliotecaService.GetLibros());
            Usuarios = new ObservableCollection<Usuario>(_bibliotecaService.GetUsuarios());

            AgregarLibroCommand = new Command(AgregarLibro);
            RegistrarUsuarioCommand = new Command(RegistrarUsuario);
            PrestarLibroCommand = new Command(PrestarLibro);
            DevolverLibroCommand = new Command(DevolverLibro);
        }

        public ICommand AgregarLibroCommand { get; }
        public ICommand RegistrarUsuarioCommand { get; }
        public ICommand PrestarLibroCommand { get; }
        public ICommand DevolverLibroCommand { get; }

        public void AgregarLibro()
        {
            var nuevoLibro = new Libro("Nuevo Libro", "Autor", "ISBN123", 5);
            Libros.Add(nuevoLibro);
            _bibliotecaService.AddLibro(nuevoLibro);
            OnPropertyChanged(nameof(Libros));
        }

        public void RegistrarUsuario()
        {
            var nuevoUsuario = new Usuario("Nuevo Usuario", Usuarios.Count + 1);
            Usuarios.Add(nuevoUsuario);
            _bibliotecaService.AddUsuario(nuevoUsuario);
            OnPropertyChanged(nameof(Usuarios));
        }

        public void PrestarLibro()
        {
        }

        public void DevolverLibro()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
