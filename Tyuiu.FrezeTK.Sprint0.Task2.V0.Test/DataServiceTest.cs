using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FrezeTK.Sprint0.Task2.V0.Lib;

namespace Tyuiu.FrezeTK.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Татьяна";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Татьяна", res);
        }
    }
}