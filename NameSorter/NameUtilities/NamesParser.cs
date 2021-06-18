using NameSorter.PersonUtilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.NameUtilities
{
   class NamesParser : INamesParser
   {
      private INameValidator _nameValidator;
      private Settings _settings;


      public NamesParser(INameValidator nameValidator, Settings settings)
      {
         _nameValidator = nameValidator;
         _settings = settings;
      }


      public IParseResult Parse(string line)
      {
         IParseResult result = new ParseResult();

         string[] words = line.Split(_settings.NameDelimiter);
         if (_nameValidator.ValidateName(words)) {
            result.Success = true;
            result.GivenNames = words[0..(words.Length)];
            result.Surname = words.Last();
         }
         else {
            result.Success = false;
            result.Line = line;
         }
         return result;
      }
   }
}
