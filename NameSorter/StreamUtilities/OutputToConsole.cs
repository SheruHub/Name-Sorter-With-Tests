using NameSorter.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.StreamUtilities
{
   class OutputToConsole : IOutputStream
   {
      private IMessager _messager;
      public OutputToConsole(IMessager messager)
      {
         _messager = messager;
      }
      public void Write(string[] data)
      {
         foreach(string line in data) {
            _messager.sendMessage(line);
         }
      }
   }
}
