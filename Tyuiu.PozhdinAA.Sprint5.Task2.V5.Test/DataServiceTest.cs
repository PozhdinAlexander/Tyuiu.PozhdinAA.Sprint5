using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PozhdinAA.Sprint5.Task2.V5.Lib;

namespace Tyuiu.PozhdinAA.Sprint5.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedSaveToFileTextData()
        {
            string path = @"C:\Users\xMeT1oRx\source\repos\Tyuiu.PozhdinAA.Sprint5\Tyuiu.PozhdinAA.Sprint5.Task2.V5\bin\Debug\OutPutFileTask2.scv";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}