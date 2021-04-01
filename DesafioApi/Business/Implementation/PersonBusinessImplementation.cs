using DesafioApi.Model;
using DesafioApi.Model.Context;
using DesafioApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi.Business.Implementation
{

    public class PersonBusinessImplementation : IPersonBusiness
    {

        private readonly IPersonRepository _repository;
        public PersonBusinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }

        public Person Create (Person person)
        {
            return person;
        }

        public void Delete (long id)
        {

        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

     

        public Person FindById(long Id)
        {
            throw new NotImplementedException();
        }

        public Person Update(Person person)
        {
            return person;
        }


    }
}
