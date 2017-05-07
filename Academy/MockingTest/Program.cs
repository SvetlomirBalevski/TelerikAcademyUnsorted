using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using Moq;
using Academy.Models;
using Academy.Models.Contracts;

namespace MockingTest
{
    [TestFixture]
    class Program
    {
        [Test]
        public void ItearateOverCollection()
        {
            var course = new Course("Valid name", 5, DateTime.Now, DateTime.Now.AddDays(1.2));

            var lectureMock = new Mock<ILecture>();

            lectureMock.Setup(x => x.ToString());

            course.Lectures.Add(lectureMock.Object);

            course.ToString();

            lectureMock.Verify(x => x.ToString(), Times.Once);
        }
    }
}
