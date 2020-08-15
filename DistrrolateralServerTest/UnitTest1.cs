using DistrolateralServer.Protos;
using Xunit;

namespace DistrrolateralServerTest
{
    public class distroServiceTest
    {
        [Fact]
        public void Test1()
        {
            //     var distroService = new DistroService();
            var request = new FileRequest { FileName = "somefile" };
            //     await distroService.TestFile(request);
        }
    }
}
