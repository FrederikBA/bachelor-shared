namespace Shared.Integration.Configuration;

public static class Config
{
    public static class Authorization
    {
        public const string JwtKey = "3hfJ14K+20sXCy+GYCZjv12bM8Bw2m8F5VtOM3tN+F6KuVI51ohrtJEN+vQ0sFm2";

        public static class Policies
        {
            public const string RequireShippingCompanyAdminRole = "RequireShippingCompanyAdminRole";
            public const string RequireKemiDbUserRole = "RequireKemiDbUserRole";
            public const string RequireSuperAdminRole = "RequireSuperAdminRole";
            public const string RequireIntegrationPolicy = "RequireIntegrationPolicy";
        }

        public static class Roles
        {
            public const string ShippingCompanyAdmin = "ShippingCompanyAdmin";
            public const string KemiDbUser = "KemiDbUser";
            public const string SuperAdmin = "SuperAdmin";
            public const string IntegrationPolicy = "IntegrationPolicy";
        }
    }

    public static class ConnectionStrings
    {
        public const string ShwUsers =
            "Server=mssql;Database=ShwUsers;User Id=sa;Password=thisIsSuperStrong1234;TrustServerCertificate=True";

        public const string ShwChemicals =
            "Server=mssql;Database=ShwChemicals;User Id=sa;Password=thisIsSuperStrong1234;TrustServerCertificate=True";

        public const string ShwWarningSentences =
            "Server=mssql;Database=ShwWarningSentences;User Id=sa;Password=thisIsSuperStrong1234;TrustServerCertificate=True";
    }

    public static class IntegrationEndpoints
    {
        public const string WarningSentenceIntegration =
            "http://ost.docker.internal:8082/api/WarningSentenceIntegration/warningsentences";

        public const string ActiveWarningSentencesIntegration =
            "http://host.docker.internal:8081/api/ProductWsIntegration/active";
    }

    public static class Kafka
    {
        public const string BootstrapServers = "kafka:9093";
        public const string BootstrapServersLocal = "localhost:9092";

        public static class Topics
        {
            public const string SyncAddWs = "sync-add-ws";
            public const string SyncUpdateWs = "sync-update-ws";
            public const string SyncDeleteWs = "sync-delete-ws";
            public const string SyncAddProduct = "sync-add-product";
            public const string SyncUpdateProduct = "sync-update-product";
            public const string SyncDeleteProduct = "sync-delete-product";
            public const string SyncAddUser = "sync-add-user";
        }
    }
}