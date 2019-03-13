using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileData;

namespace FileDataTest
{
    [TestClass]
    public class TestMaster
    {
        [TestMethod]
        //Positive - Version
        public void GetFileVersion()
        {
            var result = FileInformation.GetFileDetails("-v", "C:/test.txt");
            Assert.IsNotNull(result);
        }

        [TestMethod]
        //Positive - Size
        public void GetFileSize()
        {
            var result = FileInformation.GetFileDetails("-s", "C:/test.txt");
            Assert.IsNotNull(result);
        }

        [TestMethod]
        //Negative - Invalid functionality
        public void GetException()
        {
            var result = FileInformation.GetFileDetails("-o", "C:/test.txt");
            Assert.IsNull(result);
        }


    }
}
