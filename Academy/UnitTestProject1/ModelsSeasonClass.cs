//using Academy.Models;
//using Academy.Models.Enums;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Moq;

////namespace UnitTestProject1
//{
//    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
//    public class ModelsSeasonClass
//    {
//        [TestMethod]
//        public void AreAListOfStudentsAndTrainersReturned()
//        {
//            int start = 2016;
//            int end = 2017;
//            var initiative = new Initiative();
//            var sut = new Season(start, end, initiative);
//            const int NewLinesForStudentAndTrainers = 12;
//            List<string> technologyTest = new List<string>();
//            sut.Students.Add(new Student("TestStudent", Track.Frontend));
//            sut.Students.Add(new Student("TestStudent2", Track.Frontend));
//            sut.Trainers.Add(new Trainer("TestTrainer", technologyTest));

//            var sutString = sut.ListUsers();
//            int linesAtString = 0;
//            int startIndex = 0;

//            while (sutString.IndexOf("\n", startIndex) != -1)
//            {
//                linesAtString++;
//                startIndex = sutString.IndexOf("\n", startIndex) + 1;
//            }
//            Assert.AreEqual(linesAtString, NewLinesForStudentAndTrainers);
//        }

//        [TestMethod]
//        public void IsTheMessageForNotContainingStudentsAndTrainersInListIsCorrect()
//        {
//            // Arrange
//            int start = 2016;
//            int end = 2017;
//            var initiative = new Initiative();
//            var sut = new Season(start, end, initiative);
//            List<string> technologyTest = new List<string>();
//            string expMessage = "There are no users in this season!";

//            // Act
//            string sutString = sut.ListUsers();
            
//            //Assert
//            Assert.AreEqual(sutString, expMessage);
//        }

//    }
//}
