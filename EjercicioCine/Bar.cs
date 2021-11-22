using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioCine
{
    class Bar
    {
        public string Producto { get; set; }
     
        public string ProductosIncluidos()
        {
            return this.Producto = "Nachos, Doritos, Papitas ,HotDog, Canguil";

        }
        public string ProductoSeleccionado()
        {
            return this.Producto ="";

        }

    }
}
