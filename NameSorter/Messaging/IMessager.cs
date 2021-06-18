namespace NameSorter.Messaging
{
   /// <summary>
   /// IMessager
   /// Used for generating messages
   /// </summary>
   public interface IMessager
   {      
      void sendMessage(string message);
   }
}