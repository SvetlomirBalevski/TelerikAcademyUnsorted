using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using PackageManager.Repositories;
using PackageManager.Models.Contracts;
using PackageManager.Repositories.Contracts;
using PackageManager.Info.Contracts;

namespace PackageManager.Tests.Repositories.PckageRepository
{
    [TestFixture]
    public class AddShould
    {
        [Test]
        public void ThrowExceptionIfPackageIsNull()
        {
            // Arrange
            var mockedLogger = new Mock<PackageManager.Info.Contracts.ILogger>();
            var sut = new PackageRepository(mockedLogger.Object);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => sut.Add(null));
        }


    }
}
