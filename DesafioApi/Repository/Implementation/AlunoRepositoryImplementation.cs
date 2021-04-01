using DesafioApi.Model;
using DesafioApi.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi.Repository.Implementation
{
    public class AlunoRepositoryImplementation : IAlunoRepository
    {
        private MySQLContext _context;
        public AlunoRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }

        public Usuario Create(Aluno aluno)
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

        public List<Aluno> FindAll()
        {
            throw new NotImplementedException();
        }

        public Usuario FindById(long id)
        {
            throw new NotImplementedException();
        }

        public Usuario Update(Aluno aluno)
        {
            throw new NotImplementedException();
        }
    }
}
