using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioApi.Model;

namespace DesafioApi.Repository
{
    public interface IEscolaRepository
    {

        Usuario Create(Escola escola);
        Usuario FindById(long id);
        List<Escola> FindAll();
        Usuario Update(Escola escola);
        void Delete(long id);

        bool Exists(long id);

        public string MediaDosAlunosPorTurma();

        public string ListaDosAlunosPorTurma();
    }
}
