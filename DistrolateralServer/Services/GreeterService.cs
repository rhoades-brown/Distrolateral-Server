using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DistrolateralServer
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            var Message = "Hello " + request.Name;
            _logger.LogDebug(Message);
            return Task.FromResult(new HelloReply
            {
                Message = Message
            });
        }
    }
}
