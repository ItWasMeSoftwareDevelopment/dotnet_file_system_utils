using System.IO; 

namespace ItWasMe.FileSystemUtils
{
    public interface IFileSystemProxy
    {
        Stream Create(string path);
        Stream OpenRead(string path);
        void Delete(string path);
        void CreateFolderIfNotExist(string folderPath);
        byte[] ReadAllBytes(string path);
        StreamWriter CreateOrAppendIfExist(string path);

    }
}
