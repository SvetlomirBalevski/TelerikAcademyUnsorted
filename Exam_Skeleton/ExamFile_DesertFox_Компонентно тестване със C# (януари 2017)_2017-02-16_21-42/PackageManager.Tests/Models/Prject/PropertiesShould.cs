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
   public class PropertiesShould
    {
        [Test]
        public void SetNameCorrectly()
        {
            // Arrange
            var sut = new Project("Pesho", "Sofia");
            // Act & Assert
            Assert.AreEqual("Pesho", sut.Name);
        }

        [Test]
        public void SetLocationCorrectly()
        {
            // Arrange
            var sut = new Project("Pesho", "Sofia");
            // Act & Assert
            Assert.AreEqual("Sofia", sut.Location);
        }
       

    }
}
