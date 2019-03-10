using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Familytree.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
        public Person Parent { get; set; }
        public List<Person> Children { get; set; } = new List<Person>();
      public DateTime BirthDate { get; set; }
        public DateTime DeathDate { get; set; }
    }
}
