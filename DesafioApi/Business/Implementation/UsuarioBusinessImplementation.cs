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

        public Usuario Create (Usuario usuario)
        {
            return _repository.Create(usuario);
        }

        public void Delete (long id)
        {
            _repository.Delete(id);
        }

        public bool Exists(long id)
        {
            return _repository.Exists(id);
        }

        public List<Usuario> FindAll()
        {
            return _repository.FindAll();
        }

     

        public Usuario FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Usuario Update(Usuario usuario)
        {
            return _repository.Update(usuario);
        }


    }
}
