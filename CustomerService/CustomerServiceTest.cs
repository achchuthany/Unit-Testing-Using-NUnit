using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
namespace CustomerService
{
    class CustomerServiceTest
    {
        [TestCase]
        public void GetCustomerTest()
        {
            const int CUSTOMER_ID = 1;
            const string FNAME = "John";
            const string LNAME = "Smith";

            var repository = new Mock<ICustomerRepository>();
            repository.Setup(m => m.GetCustomer(CUSTOMER_ID)).Returns(new Customer { FirstName = FNAME, LastName = LNAME });

            var service = new CustomerService(repository.Object);

            var consumer = service.GetCustomer(CUSTOMER_ID);

            Assert.IsTrue(consumer != null);
            Assert.IsTrue(consumer.FirstName == FNAME);
            Assert.IsTrue(consumer.LastName == LNAME);
        }
    }
}
