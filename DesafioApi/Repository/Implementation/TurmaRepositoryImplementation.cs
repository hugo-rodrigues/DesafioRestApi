using DesafioApi.Model;
using DesafioApi.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi.Repository.Implementation
{
    public class TurmaRepositoryImplementation : ITurmaRepository
    {
        private MySQLContext _context;
        public TurmaRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }

        public Usuario Create(Turma turma)
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

        public List<Turma> FindAll()
        {
            throw new NotImplementedException();
        }

        public Usuario FindById(long id)
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

        public Usuario Update(Turma turma)
        {
            throw new NotImplementedException();
        }
    }
}
