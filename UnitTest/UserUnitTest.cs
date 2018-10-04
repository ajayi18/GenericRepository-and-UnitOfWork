using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business.UserServices;

namespace UnitTest
{
    [TestClass]
    public class UserUnitTest
    {
        [TestMethod]
        public void UserAddTest1()
        {
            IUserService userService = new UserService();
            var process = userService.addUser(new Repository.Models.User());
            Assert.AreNotEqual(-1, process);
        }
    }
}
