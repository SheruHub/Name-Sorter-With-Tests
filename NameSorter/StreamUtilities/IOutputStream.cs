using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.StreamUtilities
{
   /// <summary>
   /// IOutputStream
   /// Write a string array to an output stream
   /// </summary>
   interface IOutputStream
   {
      public void Write(string[] data);
   }
}
