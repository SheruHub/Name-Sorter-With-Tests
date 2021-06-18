using NameSorter.FileUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.StreamUtilities
{
   class OutputToFile : IOutputStream
   {
      private IFileHandler _fileHandler;
      private Settings _settings;

      public OutputToFile(IFileHandler fileHandler, Settings settings)
      {
         _fileHandler = fileHandler;
         _settings = settings;
      }
      public void Write(string[] data)
      {
         _fileHandler.writeTextFile(_settings.OutputFilename, data);

      }
   }
}
