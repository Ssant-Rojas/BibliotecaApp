using BibliotecaApp.ViewModels;
using BibliotecaApp.Services;

namespace BibliotecaApp.Views
{
    public partial class MostrarCatalogoPage : ContentPage
    {
        public MostrarCatalogoPage()
        {
            InitializeComponent();

            // Establece el BindingContext a una nueva instancia de MostrarCatalogoViewModel
            BindingContext = new MostrarCatalogoViewModel(new BibliotecaService());
        }
    }
}
