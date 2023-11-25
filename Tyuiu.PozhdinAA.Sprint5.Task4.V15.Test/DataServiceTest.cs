using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PozhdinAA.Sprint5.Task4.V15.Lib;

namespace Tyuiu.PozhdinAA.Sprint5.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\xMeT1oRx\source\repos\Tyuiu.PozhdinAA.Sprint5\Tyuiu.PozhdinAA.Sprint5.Task4.V15\bin\Debug\InPutDataFileTask4V15.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}