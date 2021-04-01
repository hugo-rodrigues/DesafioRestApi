using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi.Model
{
    [Table("Aluno")]
    public class Aluno
    {
        [Column("id")]
        public long  Id {get; set;}
        [Column("Nome")]
        public string Nome { get; set; }
        [Column("Nota")]
        public float Nota { get; set; }

        [Column("TurmaId")]
        public long TurmaId { get; set; }

        
    }
}
