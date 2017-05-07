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
  public class DoesEquals
    {
        [Test]
        public void ThrowsExeptionWhenObjectPassedIsNull()
        {
            // Arrange
            var mockedVersion = new Mock<IVersion>();

            var sut = new Package("pesho", mockedVersion.Object);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => sut.Equals(null));
        }
        [Test]
        public void ThrowsExeptionWhenObjectPassedIsNotIpackage()
        {
            // Arrange
            var mockedVersion = new Mock<IVersion>();

            var sut = new Package("pesho", mockedVersion.Object);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => sut.Equals(mockedVersion.Object));
        }
        [Test]
        public void ReturnsBoolWhenValueIsRight()
        {
            // Arrange
            var mockedVersion = new Mock<IVersion>();

            var sut = new Package("pesho", mockedVersion.Object);

            // Act

            var isBool = sut.Equals(sut);
            // Act & Assert
            Assert.IsInstanceOf<bool>(isBool);
        }
        [Test]
        public void ReturnsTrueWhenObjectsAreEqual()
        {
            // Arrange
            var mockedVersion = new Mock<IVersion>();

            var sut = new Package("pesho", mockedVersion.Object);
            var newPackageToCheck = sut;

            // Act
            var result = sut.Equals(sut);
            // Act & Assert
            Assert.AreEqual(true, result);
        }
        [Test]
        public void ReturnsFalseWhenObjectsAreNotEqual()
        {
            // Arrange
            var mockedVersion = new Mock<IVersion>();

            var sut = new Package("pesho", mockedVersion.Object);
            var newPackageToCheck = new Package("Gosho",mockedVersion.Object);

            // Act
            var result = sut.Equals(newPackageToCheck);
            // Act & Assert
            Assert.AreEqual(false, result);
        }
    }
}
