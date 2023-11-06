using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CarDeleted = "Araba Silindi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string CarNameAndPriceInvalid = "Araba isimi 2 veya 2 karakterin üzerinde ve Günlük ücreti 0'ın üzerinde olmalıdır";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarListed = "Arabalar Listelendi";


        public static string BrandListed = "Araba Marka isimleri Listelendi";
        public static string BrandAdded = "Markanız Eklendi";
        public static string BrandUpdated = "Markanız Güncellendi";
        public static string BrandDeleted = "Markanız Silindi";

        public static string ColorListed = "Araba`nın renkleri Listelendi";
        public static string ColorAdded = "Renginiz Eklendi";
        public static string ColorUpdated = "Renginiz Güncellendi";
        public static string ColorDeleted = "Renginiz Silindi";

        public static string RentalListed = "Kiralamalar Listelendi";
        public static string RentalUpdated = "Kiralamanız Güncellendi";
        public static string RentalDeleted = "Kiralama Silindi";
        public static string RentalAdded = "Kiralama Eklendi";

        public static string CustomerListed = "Müşteriler Listelendi";
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string CustomerDeleted = "Müşteri Silindi";

        public static string UserListed = "Kullanıcılar Listelendi";
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UserDeleted = "Kullanıcı Silindi";

        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarImageUpdated = "Araba resmi güncellendi";
        public static string AuthorizationDenied = "Yetkiniz Yok.";
        public static string UserRegistered = "Kayıt oldu.";
        public static string UserNotFound = "Kullanıcı Bulunamadı.";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu.";
    }
}
