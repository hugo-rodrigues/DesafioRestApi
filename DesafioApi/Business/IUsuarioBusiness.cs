using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioApi.Model;

namespace DesafioApi.Business
{
    public interface IUsuarioBusiness
    {

        Usuario Create(Usuario usuario);
        Usuario FindById(long id);
        List<Usuario> FindAll();
        Usuario Update(Usuario usuario);
        void Delete(long id);

        bool Exists(long id);
    }
}
