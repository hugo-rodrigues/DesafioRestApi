using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi.Model
{
    [Table("Escola")]
    public class Escola
    {
        [Column("id")]
        public long  Id {get; set;}
        [Column("Nome")]
        public string Nome { get; set; }

        public string MediaDosAlunosPorTurma { get; set; }

        public string ListaDosAlunosPorTurma { get; set; }
    }
}
