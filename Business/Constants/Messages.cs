using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public const string ProductAdded = "Ürün eklendi.";
        public const string ProductNomeInvalid = "Ürün ismi geçersiz.";
        public const string MaintenanceTime = "Sisteme bakım yapılıyor.";
        public const string ProductListed = "Ürünler listelendi.";
        public const string ProductCountOfCategoryError = "Bir kategoride en faszla 10 urun olabilir.";
        public const string ProductNameAlreadyExist = "Boyle bir isimde urun mevcut.";

        public const string UserNotFound = "Kullanıcı bulunamadı";
        public const string PasswordError = "Şifre hatalı";
        public const string SuccessfulLogin = "Sisteme giriş başarılı";
        public const string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public const string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public const string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public const string AuthorizationDenied = "Yetkiniz yok";
        public const string ProductNameAlreadyExists = "Ürün ismi zaten mevcut";
    }
}
