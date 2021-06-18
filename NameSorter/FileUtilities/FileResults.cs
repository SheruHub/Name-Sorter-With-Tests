using NameSorter.PersonUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.FileUtilities
{
   class FileResults : IFileResults
   {
      public IPersonCollection PersonCollection { get; }
      public List<string> InvalidLines { get; }

      public FileResults(IPersonCollection personCollection)
      {
         PersonCollection = personCollection;
         InvalidLines = new();
      }

      /// <summary>
      /// Output file results in a human readable format separated into sorted and invalid names
      /// </summary>
      /// <returns>string array of the file results</returns>
      public string[] ToOutputArray()
      {
         List<string> formatted = new();
         formatted.Add("Sorted Names:\n---------------------------------------------");
         foreach(string name in PersonCollection.toStringArray()) {
            formatted.Add(name);
         }
         formatted.Add("\nInvalid Names:\n---------------------------------------------");
         foreach (string line in InvalidLines) {
            formatted.Add(line);
         }

         return formatted.ToArray();
      }

   }
}
