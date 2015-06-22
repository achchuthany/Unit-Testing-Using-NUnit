using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using program;
using Moq;
using Moq.Matchers;

namespace program.Test
{
    [TestFixture]
    public class TestClass
    {
        [TestCase]
        public void AddTest()
        {

            MathsHellper helper = new MathsHellper();
            int result = helper.Add(20, 10);
            Assert.AreEqual(30, result);
        }

        [TestCase]
        public void SubtractTest()
         {
            MathsHellper helper = new MathsHellper();
            int result = helper.Subtract(20, 10);
            Assert.AreEqual(10, result);
        }

        private BankAccount bankAccountA;
        private BankAccount bankAccountB;

        [SetUp]
        public void setUp()
        {
            bankAccountA = new BankAccount(100.00);
            bankAccountB = new BankAccount(10.00);
        }

        [TestCase]
        public void Deposit()
        {
            bankAccountA.Deposit(10.00);
            Assert.AreEqual(bankAccountA.Balance, 110.00);
        }

        [TestCase]
        public void Withdraw()
        {
            bankAccountA.Withdraw(10.00);
            Assert.AreEqual(bankAccountA.Balance, 90.00);
        }
    }
}
