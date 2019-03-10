using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Familytree.Models
{
    public class DateFormat
    {
        DateTime nullStandard = new DateTime(0001, 01, 01);
       public string GetDateForIndividual(DateTime date)
        {
            if()
            return date.ToString("dd. MMMM yyyy", new CultureInfo("da-DK"));
        }
        public string GetDateForAll(Person person)
        {
            string birthYear= person.BirthDate.ToString("yyyy");
            if (person.DeathDate.Year==0001)
            {

                return birthYear;
            }
            else
            {
                string deathYear = person.DeathDate.ToString("yyyy");
                return  String.Format("{0}-{1}", birthYear, deathYear);

               
            }
            
        }
        
      

    }
}
