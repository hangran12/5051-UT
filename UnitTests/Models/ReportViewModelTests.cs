using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;

namespace UnitTests.Models
{
    [TestClass]
    public class ReportViewModelTests
    {
        [TestMethod]
        public void ReportViewModel_Instantiate_Default_Should_Pass()
        {
            //Arrange

            //Act
            var result = new ReportViewModel();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_GetLogViewModel_Default_Should_Pass()
        {
            //Arrange
            var result = new ReportViewModel();

            //Act
            LogViewModel model = result.LogViewModel;
            
            //Assert
            Assert.AreEqual(result.LogViewModel, model);
        }

        [TestMethod]
        public void ReportViewModel_GetNumberOfUsers_Default_Should_Pass()
        {
            //Arrange
            var result = new ReportViewModel();

            //Act
            var users = result.NumberOfUsers;

            //Assert
            Assert.AreEqual(result.NumberOfUsers, users);
        }
    }
}
