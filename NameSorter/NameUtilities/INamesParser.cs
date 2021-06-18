using System.Collections;
using System.Collections.Generic;

namespace NameSorter.NameUtilities
{
   /// <summary>
   /// INamesParser
   /// Used to parse a string to a name
   /// </summary>
   public interface INamesParser
   {
      IParseResult Parse(string line);
   }
}