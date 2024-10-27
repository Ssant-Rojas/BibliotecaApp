using Microsoft.Maui.Controls; // Asegúrate de tener esta referencia
using BibliotecaApp.Views; // Asegúrate de que el espacio de nombres sea correcto
using BibliotecaApp.ViewModels; // Espacio de nombres para los ViewModels

namespace BibliotecaApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Registrar rutas para la navegación
            Routing.RegisterRoute(nameof(AgregarLibroPage), typeof(AgregarLibroPage));
            Routing.RegisterRoute(nameof(MostrarCatalogoPage), typeof(MostrarCatalogoPage)); 
            Routing.RegisterRoute(nameof(RegistrarUsuarioPage), typeof(RegistrarUsuarioPage));


            var mainViewModel = new MainViewModel();

            MainPage = new AppShell();
        }
    }
}
