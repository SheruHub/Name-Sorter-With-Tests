//using Autofac;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.DependencyInjection;
using Ninject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace NameSorter
{
   class Program
   {
      static void Main(string[] args)
      {
         IKernel kernel = new StandardKernel();
         kernel.Load(new ContainerModule());

         var app = kernel.Get<Application>();
         app.Run(args);
      }

   }


}
