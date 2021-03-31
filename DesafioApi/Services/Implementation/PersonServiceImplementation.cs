using DesafioApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi.Services.Implementation
{

    public class PersonServiceImplementation : IpersonService
    {

        public Person Create (Person person)
        {
            return person;
        }

        public void Delete (long id)
        {

        }

        public Person Findbyid (long Id)
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
