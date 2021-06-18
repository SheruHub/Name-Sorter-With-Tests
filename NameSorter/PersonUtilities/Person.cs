using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.PersonUtilities
{
   public class Person : IComparable, IPerson
   {
      private string _surname;
      public string Surname { get => _surname; set => _surname = value; }

      private string[] _givenNames;
      public string[] GivenNames { get => _givenNames; set => _givenNames = value; }
      private Settings _settings;

      public Person(string[] givenNames, string surname, Settings settings)
      {
         GivenNames = givenNames;
         Surname = surname;
         _settings = settings;
      }

      public int numGivenNames()
      {
         return GivenNames.Length;
      }

      public override string ToString()
      {
         return string.Join(_settings.NameDelimiter, GivenNames);
      }

      public int CompareTo(object obj)
      {
         if (obj == null) return 1;
         IPerson otherPerson = obj as IPerson;

         int maxNames = Math.Min(this.numGivenNames(), otherPerson.numGivenNames());

         // Compare surname
         int compareSurname = String.Compare(this.Surname, otherPerson.Surname);         
         if (compareSurname != 0) return compareSurname;

         // Compare each given name
         int givenCompare;
         for (int i = 0; i < maxNames; i++) {
            givenCompare = String.Compare(this.GivenNames[i], otherPerson.GivenNames[i]);
            if (givenCompare != 0) return givenCompare;
         }

         // Compare number of names
         int numNamesCompare = this.numGivenNames().CompareTo(otherPerson.numGivenNames());
         if (numNamesCompare != 0) return numNamesCompare;

         return 0;
      }
   }
}
