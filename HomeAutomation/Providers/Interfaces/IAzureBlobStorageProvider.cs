using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace HomeAutomation.Providers.Interfaces
{
    public interface IAzureBlobStorageProvider
    {
        Task<string> UploadFileToStorage(Stream fileStream, string fileName);
    }
}
