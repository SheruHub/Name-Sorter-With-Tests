using NameSorter.Messaging;
using NameSorter.NameUtilities;
using NameSorter.PersonUtilities;
using NameSorter.FileUtilities;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
   public class ContainerModule : NinjectModule
   {
      public override void Load()
      {
         Bind<IApplication>().To<Application>();
         Bind<IFileHandler>().To<FileHandler>();
         Bind<IFileResults>().To<FileResults>();
         Bind<IMessager>().To<ConsoleMessager>();
         Bind<INamesParser>().To<NamesParser>();
         Bind<IParseResult>().To<ParseResult>();
         Bind<INameValidator>().To<NameValidator>();
         Bind<IPerson>().To<Person>();
         Bind<IPersonCollection>().To<PersonCollection>();
      }
   }
}
