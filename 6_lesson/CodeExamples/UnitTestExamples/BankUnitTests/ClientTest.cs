using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;

namespace BankUnitTests
{
    [TestClass]
    public class ClientTest
    {
        private Client client;

        [TestInitialize]
        public void TestInitialize()
        {
            client = new Client();
        }


        [TestMethod]
        public void SetSurname_SurnameValueNotEmpty_SurnameIsSet()
        {
            //arrange
            // var client = new Client();
            string surname = "SomeSurname";

            //act
            client.SetSurname(surname);

            //assert
            Assert.AreEqual(surname, client.Surname);
        }

        [TestMethod]
        public void SetSurname_SurnameValueIsEmpty_SurnameIsNotSet()
        {
            //arrange
            //  var client = new Client();
            string surname = "";

            //act
            client.SetSurname(surname);

            //assert
            Assert.IsNull(client.Surname);
        }

        [TestMethod]
        [ExpectedException(typeof(ClientException))]
        public void Surname_SetSurname_ExceptionShouldBeThrown()
        {
            client.Surname = "someSurname";
        }

        [TestMethod]
        public void GetFullName_NameAndSurname_ShouldReturnFullName()
        {
            var name = "Joe";
            var surname = "Doe";

            var result = client.GetFullName(name, surname);

            Assert.AreEqual(result, "Joe Doe");
        }

        [TestMethod]
        public void Withdraw_LessWithdrawAmount_ShouldSubstractFromSum()
        {
            client.Put(100);
            client.Withdraw(50);

            var expected = 50;

            Assert.AreEqual(expected, client.CurrentSum);
        }

        [TestMethod]
        [ExpectedException(typeof(AccountException))]
        public void Withdraw_GreaterWithdrawAmount_ShouldThrowExpection()
        {
            client.Put(100);
            client.Withdraw(200);
        }

        [TestMethod]
        [ExpectedException(typeof(AccountException))]
        public void Withdraw_NegativeWithdrawAmount_ShouldThrowExpection()
        {
            client.Put(100);
            client.Withdraw(-50);
        }
    }
}
