using NameSorter.PersonUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.FileUtilities
{
   /// <summary>
   /// IFileResults
   /// Used to hold both valid and invalid data from a file
   /// </summary>
   interface IFileResults
   {
      public IPersonCollection PersonCollection { get; }
      public List<string> InvalidLines { get; }

      public string[] ToOutputArray();

   }
}
