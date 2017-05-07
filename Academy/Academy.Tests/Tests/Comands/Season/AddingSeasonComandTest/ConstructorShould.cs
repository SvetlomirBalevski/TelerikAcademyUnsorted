using Academy.Commands.Adding;
using Academy.Core.Contracts;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Tests.Comands.Season.AddingSeasonComandTest
{
    [TestFixture]
    class ConstructorShould
    {
        [Test]
        public void ThrowArgumentNullExceptionWhenThePassedFactoryIsNull()
        {
            // Arrange
            var engineMock = new Mock<IEngine>();

            //
            Assert.Throws<ArgumentNullException>(() => new AddStudentToSeasonCommand(null, engineMock.Object));
        }

        public void SetFactory_WhenThePassedFactoryIsNotNull()
        {
            // Arrange
            var engineMock = new Mock<IEngine>();

            //
      //      var command = new AddStudentToSeasonCommandMock(AcademyFactoryMock.object,)
        }


        //[Test]
        //public void ThrowArgumentNullExceptionWhenThePassedEngineIsNull()
        //{
        //    // Arrange
        //    var engineMock = new Mock<IEngine>();

        //    //
        //    Assert.Throws<ArgumentNullException>(() => new AddStudentToSeasonCommand(null, engineMock))
        //}
    }
}
