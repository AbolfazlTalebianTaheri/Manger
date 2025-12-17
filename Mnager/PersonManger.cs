using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnager
{
    public class PersonManger
    {
        static List<Person> persons;
        public PersonManger()
        {
            if(persons ==null)
                persons = new List<Person>();
        }
        public IReadOnlyList<Person> GetPerson()
        {
            return persons;
        }
        public int Count()
        {
            return persons.Count;
        }
        public void RemovePerson(Person person)
        {
            persons.Remove(person);
        }

        public void Add(Person person)
        {
            persons.Add(person);
        }
    }
}
