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
using Academy.Models.Abstractions;
using Academy.Core.Factories;
using Academy.Models.Utils.LectureResources;
using Academy.Core.Contracts;
using Academy.Commands.Adding;

namespace MockingTest
{
    [TestFixture]
    public class TestOfSmthng
    {
        [Test]
        public void ItearateOverCollection()
        {
            // Arrange
            var course = new Course("Valid name", 5, DateTime.Now, DateTime.Now.AddDays(1.2));

            var lectureMock = new Mock<ILecture>();

            lectureMock.Setup(x => x.ToString());

            course.Lectures.Add(lectureMock.Object);

            //Act
            course.ToString();

            //Assert
            lectureMock.Verify(x => x.ToString(), Times.Once);
        }
        [Test]
        public void AddMessageToEndResultWhenTheCollectionIsEmpty()
        {
            // Arrange
            var course = new Course("Valid name", 5, DateTime.Now, DateTime.Now.AddDays(1.2));

            //Act
            var sut = course.ToString();

            //Assert
            StringAssert.Contains("no lectures", sut);
        }
        [Test]
        public void GetUsernameShouldReturnProperUsernameWhenTheGetMethodIsCalled()
        {
            // Arrange
            var sut = new UserMock("Pesho");

            // Act and Assert

            Assert.AreEqual(sut.Username, "Pesho");
        }

        [Test]
        public void CrLectureResShoudReturnVideoResWhenVideoTypeIsPassed()
        {
            // Arrange
            var factory = AcademyFactory.Instance;

            // Act
            var video = factory.CreateLectureResource("video", "Pesho's Video", "111111");

            // Assert
            Assert.IsInstanceOf<VideoResource>(video);
        }
        [Test]
        public void ThrowArgExcept()
        {
            // Arrange
            var factory = AcademyFactory.Instance;

            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => factory.CreateLectureResource("pesho", "Pesho's Video", "111111"));
        }
        [Test]
        public void AddToSeaasonCommandShouldCtrShouldThrowException()
        {
            // Arrange
            //  var FactoryMock = new Mock<IAcademyFactory>();
            var EngineMock = new Mock<IEngine>();

            // Act And Assert
            Assert.Throws<ArgumentNullException>(() => new AddStudentToSeasonCommand(null, EngineMock.Object));
        }
        [Test]
        public void SetFactoryWhenThePassedFactoryIsNotNull()
        {
            // Arrange
            var FactoryMock = new Mock<IAcademyFactory>();
            var EngineMock = new Mock<IEngine>();

            // Act 
            var command = new AddStudentMokc(FactoryMock.Object, EngineMock.Object);

            // Assert

            Assert.AreSame(FactoryMock.Object, command.AcademyFactory);
        }
        [Test]
        public void ExecuteShouldSetFactoryWhenThePassedFactoryIsNotNull()
        {
            // Arrange
            var FactoryMock = new Mock<IAcademyFactory>();
            var EngineMock = new Mock<IEngine>();

            var studentmock = new Mock<Academy.Models.Contracts.Student>();

            studentmock.SetupGet(x => x.Username).Returns("Pesho");

            EngineMock.SetupGet(x => x.Students).Returns(new List<Academy.Models.Contracts.Student>() { studentmock.Object });

            var seasonmock = new Mock<ISeason>();

            seasonmock.SetupGet(x => x.Students).Returns(new List<Academy.Models.Contracts.Student>() {studentmock.Object });

            EngineMock.SetupGet(x => x.Seasons).Returns(new List<ISeason>() { seasonmock.Object });

            var command = new AddStudentToSeasonCommand(FactoryMock.Object, EngineMock.Object);

            // Act            // Assert

            Assert.Throws<ArgumentException>(()=>command.Execute(new List<string>(){ "Pesho", "0"}));
        }
        [Test]
        public void AddStudentToCollecWhenStudIsNolNull()
        {
            // Arrange
            var FactoryMock = new Mock<IAcademyFactory>();
            var EngineMock = new Mock<IEngine>();

            var studentmock = new Mock<Academy.Models.Contracts.Student>();

            studentmock.SetupGet(x => x.Username).Returns("Pesho");

            EngineMock.SetupGet(x => x.Students).Returns(new List<Academy.Models.Contracts.Student>() { studentmock.Object });

            var seasonmock = new Mock<ISeason>();

            var studentmockNotPesho = new Mock<Academy.Models.Contracts.Student>();

            studentmockNotPesho.SetupGet(x => x.Username).Returns("Not Pesho");

            var studentInsEason = new List<Academy.Models.Contracts.Student>() { studentmockNotPesho.Object };

            seasonmock.SetupGet(x => x.Students).Returns(studentInsEason);

            EngineMock.SetupGet(x => x.Seasons).Returns(new List<ISeason>() { seasonmock.Object });

            var command = new AddStudentToSeasonCommand(FactoryMock.Object, EngineMock.Object);

            // Act            

            var result = command.Execute(new List<string>() { "Pesho", "0" });

            // Assert
            Assert.AreEqual(2, seasonmock.Object.Students.Count);

        }
    }


    internal class AddStudentMokc : AddStudentToSeasonCommand
    {
        public AddStudentMokc(IAcademyFactory factory, IEngine engine) : base(factory, engine)
        {
        }
        public IAcademyFactory AcademyFactory { get { return this.factory; } }

        public IEngine Engine { get { return this.engine; } }
    }

    internal class UserMock : User
    {
        public UserMock(string username) : base(username)
        {

        }
    }

}
