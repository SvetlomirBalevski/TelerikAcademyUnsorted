using Academy.Core.Contracts;
using Academy.Core.Providers;
using Academy.Models;
using Academy.Models.Contracts;
using Academy.Models.CustomClasses;
using Academy.Models.Enums;
using Academy.Models.Utils.Contracts;
using System;
using Academy.Commands.Listing;

namespace Academy.Core.Factories
{
    public class AcademyFactory : IAcademyFactory
    {
        private string TrackError = "The provided track is not valid!";

        private static IAcademyFactory instanceHolder = new AcademyFactory();

        // private because of Singleton design pattern
        private AcademyFactory()
        {
        }

        public static IAcademyFactory Instance
        {
            get
            {
                return instanceHolder;
            }
        }

        public ISeason CreateSeason(string startingYear, string endingYear, string initiative)
        {
            var parsedStartingYear = int.Parse(startingYear);
            var parsedEngingYear = int.Parse(endingYear);

            Initiative parsedInitiativeAsEnum;
            Enum.TryParse<Initiative>(initiative, out parsedInitiativeAsEnum);

            return new Season(parsedStartingYear, parsedEngingYear, parsedInitiativeAsEnum);
        }

        public IStudent CreateStudent(string username, string track)
        {
            if (track == "Frontend")
            {
                var student = new Student(Track.Frontend, username);
                return student;
            }
            else if (track == "Dev")
            {
              var  student = new Student(Track.Dev, username);
                return student;
            }
            else if(track == "None")
            {
                var student = new Student(Track.None, username);
                return student;
            }
            else
            {
                throw new ArgumentOutOfRangeException(TrackError);
            }
            
        }

        public ITrainer CreateTrainer(string username, string technologies)
        {
            var trainer = new Trainer(username, technologies);
            return trainer;
        }

        public ICourse CreateCourse(string name, string lecturesPerWeek, string startingDate)
        {
            var coures = new Course(name, int.Parse(lecturesPerWeek), startingDate);
            return coures;
        }

        public ILecture CreateLecture(string name, string date, ITrainer trainer)

        {
            var lecture = new Lectures(name, DateTime.Parse(date), trainer);
            return lecture;
        }

        public ILectureResouce CreateLectureResouce(string type, string name, string url)
        {
            // Use this instead of DateTime.Now if you want any points in BGCoder!!
            var currentDate = DateTimeProvider.Now;

            switch (type)
            {
                case "video":
                    var video = new VideoResource(name, url, currentDate);
                    return video;                        
                case "presentation":
                    var presentation = new PresentationResource(name, url);
                    return presentation;                    
                case "demo":
                    var demo = new DemoResource(name, url);
                    return demo;                    
                case "homework":
                    var homework = new HomeworkResource(name, url, currentDate.AddDays(7));
                    return homework;
                default: throw new ArgumentException("Invalid lecture resource type");
            }
            
        }

        public ICourseResult CreateCourseResult(ICourse course, string examPoints, string coursePoints)
        {
            var courseResult = new CourseResult(course, float.Parse(coursePoints), float.Parse(examPoints));
            return courseResult;
        }
    }
}
