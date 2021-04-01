using DesafioApi.Model;
using DesafioApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi.Business.Implementation
{
    public class AlunoBusinessImplementation : IAlunoBusiness
    {

        private readonly IAlunoRepository _repository;
        public AlunoBusinessImplementation(IAlunoRepository repository)
        {
            _repository = repository;
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
