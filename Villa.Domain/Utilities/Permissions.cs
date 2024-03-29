﻿using System;
using System.Collections.Generic;

namespace Villa.Domain.Utilities
{
    public static class Permissions
    {
        public static class Genel
        {
            public const string All = "Permissions.Genel.All";
        }
        public static class Ayarlar
        {
            public const string All = "Permissions.Ayarlar.All";
        }
        // public static class Villas
        // {
        //     public const string All = "Permissions.Villa.All";
        //     public const string Ekle = "Permissions.Villa.Ekle";
        //     public const string Guncelle = "Permissions.Villa.Guncelle";
        //     public const string Sil = "Permissions.Villa.Sil";
        // }
        public static class Kategori
        {
            public const string All = "Permissions.Kategori.All";
        }
        public static class Bolge
        {
            public const string All = "Permissions.Bolge.All";
        }
        public static class Rezarvasyon
        {
            public const string All = "Permissions.Rezarvasyon.All";
        }

        public static class Credential
        {
            public const string All = "Permissions.Credential.All";
        }
    
        public static class Grup
        {
            public const string All = "Permissions.Grup.All";
        }

        public static class Il
        {
            public const string All = "Permissions.Il.All";
        }
        public static class Ilce
        {
            public const string All = "Permissions.Ilce.All";
        }
        public static class Kullanici
        {
            public const string All = "Permissions.Kullanici.All";
        }
        public static class KullaniciGrup
        {
            public const string All = "Permissions.KullaniciGrup.All";
        }
    
        public static class Log
        {
            public const string All = "Permissions.Log.All";
        }
 
        public static List<string> getPermissions()
        {
            List<string> Permissions = new List<string>();

            foreach (Type type in typeof(Permissions).GetNestedTypes())
            {
                foreach (var fiels in type.GetFields())
                {
                    Permissions.Add(fiels.GetValue(type).ToString());
                };
            }

            return Permissions;
        }

   }
}
