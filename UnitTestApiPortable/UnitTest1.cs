using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace API_Portable.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var app = new App();
            //Act
            app.setBehavior(new ConsoleApp());
            app.setOutput("Hello World");
            //Assert
            Assert.IsInstanceOfType(app.getBehavior(), typeof(ConsoleApp));
            Assert.AreEqual("Hello World", app.getText());
        }
        public void TestMethod2()
        {
            //Arrange
            var app = new App();
            //Act
            app.setBehavior(new ConsoleApp());
            app.setOutput("Hello World");
            //Assert
            Assert.IsInstanceOfType(app.getBehavior(), typeof(ConsoleApp));
            Assert.AreEqual("Hello World!", app.getText());
        }
    }
}
