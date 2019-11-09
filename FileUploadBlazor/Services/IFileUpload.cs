using BlazorInputFile;
using System.Threading.Tasks;

namespace FileUploadBlazor.Services
{
    public interface IFileUpload
    {
        Task UploadAsync(IFileListEntry file);
    }
}
