using Blobs.Models;

namespace Blobs.Interfaces
{
    public interface IBlobFactory
    {
        Blob CreateBlob(ICommand command);
    }
}