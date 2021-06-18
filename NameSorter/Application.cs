using NameSorter.NameUtilities;
using NameSorter.PersonUtilities;
using NameSorter.Messaging;
using NameSorter.FileUtilities;
using NameSorter.StreamUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
   class Application : IApplication
   {
      IFileHandler _fileHandler;
      IFileResults _fileResults;
      INamesParser _namesParser;
      IMessager _messager;
      Settings _settings;
      IOutputStream _streamToConsole;
      IOutputStream _streamToFile;
      

      public Application(IFileHandler fileHandler, IFileResults fileResults, INamesParser namesParser, Settings settings, IMessager messager)
      {
         _fileHandler = fileHandler;
         _fileResults = fileResults;
         _namesParser = namesParser;
         _settings = settings;
         _messager = messager;
      }

      /// <summary>
      /// Main project logic
      /// </summary>
      /// <param name="args">Command line arguments</param>
      public void Run(string[] args)
      {
         if(args.Length == 0) {
            _messager.sendMessage("Error - No input filename given");
            return;
         }
            
         foreach(string line in _fileHandler.readLines(args[0])) {
            IParseResult parseName = _namesParser.Parse(line);
            if (parseName.Success)
               _fileResults.PersonCollection.add(new Person(parseName.GivenNames, parseName.Surname, _settings));
            else
               _fileResults.InvalidLines.Add(line);
         }
         _fileResults.PersonCollection.sort();         
         
         _streamToConsole = new OutputToConsole(_messager);
         _streamToConsole.Write(_fileResults.ToOutputArray());

         _streamToFile = new OutputToFile(_fileHandler, _settings);
         _streamToFile.Write(_fileResults.PersonCollection.toStringArray());
      }
   }
}
