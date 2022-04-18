using System;

namespace Jemus.Domain.Enum
{
    public enum Roles
    {
        SistemAdmin,
        IlAdmin,
        IlceAdmin,
        Karakol
    }

    public static class Constants
    {
        public static readonly string SistemAdmin = Guid.NewGuid().ToString();
        public static readonly string IlAdmin = Guid.NewGuid().ToString();
        public static readonly string IlceAdmin = Guid.NewGuid().ToString();
        public static readonly string Karakol = Guid.NewGuid().ToString();

        public static readonly string SistemAdminUser = Guid.NewGuid().ToString();
        public static readonly string jemus = Guid.NewGuid().ToString();
        public static readonly string IlUser = Guid.NewGuid().ToString();
        public static readonly string IlceUser = Guid.NewGuid().ToString();
        public static readonly string KarakolUser = Guid.NewGuid().ToString();
    }
}
