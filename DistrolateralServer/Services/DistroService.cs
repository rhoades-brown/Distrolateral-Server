using DistrolateralServer.Protos;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DistrolateralServer.Services
{
    public class DistroService : Distrobuter.DistrobuterBase
    {
        private readonly ILogger<DistroService> _logger;
        public DistroService(ILogger<DistroService> logger)
        {
            _logger = logger;
        }

        public override Task<StatusReply> StageFile(FileRequest request, ServerCallContext context)
        {
            return base.StageFile(request, context);
        }

        public override Task<StatusReply> TestFile(FileRequest request, ServerCallContext context)
        {
            return base.TestFile(request, context);
        }
    }
}
