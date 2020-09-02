using DistrolateralServer.Contacts.v1;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.PlatformAbstractions;
using System;
using System.Reflection;

namespace DistrolateralServer.Contollers.v1
{
    public class ApiRoot : Controller
    {
        /// <summary>
        /// Reports information about the service.
        /// </summary>
        /// <remarks>
        /// Sample respose:
        ///
        ///     GET /api
        ///     {
        ///          "name": "ApplicationName",
        ///          "version": "1.0.0.0",
        ///          "is64Bit": true,
        ///          "netRuntime": "5.0.0",
        ///          "hostName": "WebServer1",
        ///          "isContainerised": true,
        ///          "operatingSystem": {
        ///            "name": "debian",
        ///            "platform": 2,
        ///            "version": "10",
        ///            "architecture": "x64"
        ///          }
        ///        }
        ///
        /// </remarks>
        /// <returns>Details about the service</returns>
        /// <response code="200">Service information is returned</response>

        [HttpGet(ApiRoutes.RootLocation.Get)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            var isContainerisedValue = Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER");

            return Ok(new
            {
                Assembly.GetEntryAssembly().GetName().Name,
                Version = Assembly.GetEntryAssembly().GetName().Version.ToString(),
                is64Bit = Environment.Is64BitProcess,
                NetRuntime = Environment.Version.ToString(),
                HostName = Environment.MachineName,
                isContainerised = (isContainerisedValue == null) ? false : isContainerisedValue.ToLower() == "true",
                OperatingSystem = new
                {
                    Name = RuntimeEnvironment.OperatingSystem,
                    Platform = RuntimeEnvironment.OperatingSystemPlatform,
                    Version = RuntimeEnvironment.OperatingSystemVersion,
                    Architecture = RuntimeEnvironment.RuntimeArchitecture
                }
            }); ;

        }
    }
}
