using Moq;
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
    public class ArePropertiesCorrectlyReacting
    {
        [Test]
        public void IsInvalidMajorAccepted()
        {
            // Arrange
            var sut = new PackageVersion(3, 4, 5, Enums.VersionType.alpha);

            //  Act & Assert
            Assert.Throws<ArgumentException>(() => new PackageVersion(-3, 4, 5, Enums.VersionType.alpha));
        }
        [Test]
        public void IsInvalidMinorAccepted()
        {
            // Arrange
            var sut = new PackageVersion(3, 4, 5, Enums.VersionType.alpha);

            //  Act & Assert
            Assert.Throws<ArgumentException>(() => new PackageVersion(3, -4, 5, Enums.VersionType.alpha));
        }
        [Test]
        public void IsInvalidPatchAccepted()
        {
            // Arrange
            var sut = new PackageVersion(3, 4, 5, Enums.VersionType.alpha);
            //  Act & Assert
            Assert.Throws<ArgumentException>(() => new PackageVersion(3, 4, -5, Enums.VersionType.alpha));
        }
        [Test]
        public void IsInvalidVersionAccepted()
        {
            // Arrange
            var sut = new PackageVersion(3, 4, 5, Enums.VersionType.alpha);
            var mockEnum = Enums.VersionType.rc;
            mockEnum = Enums.VersionType.rc + 10;
            //  Act & Assert
            Assert.Throws<ArgumentException>(() => new PackageVersion(3, 4, 5,mockEnum));
        }
    }
}
