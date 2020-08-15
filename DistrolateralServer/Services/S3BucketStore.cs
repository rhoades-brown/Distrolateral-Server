using Amazon;
using Amazon.S3;
using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace DistrolateralServer
{
    public class S3BucketStore : IBucketStore
    {
        private readonly string _bucketName;
        private readonly string _keyName;
        private readonly string _filePath;
        // Specify your bucket region (an example region is shown).
       // private static readonly RegionEndpoint bucketRegion = RegionEndpoint.USWest2;
        private  readonly IAmazonS3 _s3Client;
        private readonly ILogger<S3BucketStore> _logger;

        public S3BucketStore(ILogger<S3BucketStore> logger)
        {
            _logger = logger;
            var config = new AmazonS3Config();
            _s3Client = new AmazonS3Client(config);
        }

        public bool IsInUse() => true;

        bool IBucketStore.AddFile(string filename)
        {
            throw new NotImplementedException();
        }

        Stream IBucketStore.GetFile(string filename)
        {
            throw new NotImplementedException();
        }

        bool IBucketStore.TestFileExists(string filename)
        {
            throw new NotImplementedException();
        }
    }
}
