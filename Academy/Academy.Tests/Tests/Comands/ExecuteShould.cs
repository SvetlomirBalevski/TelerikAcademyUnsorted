using Academy.Commands.Adding;
using Academy.Core.Contracts;
using Academy.Core.Factories;
using Academy.Models;
using Academy.Models.Contracts;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Tests.Comands
{
    [TestFixture]
    public class ExecuteShould
    {
        [Test]
        public void SetFactoryWhen()
        {
            var factoryMock = new Mock<IAcademyFactory>();
            var engineMock = new Mock<IEngine>();
            var studentMock = new Mock<Academy.Models.Contracts.Student>();

            var seasonMock = new Mock<ISeason>();

            studentMock.SetupGet(x => x.Username).Returns("Pesho");
            engineMock.SetupGet(x=>x.Students).Returns(new List<Academy.Models.Contracts.Student>() {studentMock.Object });
            engineMock.SetupGet(x => x.Seasons).Returns(new List<ISeason>() { seasonMock.Object });
            seasonMock.SetupGet(x => x.Students).Returns(new List<Academy.Models.Contracts.Student>() { studentMock.Object });

            var command = new AddStudentToSeasonCommand(factoryMock.Object, engineMock.Object);


            Assert.Throws<ArgumentException>(() => command.Execute(new List<string>() { "Pesho", "0" }));

        }
        [Test]
        public void ShoudAddStudentToCollectionWhenTheStudentIsNotInTheSeason()
        {
            var factoryMock = new Mock<IAcademyFactory>();
            var engineMock = new Mock<IEngine>();
            var studentMock = new Mock<Academy.Models.Contracts.Student>();

            var seasonMock = new Mock<ISeason>();

            studentMock.SetupGet(x => x.Username).Returns("Pesho");
            engineMock.SetupGet(x => x.Students).Returns(new List<Academy.Models.Contracts.Student>() { studentMock.Object });
            engineMock.SetupGet(x => x.Seasons).Returns(new List<ISeason>() { seasonMock.Object });
            seasonMock.SetupGet(x => x.Students).Returns(new List<Academy.Models.Contracts.Student>() { studentMock.Object });

            var command = new AddStudentToSeasonCommand(factoryMock.Object, engineMock.Object);

            var result= command.Execute(new List<string>() { "Pesho", "0" });

            //Assert


        }
    }
}
