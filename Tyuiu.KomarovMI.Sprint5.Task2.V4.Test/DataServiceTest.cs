using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KomarovMI.Sprint5.Task2.V4.Lib;

namespace Tyuiu.KomarovMI.Sprint5.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @" C:\Users\maxim\source\repos\Tyuiu.KomarovMI.Sprint5\Tyuiu.KomarovMI.Sprint5.Task2.V4\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
