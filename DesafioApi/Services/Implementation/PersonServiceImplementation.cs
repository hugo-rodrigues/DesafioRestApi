using DesafioApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi.Services.Implementation
{

    public class PersonServiceImplementation : IPersonService
    {

        private MysqlContext _context;
        public PersonServiceImplementation(MysqlContext context)
        {
            _context = context;
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
            return _context.Persons.ToList();
        }

        public Person Findbyid (long id)
        {
            return new Person
            {
                Id = 1,
                FullName = "Roberto Carlos",
                Acesso = 2
            };
        }

        public Person Update(Person person)
        {
            return person;
        }


    }
}
