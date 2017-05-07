using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using PackageManager.Models;
using PackageManager.Models.Contracts;

namespace PackageManager.Tests.Models.Packages
{
    [TestFixture]
    class PropertiesShould
    {
        [Test]
        public void SetNameCorrectly()
        {
            // Arrange
            var mockedVersion = new Mock<IVersion>();

            // Act
            var sut = new Package("pesho", mockedVersion.Object);

            // Assert
            Assert.AreEqual("pesho", sut.Name);
        }
        [Test]
        public void SetVersionCorrectly()
        {
            // Arrange
            var mockedVersion = new Mock<IVersion>();

            // Act
            var sut = new Package("pesho", mockedVersion.Object);

            // Assert
            Assert.AreEqual(mockedVersion.Object, sut.Version);
        }
        [Test]
        public void SetURCorrectly()
        {
            // Arrange
            var mockedVersion = new Mock<IVersion>();
            mockedVersion.Setup(x => x.VersionType).Returns(Enums.VersionType.alpha);

            // Act
            var sut = new Package("pesho", mockedVersion.Object);
            var stringTocheck = sut.Url;
            // Assert
            StringAssert.Contains("alpha", stringTocheck);
        }
    }
}
