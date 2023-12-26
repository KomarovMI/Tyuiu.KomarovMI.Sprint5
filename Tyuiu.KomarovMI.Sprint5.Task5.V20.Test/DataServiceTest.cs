using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KomarovMI.Sprint5.Task5.V20.Lib;

namespace Tyuiu.KomarovMI.Sprint5.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFormDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V20.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

