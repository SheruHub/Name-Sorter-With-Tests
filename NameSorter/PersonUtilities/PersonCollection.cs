using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.PersonUtilities
{
   class PersonCollection : IPersonCollection
   {
      private List<IPerson> People { get; set; }

      public PersonCollection()
      {
         People = new();

      }

      public void add(IPerson person)
      {
         People.Add(person);
      }

      public void sort()
      {
         // Sorts on Person's ICompare
         People.Sort();
      }

      public string[] toStringArray()
      {
         string[] people = new string[People.Count()];
         for (int i = 0; i < People.Count(); i++) {
            people[i] = People[i].ToString();
         }
         return people;
      }

   }
}
