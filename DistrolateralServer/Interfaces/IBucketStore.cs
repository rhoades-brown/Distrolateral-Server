using System.IO;

namespace DistrolateralServer
{
    public interface IBucketStore
    {

        bool IsInUse();

        bool TestFileExists(string filename);

        Stream GetFile(string filename);

        bool AddFile(string filename);


    }
}
