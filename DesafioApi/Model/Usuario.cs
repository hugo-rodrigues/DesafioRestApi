using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi.Model
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("id")]
        public long  Id {get; set;}
        [Column("Nome")]
        public string Nome { get; set; }
        [Column("Perfil")]
        public string Perfil { get; set; }
    }
}
