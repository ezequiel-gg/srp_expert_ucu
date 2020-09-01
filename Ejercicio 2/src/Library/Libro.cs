using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }  // faltan los setters para encapsularlo
        public string Autor { get ; } // faltan los setters para encapsularlo, además se podría crear una clase autor para que sea más escalable
        public string Codigo { get ;  } // faltan los setters para encapsularlo
        public string SectorBiblioteca { get ; set; }  // se podria generar otra clase Biblioteca para establecer los sectores y estantes 
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante) // se lo asignaria a otra clase esta responsabilidad
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
