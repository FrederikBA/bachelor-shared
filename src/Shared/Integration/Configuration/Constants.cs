namespace Shared.Integration.Configuration;

public static class Constants
{
    public static class Authorization
    {
        public const string JwtKey = "3hfJ14K+20sXCy+GYCZjv12bM8Bw2m8F5VtOM3tN+F6KuVI51ohrtJEN+vQ0sFm2";
    }
    
    public static class ConnectionStrings
    {
        public const string ShwUsers = "Server=mssql;Database=ShwUsers;User Id=sa;Password=thisIsSuperStrong1234;TrustServerCertificate=True";
        public const string ShwChemicals = "Server=localhost;Database=ShwChemicals;User Id=sa;Password=thisIsSuperStrong1234;TrustServerCertificate=True";
        public const string ShwWarningSentences = "Server=localhost;Database=ShwWarningSentences;User Id=sa;Password=thisIsSuperStrong1234;TrustServerCertificate=True";
    }
}