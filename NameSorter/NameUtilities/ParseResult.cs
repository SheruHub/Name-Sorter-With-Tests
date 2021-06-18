using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.NameUtilities
{
   public class ParseResult : IParseResult
   {
      public bool Success { get; set; }
      public string[] GivenNames { get; set; }
      public string Surname { get; set; }
      public string Line { get; set; }


   }
}
