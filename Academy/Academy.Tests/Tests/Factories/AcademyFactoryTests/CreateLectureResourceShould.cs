using Academy.Core.Factories;
using Academy.Models.Utils.LectureResources;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Tests.Factories.AcademyFactoryTests
{
    [TestFixture]
    class CreateLectureResourceShould
    {
        [Test]
        public void ReturnVideoResourceWhenVideoTypeIsPassed()
        {
            // Arrange
            var factory = AcademyFactory.Instance;

            //Act
            var resource = factory.CreateLectureResource("video", "Peshs's Video", "1a111");

            // Assert
            Assert.IsInstanceOf<VideoResource>(resource);
        }
        [Test]
        public void ReturnDemoResourceWhendemoTypeIsPassed()
        {
            // Arrange
            var factory = AcademyFactory.Instance;

            //Act
            var resource = factory.CreateLectureResource("demo", "Peshs's Video", "1111");

            // Assert
            Assert.IsInstanceOf<DemoResource>(resource);
        }
        [Test]
        public void RThrowExceptionWhenInvalidResourceTypeIsPassed()
        {
            // Arrange
            var factory = AcademyFactory.Instance;

            //Act

            // Assert
            //Assert.Throws(ArgumentException, (() => factory.CreateLectureResource("pesgo", "dsds", "1111")));

        }
    }
}
