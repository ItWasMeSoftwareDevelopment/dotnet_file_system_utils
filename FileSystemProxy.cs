using System.IO;

namespace ItWasMe.FileSystemUtils
{
    public class FileSystemProxy : IFileSystemProxy
    {
        public Stream Create(string path)
        {
            return File.Create(path);
        }

        public Stream OpenRead(string path)
        {
            return File.OpenRead(path);
        }

        public void Delete(string path)
        {
            File.Delete(path);
        }

        public StreamWriter CreateOrAppendIfExist(string path)
        {
            if (File.Exists(path))
            {
                return File.AppendText(path);
            }
            else
            {
                return File.CreateText(path);

            }
        }

        public void CreateFolderIfNotExist(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        public byte[] ReadAllBytes(string path)
        {
            return File.ReadAllBytes(path);
        }
    }
}
