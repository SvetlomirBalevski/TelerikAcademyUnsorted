//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Academy.Models;
//using Academy.Models.Contracts;
//using System.Collections.Generic;

////namespace UnitTestProject1
//{
//    [TestClass]
//    public class AcademyModelTests
//    {
//        [TestMethod]
//        public void DoesConstructorCorrectlyAssignValues()
//        {
//            // Arrange 
//            string name = "name";
//            int lecPerWeek = 1;
//            DateTime start = DateTime.Now;
//            DateTime end = DateTime.Now.AddYears(1);

//            // Act
//            var sut = new Course(name, lecPerWeek, start, end);

//            // Assert
//            Assert.AreEqual(sut.Name, name);
//            Assert.AreEqual(sut.LecturesPerWeek, lecPerWeek);
//            Assert.AreEqual(sut.StartingDate, start);
//            Assert.AreEqual(sut.EndingDate, end);
//        }

//        [TestMethod]
//        public void AreAllCollectionsInitialized()
//        {
//            // Arrange 
//            string name = "name";
//            int lecPerWeek = 1;
//            DateTime start = DateTime.Now;
//            DateTime end = DateTime.Now.AddYears(1);
//            // Act
//            var sut = new Course(name, lecPerWeek, start, end);

//            // Assert
//            Assert.IsInstanceOfType(sut.OnlineStudents, typeof(List<Academy.Models.Contracts.Student>));
//            Assert.IsInstanceOfType(sut.OnsiteStudents, typeof(List<Academy.Models.Contracts.Student>));
//            Assert.IsInstanceOfType(sut.Lectures, typeof(List<ILecture>));
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentException))]
//        public void DoesErrorIsThrownWhenStartingDateIsAfterEndingDate()
//        {
//            // Arrange 
//            string name = "name";
//            int lecPerWeek = 1;
//            DateTime start = DateTime.Now.AddYears(1);
//            DateTime end = DateTime.Now;

//            // Act
//            var sut = new Course(name, lecPerWeek, start, end);

//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentException))]
//        public void DoesExceptionIsThrownWhenNameIsInvalid()
//        {
//            // Arrange 
//            string name = "a";
//            int lecPerWeek = 1;
//            DateTime start = DateTime.Now.AddYears(1);
//            DateTime end = DateTime.Now;

//            // Act and Assert
//            var sut = new Course(name, lecPerWeek, start, end);

//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentException))]
//        public void DoesExceptionIsThrownWhenLecPerWeekIsInvalid()
//        {
//            // Arrange 
//            string name = "a";
//            int lecPerWeek = -1;
//            DateTime start = DateTime.Now.AddYears(1);
//            DateTime end = DateTime.Now;

//            // Act and Assert
//            var sut = new Course(name, lecPerWeek, start, end);
//        }

//        [TestMethod]
//        public void DoesTheMessageForEmptyLecturesIsCorrect()
//        {
//            // Arrange 
//            string name = "name";
//            int lecPerWeek = 1;
//            DateTime start = DateTime.Now;
//            DateTime end = DateTime.Now.AddYears(1);
//            string expectedMsg = $"* Course:\r\n - Name: name\r\n - Lectures per week: 1\r\n - Starting date: {start}\r\n - Ending date: {end}\r\n - Onsite students: 0\r\n - Online students: 0\r\n - Lectures:\r\n  * There are no lectures in this course!";
//            // Act
//            var sut = new Course(name, lecPerWeek, start, end);
//            var message = sut.ToString();

//            //Assert
//            Assert.AreEqual(expectedMsg, message);
//        }

//        [TestMethod]
//        public void DoesTheToStringIsCorrect()
//        {
//            // Arrange 
//            string name = "name";
//            int lecPerWeek = 5;
//            DateTime start = DateTime.Now;
//            DateTime end = DateTime.Now.AddYears(1);
//            // Act
//            var sut = new Course(name, lecPerWeek, start, end);
//            const int numberOfRows = 8;
//            var sutString = sut.ToString();
//            int linesAtString = 0;
//            int startIndex = 0;
            
//            while (sutString.IndexOf("\n", startIndex) != -1)
//            {
//                linesAtString++;
//                startIndex = sutString.IndexOf("\n", startIndex) + 1;
//            }
//            // Assert
//            Assert.AreEqual(linesAtString, numberOfRows);
//        }

//    }
//}
