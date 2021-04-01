using DesafioApi.Model;
using DesafioApi.Model.Context;
using DesafioApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi.Business.Implementation
{

    public class UsuarioBusinessImplementation : IUsuarioBusiness
    {

        private readonly IUsuarioRepository _repository;
        public UsuarioBusinessImplementation(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public Usuario Create (Usuario person)
        {
            return person;
        }

        public void Delete (long id)
        {

        }

        public bool Exists(long id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> FindAll()
        {
            return _repository.FindAll();
        }

     

        public Usuario FindById(long Id)
        {
            throw new NotImplementedException();
        }

        public Usuario Update(Usuario usuario)
        {
            return usuario;
        }


    }
}
