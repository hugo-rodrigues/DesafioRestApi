using DesafioApi.Model;
using DesafioApi.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi.Repository.Implementation
{
    public class EscolaRepositoryImplementation : IEscolaRepository
    {
        private MySQLContext _context;
        public EscolaRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }



        public Usuario Create(Escola escola)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(long id)
        {
            throw new NotImplementedException();
        }

        public List<Escola> FindAll()
        {
            throw new NotImplementedException();
        }

        public Usuario FindById(long id)
        {
            throw new NotImplementedException();
        }

        public Usuario Update(Escola escola)
        {
            throw new NotImplementedException();
        }

       public string ListaDosAlunosPorTurma()
        {
            throw new NotImplementedException();
        }

        public string MediaDosAlunosPorTurma()
        {
            throw new NotImplementedException();
        }
    }
}
