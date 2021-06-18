using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.NameUtilities
{
   /// <summary>
   /// IParseResult
   /// Holds the result of the parsed name.
   /// </summary>
   public interface IParseResult
   {
      bool Success { get; set; }
      string[] GivenNames { get; set; }
      string Surname { get; set; }
      string Line { get; set; }

   }
}
