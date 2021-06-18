using System.Collections.Generic;

namespace NameSorter.FileUtilities
{
   /// <summary>
   /// Interface IFileHandler
   /// Used to read and write to files
   /// </summary>
   interface IFileHandler
   {
      IEnumerable<string> readLines(string filePath);
      void writeTextFile(string filePath, string[] lines);
   }
}