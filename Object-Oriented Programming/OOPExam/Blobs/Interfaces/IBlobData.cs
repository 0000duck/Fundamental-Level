using System.Collections.Generic;
using Blobs.Models;

namespace Blobs.Interfaces
{
    public interface IBlobData
    {
        IList<Blob> Blobs { get; }

        void AddBlob(Blob blob);
    }
}