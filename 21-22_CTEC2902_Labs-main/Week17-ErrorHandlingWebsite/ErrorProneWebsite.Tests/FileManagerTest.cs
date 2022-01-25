using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ErrorProneWebsite.Models;
using System.IO;

namespace ErrorProneWebsite.Tests
{
    [TestClass]
    public class FileManagerTest
    {
        private const string TEST_FILE_PATH = @"D:\HND 2nd year\Advanced Programming\CTEC2902_Labs\21-22_CTEC2902_Labs-main\Week17-ErrorHandlingWebsite\ErrorProneWebsite.Tests\TestContent\TestContent.txt";

        [TestMethod]
        public void TheFileManagerCanReadAFile()
        {
            FileManager fileManager = new FileManager(TEST_FILE_PATH);

            Assert.AreEqual("Here is some test content.", fileManager.GetContent());
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void TheSystemThrowsAFileNotFoundExceptionWhenGivenAPathToAMissingFile()
        {
            FileManager fileManager =
            new FileManager(@"D:\MissingFileThereIsNoFileHere.txt");
            Assert.IsTrue(fileManager.GetEvenMoreContent().Contains
                ("This line won't execute as the exception will be thrown before it's hit"));
        }
    }
}
