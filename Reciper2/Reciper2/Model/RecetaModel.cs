using System;
using System.Collections.Generic;
using System.Text;

namespace Reciper2.Model
{
    public class RecetaModel
    {
        public string nombre { get; set; }
        public string imagen { get; set; }
        public string calorias { get; set; }

        public List<string> ingredientes { get; set; }
        public List<string> especificacionesDieteticas { get; set; }
        public List<string> especificacionesSanitarias { get; set; }


        public RecetaModel(string Nombre, string Imagen, string Calorias, List<string> Ingredientes, 
            List<string> dieta, List<string> saludable)
        {
            this.nombre = Nombre;
            this.imagen = Imagen;
            this.calorias = Calorias;
            this.ingredientes = Ingredientes;
            this.especificacionesDieteticas = dieta;
            this.especificacionesSanitarias = saludable;
        }
    }
}
