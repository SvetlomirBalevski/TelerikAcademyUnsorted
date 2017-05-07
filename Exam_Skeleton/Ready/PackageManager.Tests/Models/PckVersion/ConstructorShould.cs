using NUnit.Framework;
using PackageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.PckVersion
{
    [TestFixture]
    public class ConstructorShould
    {
        [Test]
        public void PassMajorCorrectly()
        {
            // Arrange
            var sut = new PackageVersion(3, 4, 5, Enums.VersionType.alpha);

            // Act & Assert
            Assert.AreEqual(3, sut.Major);
        }
        [Test]
        public void PassMinorCorrectly()
        {
            // Arrange
            var sut = new PackageVersion(3, 4, 5, Enums.VersionType.alpha);

            // Act & Assert
            Assert.AreEqual(4, sut.Minor);
        }
        [Test]
        public void PassPatchCorrectly()
        {
            // Arrange
            var sut = new PackageVersion(3, 4, 5, Enums.VersionType.alpha);

            // Act & Assert
            Assert.AreEqual(5, sut.Patch);
        }
        [Test]
        public void PassVersionTypeCorrectly()
        {
            // Arrange
            var sut = new PackageVersion(3, 4, 5, Enums.VersionType.alpha);

            // Act & Assert
            Assert.AreEqual(Enums.VersionType.alpha, sut.VersionType);
        }
    }
}
