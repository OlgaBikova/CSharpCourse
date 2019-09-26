using NUnit.Framework;
using Bank;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var client = new Client();
            string surname = "SomeSurname";

            client.SetSurname(surname);

            Assert.AreEqual(surname, client.Surname);
        }


        [Test]
        public void Test2()
        {
            var client = new Client();
            
            Assert.That(() => client.Surname = "SomeSurname", Throws.TypeOf<ClientException>());
        }
    }
}