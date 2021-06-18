using System.Collections;

namespace NameSorter.PersonUtilities
{
   /// <summary>
   /// IPersonCollection
   /// A collection of IPersons
   /// </summary>
   interface IPersonCollection
   {
      void sort();
      void add(IPerson person);
      string[] toStringArray();
   }
}