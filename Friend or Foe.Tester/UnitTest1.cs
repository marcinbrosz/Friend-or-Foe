using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Friend_or_Foe.Tester
{
    [TestClass]
    public class Friend_or_FoeTest
    {
        [TestMethod]
        public void Test_ReturnFriend()
        {
            //Arrange
            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };

            //Act and assert
            CollectionAssert.AreEqual
                (expected, Friend_or_Foe.Library.Friend_or_Foe.ReturnFriend(names).ToList());
        }

        [TestMethod]
        public void Test_ReturnFriend2()
        {
            //Arrange
            string[] expected = { "Anna" };
            string[] names = { "Peter", "Anna", "Michael" };
            

            //Act and assert
            CollectionAssert.AreEqual
                (expected, Friend_or_Foe.Library.Friend_or_Foe.ReturnFriend(names).ToList());
        }

        [TestMethod]
        public void Test_ReturnFriend3()
        {
            //Arrange
            string[] expected = { "Beau", "Azul" };
            string[] names = { "Linus", "Beau", "Azul" };

            //Act and assert
            CollectionAssert.AreEqual
                (expected, Friend_or_Foe.Library.Friend_or_Foe.ReturnFriend(names).ToList());
        }
    }
}
