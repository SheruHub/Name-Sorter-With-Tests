using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
   /// <summary>
   /// General program settings/variables
   /// </summary>
   public class Settings
   {
      public string NameDelimiter { get; set; }

      public int MinGivenNames { get; set; }
      public int MaxGivenNames { get; set; }

      public string InputFilename { get; set; }
      public string OutputFilename { get; set; }

      public Settings()
      {
         NameDelimiter = " ";
         MinGivenNames = 1;
         MaxGivenNames = 3;
         InputFilename = Directory.GetCurrentDirectory() + @"\unsorted-names-list.txt";
         OutputFilename = Directory.GetCurrentDirectory() + @"\sorted-names-list.txt";
      }

   }
}
