using NUnit.Framework;
using NUnit.Compatibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models;
using Academy.Models.Contracts;

namespace Academy.Tests.Models
{
    [TestFixture]
  public  class ConstructorShould
    {
        [Test]
        public void SetProperName_WhenTheObjectIsConstructed()
        {
            //Arrange and Act
            var course = new Course("Valid Name", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            // Assert
            Assert.AreEqual("Valid Name", course.Name);
        }

        [Test]
        public void SetProperLecPerWeek_WhenTheObjectIsConstructed()
        {
            //Arrange and Act
            var course = new Course("Valid Name", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            // Assert
            Assert.AreEqual(5, course.LecturesPerWeek);
        }

        [Test]
        public void InitializeLectureCollectionWhenTheObjectIsConstructed()
        {
            //Arrange and Act
            var course = new Course("Valid Name", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            // Assert
           // Assert.IsInstanceOf(typeof(List<ILecture>),course.Lectures);

          //  Assert.AreEqual(course.Lectures.Count, 0);

            Assert.IsNotNull(course.Lectures);
        }

    }
}
