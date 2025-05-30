using LibraryApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LibraryAppTests
{
    [TestClass]
    public class EligibleToLoanTest
    {
        private EligibleToLoan _eligible;
        private List<Client> _clients;

        [TestInitialize]
        public void SetUp()
        {
            _eligible = new EligibleToLoan();
            _clients = new List<Client>
            {
                new Client("Ruxandra", "ruxi@gmail.com", true, 2),
                new Client("Maria", "maria@gmail.com", true, 2),
                new Client("Ana", "ana@gmail.com", false, 2),
                new Client("Alex", "alex@gmail.com", true, 5)
            };
        }

        [TestCleanup]
        public void TearDown()
        {
            _eligible = null;
            _clients = null;
        }

        [TestMethod]
        public void IsEligibleToLoan_NotClient_ExpectedFalse()
        {
            Visitor visitor = new Visitor("Ruxi", "ruxi@gmail.com");
            bool result = _eligible.IsEligibleToLoan(visitor, _clients);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsEligibleToLoan_NotSubscripted_ExpectedFalse()
        {
            Visitor visitor = new Visitor("Ana", "ana@gmail.com");
            bool result = _eligible.IsEligibleToLoan(visitor, _clients);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsEligibleToLoan_HasManyBooks_ExpectedFalse()
        {
            Visitor visitor = new Visitor("Alex", "alex@gmail.com");
            bool result = _eligible.IsEligibleToLoan(visitor, _clients);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsEligibleToLoan_OK_ExpectedTrue()
        {
            Visitor visitor = new Visitor("Maria", "maria@gmail.com");
            bool result = _eligible.IsEligibleToLoan(visitor, _clients);
            Assert.IsTrue(result);
        }
    }
}

