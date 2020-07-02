using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses.PersonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassesTest
{
    [TestClass]
    public class CollectionAssertTest
    {
        [TestMethod]
        public void AreCollectionEqualFailsBecauseNoComparerTest()
        {
            PersonManager PerMgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            peopleExpected.Add(new Person() { FirstName = "Felipe", LastName = "Tadeu" });
            peopleExpected.Add(new Person() { FirstName = "Fulano", LastName = "Souza" });
            peopleExpected.Add(new Person() { FirstName = "Siclano", LastName = "Silva" });

            peopleActual = PerMgr.GetPeople();

            CollectionAssert.AreEqual(peopleExpected, peopleActual);
        }
    }
}
