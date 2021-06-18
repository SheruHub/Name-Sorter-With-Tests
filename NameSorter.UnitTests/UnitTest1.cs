using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NameSorter;
using NameSorter.PersonUtilities;
using NameSorter.NameUtilities;

namespace NameSorter.UnitTests
{
   [TestClass]
   public class PersonTests
   {
      [DataTestMethod
         , DataRow(3, new string[] { "Beau", "Tristan", "dsf" }, "Bentley")
         , DataRow(2, new string[] { "Beau", "Tristan" }, "Bentley")
         , DataRow(1, new string[] { "Beau" }, "Bentley")
      ]

      public void TestNumGivenNames(int expected, string[] givenNames, string surname)
      {
         IPerson person = new Person(givenNames, surname, new Settings());
         Assert.AreEqual(expected, person.numGivenNames());
      }

      [DataTestMethod
         , DataRow(-1, new string[] { "Beau" }, "Bentley", new string[] { "Beau", "Tristan" }, "Bentley")
         , DataRow(1, new string[] { "Beau", "Tristan" }, "Bentley", new string[] { "Beau" }, "Bentley")
         , DataRow(0, new string[] { "Beau" }, "Bentley", new string[] { "Beau" }, "Bentley")
         , DataRow(-1, new string[] { "Beau" }, "Bentley", new string[] { "Ceau" }, "Bentley")
         , DataRow(-1, new string[] { "Aeau" }, "Bentley", new string[] { "Beau" }, "Bentley")
         , DataRow(-1, new string[] { "Beau" }, "Bentley", new string[] { "Beau" }, "Centley")
         , DataRow(1, new string[] { "Beau" }, "Bentley", new string[] { "Beau" }, "Aentley")
      ]

      public void TestCompareNames(int expected, string[] gn1, string sName1, string[] gn2, string sName2)
      {
         Settings settings = new Settings();
         IPerson p1 = new Person(gn1, sName1, settings);
         IPerson p2 = new Person(gn2, sName2, settings);
         Assert.AreEqual(expected, p1.CompareTo(p2));

      }
   }
   [TestClass]
   public class NameTests
   {
      [DataTestMethod
         , DataRow(new string[] { "Hunter", "Uriah", "Mathew", "Clarke" }, true)
         , DataRow(new string[] { "Hunter", "Uriah", "34Mathew", "Clarke" }, true)
         , DataRow(new string[] { "Hunter", "Uriah", "M@#$athew", "Clarke" }, false)
         , DataRow(new string[] { "Hunter" }, false)
         , DataRow(new string[] { "Hunter", "Uriah", "Mathew", "Clarke", "Fred", "George" }, false)
      ]

      public void TestNameValidator(string[] name, bool result)
      {
         var validator = new NameValidator(new Settings());
         Assert.AreEqual(result, validator.ValidateName(name));
      }
   }
}
