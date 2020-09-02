namespace DistrolateralServer.Contacts.v1
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = Root + "/" + Version;

        public static class RootLocation
        {
            public const string Get = Root + "/";
        }

        public static class FileController
        {
            public const string Route = Base + "/file";
            public const string GetAll = Base + "/file";
            public const string GetOne = Base + "/file/{id}";
        }
    }
}
