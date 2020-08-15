using System;
using System.IO;

namespace DistrolateralServer
{
    public class NoBucket : IBucketStore
    {
        public bool AddFile(string filename) => throw new NotImplementedException();

        public Stream GetFile(string filename) => throw new NotImplementedException();

        public bool IsInUse() => false;

        public bool TestFileExists(string filename) => false;
    }
}
