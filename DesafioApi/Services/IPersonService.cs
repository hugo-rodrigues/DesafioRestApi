using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioApi.Model;

namespace DesafioApi.Services
{
    public interface IPersonService
    {

        Person Create (Person person);
        Person FindById(long  Id);
        void Delete(long Id);

        List<Person> FindAll();
        Person Update(Person person);
    }
}
