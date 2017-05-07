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
   public class DoesCompareTo
    {
        [Test]
        public void AcceptValidOther()
        {
            // Arrange
            var mockedVersion = new Mock<IVersion>();
            var mockedOther = new Mock<IPackage>();

            mockedOther.SetupGet(x => x.Name).Returns("pesho");
            mockedOther.SetupGet(x => x.Version).Returns(mockedVersion.Object);

            var sut = new Package("pesho", mockedVersion.Object);

            // Act & Assert
            Assert.AreEqual(0, sut.CompareTo(mockedOther.Object));
        }
        [Test]
        public void DontAcceptInValidOther()
        {
            // Arrange
            var mockedVersion = new Mock<IVersion>();
            var mockedOther = new Mock<IPackage>();

            mockedOther.SetupGet(x => x.Name).Returns("pesho");
            mockedOther.SetupGet(x => x.Version).Returns(mockedVersion.Object);

            var sut = new Package("pesho", mockedVersion.Object);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => sut.CompareTo(null));
        }

        [Test]
        public void ShouldThrowExceptionWhenTheNameAreDifferent()
        {
            // Arrange
            var mockedVersion = new Mock<IVersion>();
            var mockedOther = new Mock<IPackage>();

            mockedOther.SetupGet(x => x.Name).Returns("gosho");
            mockedOther.SetupGet(x => x.Version).Returns(mockedVersion.Object);

            var sut = new Package("pesho", mockedVersion.Object);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => sut.CompareTo(mockedOther.Object));
        }
        [Test]
        public void PassedPackageWithEqualVersion()
        {
            // Arrange
            var mockedVersion = new Mock<IVersion>();
            var mockedOther = new Mock<IPackage>();

            mockedOther.SetupGet(x => x.Name).Returns("pesho");
            mockedOther.SetupGet(x => x.Version).Returns(mockedVersion.Object);

            var sut = new Package("pesho", mockedVersion.Object);

            // Act & Assert
            Assert.AreEqual(0, sut.CompareTo(mockedOther.Object));
        }
        [Test]
        public void PassedPackageWithHigherVersion()
        {
            // Arrange
            var mockedVersion = new Mock<IVersion>();
            var mockedOther = new Mock<IPackage>();
            mockedOther.SetupGet(x => x.Version.Major).Returns(10);

            mockedOther.SetupGet(x => x.Name).Returns("pesho");
            mockedOther.SetupGet(x => x.Version).Returns(mockedVersion.Object);
            mockedOther.SetupGet(x => x.Version.Major).Returns(100);

            var sut = new Package("pesho", mockedVersion.Object);

            // Act & Assert
            Assert.AreEqual(-1, sut.CompareTo(mockedOther.Object));
        }
        [Test]
        public void PassedPackageWithLowerVersion()
        {
            // Arrange
            var mockedVersion = new Mock<IVersion>();
            var mockedOther = new Mock<IPackage>();
            var mockedHigher = new Mock<IVersion>();

            mockedOther.SetupGet(x => x.Version.Major).Returns(10);
            mockedOther.SetupGet(x => x.Name).Returns("pesho");
            mockedOther.SetupGet(x => x.Version).Returns(mockedVersion.Object);
            mockedOther.SetupGet(x => x.Version.Major).Returns(-1);

            var sut = new Package("pesho", mockedVersion.Object);

            // Act & Assert
            Assert.AreEqual(1, sut.CompareTo(mockedOther.Object));
        }
    }
}
