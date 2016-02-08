using System;
using System.Linq;
using BangaloreUniversityLearningSystem.Controllers;
using BangaloreUniversityLearningSystem.Interfaces;
using BangaloreUniversityLearningSystem.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BULS.Tests
{
    [TestClass]
    public class CoursesTests
    {
        private IBangaloreUniversityData mockedData;
        private Course course;

        [TestInitialize]
        public void InitializeMoq()
        {
            var dataMock = new Mock<IBangaloreUniversityData>();
            var courseRepoMock = new Mock<IRepository<Course>>();
            courseRepoMock.Setup(r => r.Get(It.IsAny<int>()))
                .Returns(new Course("C# for babies"));

            dataMock.Setup(d => d.Courses)
                .Returns(courseRepoMock.Object);

            this.mockedData = dataMock.Object;
        }

        [TestMethod]
        public void AddLecture_ValidCourseId_ShouldAddToCourse()
        {
            // Arrange
            var controller = new CoursesController(this.mockedData, new User("Nasko", "123456", Role.Lecturer));

            string lectureName = DateTime.Now.ToString();

            // Act
            var view = controller.AddLecture(5, lectureName);

            // Assert
            Assert.AreEqual(this.course.Lectures.First().Name, lectureName);
            Assert.IsNotNull(view);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddLecture_InvalidCourseId_ShouldThrow()
        {
            
        }
    }
}