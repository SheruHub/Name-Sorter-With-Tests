using NameSorter.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NameSorter.NameUtilities
{
   public class NameValidator : INameValidator
   {
      private Settings _settings;

      public NameValidator (Settings settings)
      {
         _settings = settings;
      }
      public bool ValidateName(string[] words)
      {
         // Make sure number of words in name is valid
         if (words.Count() < (_settings.MinGivenNames + 1) || words.Count() > (_settings.MaxGivenNames + 1))
            return false;
         // Make sure name is alpha-numeric (in case of eg. "Fred 3rd")
         foreach (string word in words) {
            if (!Regex.IsMatch(word, "^[a-zA-Z0-9]*$")) {
               return false;
            }
         }
         return true;
      }

   }
}
