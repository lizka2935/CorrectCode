using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CorrectCodeLibrary;

namespace CorrectCodeLibraryTests
{
    [TestClass]
    public class CorrectCodeClassTests
    {
        //Arange
        [DataTestMethod]
        [DataRow("")]
        [DataRow("   ")]
        [DataRow("123")]
        [DataRow("123123123123123")]
        [DataRow("strokasymb")]
        [DataRow("1234123404")]
        [DataRow("1234123401")]

       
        
        public void IsCorrectCode_False_ReturnFalse(string candidate)
        {
            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(candidate);
            //Assert
            Assert.IsFalse(actual);
        }
        //Arrange
        [DataTestMethod]
        [DataRow("1234123400")]
        [DataRow("3000030001")]
        [DataRow("3000130009")]


        public void IsCorrectCode_True_ReturnTrue(string candidate)
        {
            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(candidate);
            //Assert
            Assert.IsTrue(actual);
        }


    }
}
