using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPrestarLibro
{
    public class prestar_libros
    {
        public int ID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Matricula { get; set; }
        public string Categoria { get; set; }
        public string Libro { get; set; }
        public DateTime FechaDeAdquisicion { get; set; }
   
    }
}
