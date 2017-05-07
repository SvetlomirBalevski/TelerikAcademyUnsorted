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
    class ConstructorShould
    {
        [Test]
        public void SetCorrectPackageRepositoryForOptionalParameterDependency()
        {
            // Arrange
            var mockedVersion = new Mock<IVersion>();
            // Act
            var sut = new Package("pesho", mockedVersion.Object);

            // Assert
            Assert.IsInstanceOf<HashSet<IPackage>>(sut.Dependencies);
        }
        [Test]
        public void SetCorrectPackageRepositoryForPassedParameterDependency()
        {
            // Arrange
            var mockedVersion = new Mock<IVersion>();
            var mockedDependency = new Mock<ICollection<IPackage>>();
            // Act
            var sut = new Package("pesho", mockedVersion.Object,mockedDependency.Object);

            // Assert
            Assert.AreEqual(mockedDependency.Object, sut.Dependencies);
        }
    }
}
