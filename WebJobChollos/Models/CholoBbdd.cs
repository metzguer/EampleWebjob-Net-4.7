using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebJobChollos.Models
{
    [Table("Chollos")]
    public class CholoBbdd
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //[Column("id")]
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
