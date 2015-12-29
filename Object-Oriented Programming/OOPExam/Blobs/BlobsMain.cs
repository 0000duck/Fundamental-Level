using Blobs.Core;
using Blobs.Core.Factories;
using Blobs.Core.IOManager;

namespace Blobs
{
    class BlobsMain
    {
        static void Main(string[] args)
        {
            var blobFactory = new BlobFactory();
            var blobData = new BlobData();
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();

            var engine = new Engine(blobFactory, blobData, reader, writer);
            engine.Run();
        }
    }
}
