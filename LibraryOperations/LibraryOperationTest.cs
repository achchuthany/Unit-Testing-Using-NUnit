using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Moq.Matchers;
using NUnit.Framework;

namespace LibraryOperations
{
    class LibraryOperationTest
    {

        [TestCase]
        public void LibaryCoreTest()
        {
            Member member = new Member()
            {
                MemberID = 1,
                FirstName = "Achchuthan",
                LastName = "Yogarajah",
                Age = 25,
                MaxiumBookCanBorrow = 4,
            };

            Mock<IMemberManager> _mock = new Mock<IMemberManager>();
            LibaryCore _target = new LibaryCore(_mock.Object);
            _mock.Setup(x => x.GetMember(It.IsAny<int>())).Returns(member);

            int memberID = 1;
            double expected = 12;
            double actual;
            Console.WriteLine(_mock.Object);
            actual = _target.CalculateMemberShipCost(memberID);

            Assert.AreEqual(expected, actual);
        }
    }
}
