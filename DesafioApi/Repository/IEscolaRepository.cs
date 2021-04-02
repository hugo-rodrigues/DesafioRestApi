using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioApi.Model;

namespace DesafioApi.Repository
{
    public interface IEscolaRepository
    {

        Escola Create(Escola escola);
        Escola FindById(long id);
        List<Escola> FindAll();
        Escola Update(Escola escola);
        void Delete(long id);

        bool Exists(long id);

        public string MediaDosAlunosPorTurma(long id);

        public string ListaDosAlunosPorTurma(long id);

        public bool ExistsTurmasComEscola(long id);
    }
}
