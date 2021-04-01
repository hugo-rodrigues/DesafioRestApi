using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioApi.Model;

namespace DesafioApi.Repository
{
    public interface ITurmaRepository
    {

        Usuario Create(Turma turma);
        Usuario FindById(long id);
        List<Turma> FindAll();
        Usuario Update(Turma turma);
        void Delete(long id);

        bool Exists(long id);

        public string MediaDosAlunosPorTurma();

        public string ListaDosAlunosPorTurma();
    }
}
