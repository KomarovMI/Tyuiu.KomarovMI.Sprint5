using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KomarovMI.Sprint5.Task3.V30.Lib;

namespace Tyuiu.KomarovMI.Sprint5.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @" C:\Пользователи\maxim\source\repos\Tyuiu.KomarovMI.Sprint5\Tyuiu.KomarovMI.Sprint5.Task3.V30\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
