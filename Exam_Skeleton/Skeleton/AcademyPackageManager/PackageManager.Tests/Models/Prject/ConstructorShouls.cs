using Moq;
using NUnit.Framework;
using PackageManager.Models;
using PackageManager.Models.Contracts;
using PackageManager.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.Prject
{
    [TestFixture]
   public class ConstructorShouls
    {
        [Test]
        public void PackageRepositoryIsSetCorrectlyForOptinalParam()
        {
            // Arrange
            var sut = new Project("Pesho", "Sofia");
            // Act & Assert
            Assert.IsInstanceOf<PackageManager.Repositories.PackageRepository>(sut.PackageRepository);
        }
        [Test]
        public void PackageRepositoryIsSetCorrectlyForPassedParam()
        {
            // Arrange
            var mockedPackage = new Mock<IRepository<IPackage>>();
            // Act
            var sut = new Project("Pesho", "Sofia", mockedPackage.Object);
            //  Assert

            Assert.AreEqual(mockedPackage.Object, sut.PackageRepository);
            //Assert.IsInstanceOf<PackageManager.Repositories.PackageRepository>(sut.PackageRepository);
        }
    }
}
