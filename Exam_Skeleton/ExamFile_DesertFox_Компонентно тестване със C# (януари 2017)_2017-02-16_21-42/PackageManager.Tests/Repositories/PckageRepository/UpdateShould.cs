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
   public class UpdateShould
    {
        [Test]
        public void ThrowExceptionWhenPackageIsNull()
        {
            // Arrange
            var mockedLogger = new Mock<PackageManager.Info.Contracts.ILogger>();
            var sut = new PackageRepository(mockedLogger.Object);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => sut.Update(null));
        }
        [Test]
        public void ThrowExceptionWhenPackageIsNotFound()
        {
            // Arrange
            var mockedLogger = new Mock<PackageManager.Info.Contracts.ILogger>();
            var sut = new PackageRepository(mockedLogger.Object);
            var mockedPackage = new Mock<IPackage>();
            mockedPackage.Setup(x => x.Name).Returns("Pesho");
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => sut.Update(mockedPackage.Object));
        }
    }
}
