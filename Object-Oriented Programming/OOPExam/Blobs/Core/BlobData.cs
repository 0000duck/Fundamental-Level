using System;
using System.Collections.Generic;
using Blobs.Interfaces;
using Blobs.Models;

namespace Blobs.Core
{
    public class BlobData : IBlobData
    {
        public BlobData()
        {
            this.Blobs = new List<Blob>();
        }

        public IList<Blob> Blobs { get; }

        public void AddBlob(Blob blob)
        {
            if (blob == null)
            {
                throw new ArgumentNullException(nameof(blob));
            }

            if (!this.Blobs.Contains(blob))
            {
                this.Blobs.Add(blob);
            }
            else
            {
                throw new ArgumentException($"The blob with name {blob.Name} already exists");
            }
        }
    }
}