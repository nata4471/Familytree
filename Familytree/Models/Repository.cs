using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Familytree.Models
{
    public class Repository
    {
        public List<Person> DanishRoyalFamily = new List<Person>()
        {
            new Person() {Id=1, Name = "Frederik 9.", BirthDate=new DateTime(1899, 03,11), DeathDate=new DateTime(1972, 01,14)},
            new Person(){Id=2, Name="Margrethe 2.", BirthDate=new DateTime(1940, 04,16) },
            new Person(){Id=3, Name="Benedikte" , BirthDate=new DateTime(1944, 04,29)},
            new Person(){Id=4, Name="Anne Marie",  BirthDate=new DateTime(1946, 08,30)},
            new Person(){Id=5, Name="Frederik", BirthDate=new DateTime(1968, 05,26)},
            new Person(){Id=6, Name="Joachim", BirthDate=new DateTime(1969, 06,07)},
            new Person(){Id=7, Name="Christan", BirthDate=new DateTime(2005, 10,15)},
            new Person(){Id=8, Name="Isabella", BirthDate=new DateTime(2007, 4,21)},
            new Person(){Id=9, Name="Vincent", BirthDate=new DateTime(2011, 01,08)},
            new Person(){Id=10, Name="Josephine", BirthDate=new DateTime(2011, 01,08)},
            new Person(){Id=11,Name="Nikolai", BirthDate=new DateTime(1999, 08,28)},
            new Person(){Id=12, Name="Felix", BirthDate=new DateTime(2002, 07,22)},
            new Person(){Id=13, Name="Henrik", BirthDate=new DateTime(2009, 04,04)},
            new Person(){Id=14, Name="Athena", BirthDate=new DateTime(2012, 01,24)},
            new Person(){Id=15, Name="Gustav", BirthDate=new DateTime(1969, 01,12)},
            new Person(){Id=16, Name="Alexandra", BirthDate=new DateTime(1970, 11,20)},
            new Person(){Id=17, Name="Nathalie", BirthDate=new DateTime(1975, 05,02)},

            new Person(){Id=18, Name="Christian 10.", BirthDate=new DateTime(1870, 09,26), DeathDate=new DateTime(1947, 04,20)},
            new Person(){Id=19, Name="Knud", BirthDate=new DateTime(1900, 07,27), DeathDate=new DateTime(1976,06,14)},
            new Person(){Id=20, Name="Elisabeth" , BirthDate=new DateTime(1935, 05,08), DeathDate=new DateTime(2018, 05, 08)},
            new Person(){Id=21, Name="Ingolf", BirthDate=new DateTime(1940, 02,17)},
            new Person(){Id=22, Name="Christian" , BirthDate=new DateTime(1942, 10,22), DeathDate=new DateTime(2013, 05, 21)}

        };
        public Repository()
        {
            CreateRelationships();
        }

        public void CreateRelationships()
        {

           
            var frederik9 = DanishRoyalFamily[0];

            var margrethe = DanishRoyalFamily[1];

           var benedikte = DanishRoyalFamily[2];

        var anneMarie = DanishRoyalFamily[3];
            var frederik = DanishRoyalFamily[4];
            var joachim = DanishRoyalFamily[5];
            var christian = DanishRoyalFamily[6];
            var isabella = DanishRoyalFamily[7];
            var vincent = DanishRoyalFamily[8];
            var josephine = DanishRoyalFamily[9];
            var nikolai = DanishRoyalFamily[10];
            var felix = DanishRoyalFamily[11];
            var henrik = DanishRoyalFamily[12];
            var athena = DanishRoyalFamily[13];
            var gustav = DanishRoyalFamily[14];
            var alexandra = DanishRoyalFamily[15];
            var nathalie = DanishRoyalFamily[16];

            var christian10 = DanishRoyalFamily[17];
            var knud = DanishRoyalFamily[18];
            var elisabeth = DanishRoyalFamily[19];
            var ingolf = DanishRoyalFamily[20];
            var otherChristian = DanishRoyalFamily[21];

            CreateRelationship(frederik9, margrethe);
            CreateRelationship(frederik9, benedikte);
            CreateRelationship(frederik9, anneMarie);
            

            CreateRelationship(margrethe, frederik);
            CreateRelationship(margrethe, joachim);

            CreateRelationship(benedikte, gustav);
            CreateRelationship(benedikte, alexandra);
            CreateRelationship(benedikte, nathalie);

            CreateRelationship(frederik, christian);
            CreateRelationship(frederik, isabella);
            CreateRelationship(frederik, vincent);
            CreateRelationship(frederik, josephine);

            CreateRelationship(joachim, nikolai);
            CreateRelationship(joachim, felix);
            CreateRelationship(joachim, henrik);
            CreateRelationship(joachim, athena);

            CreateRelationship(christian10, frederik9);
            CreateRelationship(christian10, knud);

            CreateRelationship(knud, elisabeth);
            CreateRelationship(knud, ingolf);
            CreateRelationship(knud, otherChristian);

        }
        public void CreateRelationship(Person parent, Person child)
        {
            int parentIndex = DanishRoyalFamily.FindIndex(x => x.Id == parent.Id);
            int ChildIndex = DanishRoyalFamily.FindIndex(x => x.Id == child.Id);
            CreateParent(parentIndex, ChildIndex);
            CreateChild(parentIndex, ChildIndex);

        }
        public void CreateParent(int ParentIndex, int ChildIndex)
        {
            DanishRoyalFamily[ChildIndex].Parent=DanishRoyalFamily[ParentIndex];
        }
        public void CreateChild(int ParentIndex, int ChildIndex)
        {
            DanishRoyalFamily[ParentIndex].Children.Add(DanishRoyalFamily[ChildIndex]);
        }
    }
}
