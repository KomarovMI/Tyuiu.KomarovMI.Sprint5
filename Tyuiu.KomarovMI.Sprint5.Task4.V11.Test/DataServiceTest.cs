using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KomarovMI.Sprint5.Task4.V11.Lib;

namespace Tyuiu.KomarovMI.Sprint5.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\Users\maxim\source\repos\Tyuiu.KomarovMI.Sprint5\Tyuiu.KomarovMI.Sprint5.Task4.V11\bin\Debug\InPutDataFileTask4V11.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
    
}
