using System.Collections.Generic;
using System.Diagnostics; // Necesario para Debug.WriteLine
using BibliotecaApp.Models;

namespace BibliotecaApp.Services
{
    public class BibliotecaService
    {
        private List<Libro> libros = new List<Libro>();
        private List<Usuario> usuarios = new List<Usuario>();

        public BibliotecaService()
        {
            libros.Add(new Libro("El Principito", "Antoine de Saint-Exupéry", "978-3-16-148410-0", 5));
        } 

        public void AddLibro(Libro libro)
        {
            libros.Add(libro);
        }

        public void AddUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public List<Libro> GetLibros()
        {
            foreach (var libro in libros)
            {
                Debug.WriteLine($"Título: {libro.Titulo}, Autor: {libro.Autor}, ISBN: {libro.ISBN}, Cantidad: {libro.CantidadCopias}");
            }
            return libros;
        }

        public List<Usuario> GetUsuarios()
        {
            return usuarios;
        }
    }
}
