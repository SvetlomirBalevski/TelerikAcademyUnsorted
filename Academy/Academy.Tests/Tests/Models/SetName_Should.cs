using Academy.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Tests.Models
{
    [TestFixture]
    public class SetName_Should
    {
        [TestCase("1")]
        [TestCase("very very very very very very very very very very very very very very ")]
        public void ThrowsArgException_WhenInvalidValueIsPassed(string name)
        {
            //Arrange & Act
            var course = new Course("Valid Name", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            // Assert
            Assert.Throws<ArgumentException>(() => course.Name = name);
        }
    }
}
