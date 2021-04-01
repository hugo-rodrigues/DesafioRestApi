using DesafioApi.Model;
using DesafioApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi.Business.Implementation
{
    public class TurmaBusinessImplementation : ITurmaBusiness
    {
        private readonly ITurmaRepository _repository;
        public TurmaBusinessImplementation(ITurmaRepository repository)
        {
            _repository = repository;
        }

        public Usuario Create(Usuario usuario)
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

        public List<Usuario> FindAll()
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

        public Usuario Update(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
