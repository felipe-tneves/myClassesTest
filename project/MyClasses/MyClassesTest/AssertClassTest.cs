using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;
using MyClasses.PersonClasses;

namespace MyClassesTest
{
    [TestClass]
    public class AssertClassTest
    {
        #region AreEqual/AreNotEqual Test
        [TestMethod]
        [Owner("Felipe")]
        public void AreEqualTest()
        {
            string str1 = "Felipe";
            string str2 = "Felipe";

            Assert.AreEqual(str1, str2);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void AreEqualCaseSensitiveTest()
        {
            string str1 = "Tadeu";
            string str2 = "tadeu";

            Assert.AreEqual(str1, str2, false);
        }

        //[TestMethod]
        //public void AreNotEqualTest()
        //{

        //}
        #endregion

        #region AreSame/AreNotSame Test
        [TestMethod]
        public void AreSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = x;

            Assert.AreSame(x, y);
        }

        [TestMethod]
        public void AreNotSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = new FileProcess();

            Assert.AreNotSame(x, y);
        }
        #endregion

        #region IsInstanceOfType Test

        [TestMethod]
        public void IsInstanceOfTypeTest()
        {
            PersonManager mgr = new PersonManager();
            Person per;

            per = mgr.CreatePerson("Felipe", "Tadeu", true);

            Assert.IsInstanceOfType(per, typeof(Supervisor));
        }

        [TestMethod]
        public void IsNullTest()
        {
            PersonManager mgr = new PersonManager();
            Person per;

            per = mgr.CreatePerson("", "Tadeu", true);

            Assert.IsNull(per);
        }

        #endregion
    }
}
