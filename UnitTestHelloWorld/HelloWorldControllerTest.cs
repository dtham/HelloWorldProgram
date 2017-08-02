using System;
using HelloWorldProgram.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestHelloWorld
{
    [TestClass]
    public class HelloWorldControllerTest
    {
        [TestMethod]
        public void GetHelloWorld_ShouldReturnString()
        {
            ////Arrange
            var hwc = new HelloWorldController();

            ////Act
            var expectedResults = "Hello World";
            var result = hwc.Get();

            ////Assert
            Assert.AreEqual(result, expectedResults);
        }
    }
}
