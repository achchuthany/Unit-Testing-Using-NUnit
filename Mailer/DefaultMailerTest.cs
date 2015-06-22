using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Moq.Matchers;
using NUnit.Framework;

namespace Mailer
{
    class DefaultMailerTest
    {
        [TestCase]
        public void SentMailTest()
        {
            var mockMailClient = new Moq.Mock<IMailClient>();

          
          
        }
    }
}
