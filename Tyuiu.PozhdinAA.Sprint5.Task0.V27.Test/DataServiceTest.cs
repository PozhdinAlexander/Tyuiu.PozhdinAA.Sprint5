using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PozhdinAA.Sprint5.Task0.V27.Lib;

namespace Tyuiu.PozhdinAA.Sprint5.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\xMeT1oRx\source\repos\Tyuiu.PozhdinAA.Sprint5\Tyuiu.PozhdinAA.Sprint5.Task0.V27\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}