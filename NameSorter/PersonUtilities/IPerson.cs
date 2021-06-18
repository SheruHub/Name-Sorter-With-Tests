namespace NameSorter.PersonUtilities
{
   /// <summary>
   /// IPerson
   /// Holds person details
   /// </summary>
   public interface IPerson
   {
      string Surname { get; }
      string[] GivenNames { get; }
      
      int CompareTo(object obj);
      int numGivenNames();
      string ToString();
   }
}