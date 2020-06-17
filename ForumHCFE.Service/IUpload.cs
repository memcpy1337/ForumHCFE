using Microsoft.WindowsAzure.Storage.Blob;

namespace ForumHCFE.Service
{
    public interface IUpload
    {
        CloudBlobContainer GetBlobContainer(string connectionString);
    }
}