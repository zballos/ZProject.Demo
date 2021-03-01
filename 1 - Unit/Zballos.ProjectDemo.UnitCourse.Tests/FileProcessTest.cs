using System;
using System.ComponentModel;
using System.IO;
using Xunit;

namespace Zballos.ProjectDemo.UnitCourse.Tests
{
    public class FileProcessTest
    {
        private const string FILE_NAME = @"TestingFile.txt";
        private const string BAD_FILE_NAME = @"\TestingFile.txt";

        private static string BaseDir()
        {
            return Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        }

        [Fact]
        [Description("Check file does exists")]
        [Trait("Teste", "trait")]
        public void FileNameDoesExists()
        {
            FileProcess fileProcess = new FileProcess();
            bool fromCall;
            string filePath = @$"{BaseDir()}\{FILE_NAME}";

            fromCall = fileProcess.FileExists(filePath);

            Assert.True(fromCall);
        }

        [Fact]
        [Description("Check file does not exists")]
        public void FileNameDoesNotExists()
        {
            FileProcess fileProcess = new FileProcess();
            bool fromCall;

            fromCall = fileProcess.FileExists(BAD_FILE_NAME);

            Assert.False(fromCall);
        }

        [Fact]
        public void FileNameNullOrEmpty_ThrowsNewArgumentNullException()
        {
            FileProcess fileProcess = new FileProcess();

            Assert.Throws<ArgumentNullException>(() => fileProcess.FileExists(string.Empty));
        }

        [Fact]
        public void FileNameNullOrEmpty_ThrowsNewArgumentNullException_ValidMessage()
        {
            FileProcess fileProcess = new FileProcess();

            var exception = Assert.Throws<ArgumentNullException>(() => fileProcess.FileExists(string.Empty));

            Assert.Equal("fileName", exception.ParamName);
        }
    }
}
