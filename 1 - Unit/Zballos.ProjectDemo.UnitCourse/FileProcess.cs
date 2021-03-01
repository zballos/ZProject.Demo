using System;
using System.IO;

namespace Zballos.ProjectDemo.UnitCourse
{
    public class FileProcess
    {
        public bool FileExists(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("fileName", "fileName Not be null");
            }

            return File.Exists(fileName);
        }
    }
}
