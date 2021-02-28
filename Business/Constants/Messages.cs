using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInValid = "Ürün ismi en az 2 karakter olmalıdır";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryCountError = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt olundu";
        public static string AccessTokenCreated = "Erişim tokeni oluşturuldu";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string SuccessfulLogin = "Giriş yapıldı";
        public static string PasswordError = "Şifre yanlış";
        public static string UserNotFound = "Kullanıcı bulunamadı";
    }
}
