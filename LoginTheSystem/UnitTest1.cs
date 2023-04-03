using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoginTheSystem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FTS1()
        {
            //Arrange
            Customer c = new Customer();
            string userNameExpected = "cathy", userNameActual;
            string passwordExpected = "cathy", passwordActual;

            //Act
            c.UserName = "cathy";
            c.Password = "cathy";
            userNameActual = c.UserName;
            passwordActual = c.Password;

            //Assert
            Assert.AreEqual(userNameExpected, userNameActual, "UserName does not match");
            Assert.AreEqual(passwordExpected, passwordActual, "Password does not match");  
        }

        [TestMethod]
        public void FTS2()
        {
            //Arrange
            Customer c = new Customer();
            string userNameExpected = "cathy", userNameActual;
            string passwordExpected = "cathy", passwordActual;

            //Act
            c.UserName = "cathy";
            c.Password = "admin";
            userNameActual = c.UserName;
            passwordActual = c.Password;

            //Assert
            Assert.AreEqual(userNameExpected, userNameActual, "UserName does not match");
            Assert.AreNotEqual(passwordExpected, passwordActual, "Password matches");
        }

        [TestMethod]
        public void FTS3()
        {
            //Arrange
            Customer c = new Customer();
            string userNameExpected = "cathy", userNameActual;
            string passwordExpected = "cathy", passwordActual;

            //Act
            c.UserName = "admin";
            c.Password = "cathy";
            userNameActual = c.UserName;
            passwordActual = c.Password;

            //Assert
            Assert.AreNotEqual(userNameExpected, userNameActual, "UserName matches");
            Assert.AreEqual(passwordExpected, passwordActual, "Password does not match");  
        }

        [TestMethod]
        public void FTS4()
        {
            //Arrange
            Customer c = new Customer();
            string userNameExpected = "cathy", userNameActual;
            string passwordExpected = "cathy", passwordActual;

            //Act
            c.UserName = "admin";
            c.Password = "admin";
            userNameActual = c.UserName;
            passwordActual = c.Password;

            //Assert
            Assert.AreNotEqual(userNameExpected, userNameActual, "UserName matches");
            Assert.AreNotEqual(passwordExpected, passwordActual, "Password matches");
        }

        [TestMethod]
        public void FTS5()
        {
            //Arrange
            Admin a = new Admin();
            string userNameExpected = "admin", userNameActual;
            string passwordExpected = "admin", passwordActual;

            //Act
            a.UserName = "admin";
            a.Password = "admin";
            userNameActual = a.UserName;
            passwordActual = a.Password;

            //Assert
            Assert.AreEqual(userNameExpected, userNameActual, "UserName does not match");
            Assert.AreEqual(passwordExpected, passwordActual, "Password does not match");
        }

        [TestMethod]
        public void FTS6()
        {
            //Arrange
            Admin a = new Admin();
            string userNameExpected = "admin", userNameActual;
            string passwordExpected = "admin", passwordActual;

            //Act
            a.UserName = "admin";
            a.Password = "cathy";
            userNameActual = a.UserName;
            passwordActual = a.Password;

            //Assert
            Assert.AreEqual(userNameExpected, userNameActual, "UserName does not match");
            Assert.AreNotEqual(passwordExpected, passwordActual, "Password matches"); 
        }

        [TestMethod]
        public void FTS7()
        {
            //Arrange
            Admin a = new Admin();
            string userNameExpected = "admin", userNameActual;
            string passwordExpected = "admin", passwordActual;

            //Act
            a.UserName = "cathy";
            a.Password = "admin";
            userNameActual = a.UserName;
            passwordActual = a.Password;

            //Assert
            Assert.AreNotEqual(userNameExpected, userNameActual, "UserName matches");
            Assert.AreEqual(passwordExpected, passwordActual, "Password does not match");
        }

        [TestMethod]
        public void FTS8()
        {
            //Arrange
            Admin a = new Admin();
            string userNameExpected = "admin", userNameActual;
            string passwordExpected = "admin", passwordActual;

            //Act
            a.UserName = "cathy";
            a.Password = "cathy";
            userNameActual = a.UserName;
            passwordActual = a.Password;

            //Assert
            Assert.AreNotEqual(userNameExpected, userNameActual, "UserName matches");
            Assert.AreNotEqual(passwordExpected, passwordActual, "Password matches");
        }
    }
}