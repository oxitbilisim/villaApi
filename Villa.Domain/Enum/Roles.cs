using System;

namespace Villa.Domain.Enum
{
    public enum Roles
    {
        SistemAdmin,
        Admin,
        Kullanici,
        Misafir
    }

    public static class Constants
    {
        public static readonly string SistemAdmin ;
        public static readonly string Admin;
        public static readonly string Kullanici;
        public static readonly string Misafir;

        public static readonly string SistemAdminUser ;
        public static readonly string VillaUser ;
      
    }
}
