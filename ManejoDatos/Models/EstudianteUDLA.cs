using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDatos.Models
{
    [Table("estudiante")]
    public class EstudianteUDLA
    {
        [PrimaryKey, AutoIncrement]
        public int Id {  get; set; }
        [MaxLength(200)]
        public string Nombre { get; set; }
        [MaxLength(100)]
        public string Carrera { get; set; }

    }
}
