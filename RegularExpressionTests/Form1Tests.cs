using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegularExpression.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void IsValidName_ValidName()
        {
            // arrange
            string name = "Ben";
            var testForm1 = new Form1();
            // act  
            bool result = testForm1.IsValidName(name);
            // assert
            Assert.AreEqual(true, result);
        }
        [TestMethod()]
        public void IsValidName_InValidName()
        {
            // arrange
            string name = "-+!%";
            var testForm1 = new Form1();
            // act  
            bool result = testForm1.IsValidName(name);
            // assert
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void IsValidPhone_ValidPhone()
        {
            // arrange
            string phone = "123-123-1234";
            var testForm1 = new Form1();
            // act  
            bool result = testForm1.IsValidPhone(phone);
            // assert
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void IsValidPhone_InValidPhone()
        {
            // arrange
            string phone = "123123 1234";
            var testForm1 = new Form1();
            // act  
            bool result = testForm1.IsValidPhone(phone);
            // assert
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void IsValidEmail_ValidEmail()
        {
            // arrange
            string mail = "o.g.bence@gmail.com";
            var testForm1 = new Form1();
            // act  
            bool result = testForm1.IsValidEmail(mail);
            // assert
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void IsValidEmail_InValidEmail()
        {
            // arrange
            string mail = ".@gmail.com";
            var testForm1 = new Form1();
            // act  
            bool result = testForm1.IsValidEmail(mail);
            // assert
            Assert.AreEqual(false, result);
        }
    }
}