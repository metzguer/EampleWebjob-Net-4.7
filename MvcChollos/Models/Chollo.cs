using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcChollos.Models
{
    [Table("Chollos")]
    public class Chollo
    {
        public int Id { get; set; }
        [Column("titulo")]
        public string Titulo { get; set; }
        [Column("enlace")]
        public string Enlace { get; set; }
        [Column("descripcion")]
        public string Descripcion { get; set; }
        [Column("categoria")]
        public string Categoria { get; set; }
    }
}