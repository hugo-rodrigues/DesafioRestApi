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

        public Aluno Create(Aluno aluno)
        {
            return _repository.Create(aluno);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public bool Exists(long id)
        {
            return _repository.Exists(id);
        }

        public List<Aluno> FindAll()
        {
            return _repository.FindAll();
        }



        public Aluno FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Aluno Update(Aluno aluno)
        {
            return _repository.Update(aluno);
        }
    }
}
