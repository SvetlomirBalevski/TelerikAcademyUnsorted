﻿using Academy.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Tests.Models
{
    [TestFixture]
    class GetNameShould
    {
        [Test]
        public void returnTheProperValueWhenGetMethodIsCalled()
        {
            //Arrange
            var course = new Course("Valid Name", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            // Act
            var result = course.Name;

            // Assert
            Assert.AreEqual("Valid Name", result);
        }
    }
}
