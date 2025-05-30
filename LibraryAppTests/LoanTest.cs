using LibraryApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace LibraryAppTests
{
    [TestClass]
    public class LoanTest
    {


        [TestMethod]
        public void HasManyUnreturnedBooks_Morebooks_ExpectedTrue()
        {
            Loan loan = new Loan();
            Client client = new Client("Ruxi", "ruxy@gmail.com", true, 2);
            bool result = loan.HasManyUnreturnedBooks(client, 1);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasManyUnreturnedBooks_LessBooks_ExpectedFalse()
        {
            Loan loan = new Loan();
            Client client = new Client("Ruxi", "ruxy@gmail.com", true, 2);
            bool result = loan.HasManyUnreturnedBooks(client, 4);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void HasManyUnreturnedBooks_EqualNumberOfBooks_ExpectedFalse()
        {
            Loan loan = new Loan();
            Client client = new Client("Ruxi", "ruxy@gmail.com", true, 2);
            bool result = loan.HasManyUnreturnedBooks(client, 2);
            Assert.IsFalse(result);
        }
    }
}
