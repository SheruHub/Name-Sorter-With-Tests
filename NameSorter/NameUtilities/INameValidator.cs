using System.Collections.Generic;

namespace NameSorter.NameUtilities
{
   public interface INameValidator
   {
      bool ValidateName(string[] words);

   }
}