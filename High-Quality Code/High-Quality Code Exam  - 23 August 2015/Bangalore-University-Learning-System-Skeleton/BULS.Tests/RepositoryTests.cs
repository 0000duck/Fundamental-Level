using System.Collections.Generic;
using BangaloreUniversityLearningSystem.Data;
using BangaloreUniversityLearningSystem.Interfaces;
using BangaloreUniversityLearningSystem.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BULS.Tests
{
    [TestClass]
    public class RepositoryTests
    {
        private IRepository<User> users;

        [TestInitialize]
        public void InitializeRepository()
        {
            this.users = new Repository<User>();
        }

        [TestMethod]
        public void Get_ValidId_ShouldReturnElement()
        {
            // Arrange
            var userList = new List<User>()
            {
                new User("Pesho", "123456", Role.Lecturer),
                new User("Gosho", "321414", Role.Student)
            };

            foreach (User user in userList)
            {
                this.users.Add(user);
            }

            // Act
            const int id = 1;
            var actualUser = this.users.Get(id);

            // Assert
            Assert.AreEqual(userList[id - 1], actualUser);
        }

        [TestMethod]
        public void Get_InvalidId_ShouldReturnDefault()
        {
            // Act
            const int id = 1;
            var actualUser = this.users.Get(id);

            // Assert
            Assert.AreEqual(default(User), actualUser);
        }

        [TestMethod]
        public void Get_InvalidId_ShouldReturnDefaultUser()
        {
            // Arrange
            var userList = new List<User>()
            {
                new User("Pesho", "123456", Role.Lecturer),
                new User("Gosho", "321414", Role.Student)
            };

            foreach (User user in userList)
            {
                this.users.Add(user);
            }

            // Act
            int id = userList.Count + 1;
            var actualUser = this.users.Get(id);

            // Assert
            Assert.AreEqual(default(User), actualUser);
        }
    }
}