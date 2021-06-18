using NameSorter.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NameSorter.FileUtilities
{
   class FileHandler : IFileHandler
   {
      private IMessager _messager;
      public FileHandler(IMessager messager)
      {
         _messager = messager;
      }

      // write file
      public void writeTextFile(string filePath, string[] lines)
      {
         File.WriteAllLines(filePath, lines);
         _messager.sendMessage($"file written: {filePath}");
      }

      /// <summary>
      /// Read a file
      /// </summary>
      /// <param name="filePath">The path and filename of the file</param>
      /// <returns>yield lines of the file</returns>
      public IEnumerable<string> readLines(string filePath)
      {
         using var reader = new StreamReader(filePath);
         while (!reader.EndOfStream) {            
            yield return reader.ReadLine();
         }

      }
   }
}
