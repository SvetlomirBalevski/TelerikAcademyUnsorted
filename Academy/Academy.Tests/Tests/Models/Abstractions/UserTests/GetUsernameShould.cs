using Academy.Models.Abstractions;
using Academy.Tests.Tests.Mock;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Tests.Models.Abstractions.UserTests
{
    [TestFixture]
    class GetUsernameShould
    {
        [Test]
        public void ReturnProperUserName_WhenTheGetMethodIsCalled()
        {
            // Arrange
            var user = new UserMock("TestUser");

            // Act
            var FoundUserName = user.Username;

            // Assert
            Assert.AreEqual("TestUser", FoundUserName);
        }
    }
}
