using Academy.Models;
using Academy.Models.Contracts;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Academy.Tests.Tests.Models
{
 [TestFixture]
    public class ToStringShould
    {
        [Test]
        public void IterateOverLectorCollectionWhenTheCollecionIsNotEmpty()
        {
            // Arrange
            var course = new Course("Valid name", 5, new DateTime(2017, 01, 10), new DateTime(2017, 02, 10));

            var lectureMock = new Mock<ILecture>();

            lectureMock.Setup(x => x.ToString());

            course.Lectures.Add(lectureMock.Object);

            // Act
            course.ToString();

            // Assert
            lectureMock.Verify(x => x.ToString(), Times.Once);
        }


        [Test]
        public void AddMessageToEndResultWhenCollectionIsEmpty()
        {
            // Arrange
            var course = new Course("Valid name", 5, new DateTime(2017, 01, 10), new DateTime(2017, 02, 10));
            

            // Act
           var result= course.ToString();

            // Assert
            StringAssert.Contains("no lectures", result);
        }

        //public void IterateOverLectorCollectionWhenTheCollecionIsNotEmptyWithJustMoq()
        //{
        //    // Arrange
        //    var course = new Course("Valid name", 5, new DateTime(2017, 01, 10), new DateTime(2017, 02, 10));

        //   var lectureMock = Telerik.justmock.Mock.create<Lecture>();

        //    lectureMock.Setup(x => x.ToString());

        //    course.Lectures.Add(lectureMock.Object);

        //    // Act
        //    course.ToString();

        //    // Assert
        //    lectureMock.Verify(x => x.ToString(), Times.Once);
        //}


    }
}
