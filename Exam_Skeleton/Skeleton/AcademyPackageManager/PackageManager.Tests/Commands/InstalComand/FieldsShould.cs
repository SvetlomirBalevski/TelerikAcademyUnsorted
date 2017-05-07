using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackageManager.Commands;
using Moq;
using PackageManager.Core.Contracts;
using PackageManager.Models.Contracts;

namespace PackageManager.Tests.Commands.InstalComand
{
    [TestFixture]
    public class FieldsShould
    {
        [Test]
        public void PassValuesCorrectlyForInstaller()
        {
            // Arrange
            var mockedInstaller = new Mock<IInstaller<IPackage>>();
            var mockedIpackage = new Mock<IPackage>();

            // Act
            var sut = new InstallCommand(mockedInstaller.Object, mockedIpackage.Object);

            // Assert
            Assert.AreEqual(mockedInstaller.Object, sut.Installer);
        }
        [Test]
        public void PassValuesCorrectlyForPackage()
        {
            // Arrange
            var mockedInstaller = new Mock<IInstaller<IPackage>>();
            var mockedIpackage = new Mock<IPackage>();

            // Act
            var sut = new InstallCommand(mockedInstaller.Object, mockedIpackage.Object);

            // Assert
            Assert.AreEqual(mockedIpackage.Object, sut.Package);
        }
    }
}
