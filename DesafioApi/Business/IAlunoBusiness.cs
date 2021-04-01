using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioApi.Model;

namespace DesafioApi.Business
{
    public interface IAlunoBusiness
    {

        Usuario Create(Aluno aluno);
        Usuario FindById(long id);
        List<Aluno> FindAll();
        Usuario Update(Aluno aluno);
        void Delete(long id);

        bool Exists(long id);

    }
}
