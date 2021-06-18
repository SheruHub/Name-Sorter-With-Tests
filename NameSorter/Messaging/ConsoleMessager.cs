using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Messaging
{
   /// <summary>
   /// Output messages to console
   /// </summary>
   public class ConsoleMessager : IMessager
   {
      public ConsoleMessager()
      {

      }
      void IMessager.sendMessage(string message)
      {

         Console.WriteLine(message);
      }
   }
}
