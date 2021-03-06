using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Car Added.!";
        public static string CarNameInvalide = "Car Name Invalide.!";
        public static string CarNameEror = "Car Name Eror.!";
        public static string CarDelete = "Car Name silindi.!";
        public static string CarUpdate = "Car Name guncellendi.!";
        public static string CarNotAdded= "Car Not Added.";
        public static string CategoryAdded= "Category Added.!";
        public static string RentalAdd= "Araba Kiralandı..!";
        public static string RentalInvalide= "Araba Kiralananmadı..!";
        public static string CarImage5="Bir araca en fazla 5 fotoğraf yüklenebilir.";
        public static string CarImageUpdate= "İlgili aracın resmi güncellendi!";
        public static string CarImageDelete= "İlgili aracın ilgili resmi silindi";
        public static string CarImageAdded= "Resim Başarıyla Yüklendii";
        public static string AuthorizationDenied="Yetkiniz Yok!";
        public static string UserRegistered="Kayıt Oldu.";
        public static string UserNotFound="Kullanıcı Bulunamadı.";
        public static string PasswordError="Paralo Hatası";
        public static string SuccessfulLogin="Başarılı Giriş";
        public static string UserAlreadyExists="Kullanıcı Mevcut";
        public static string AccessTokenCreated="Token Oluşturuldu.";
        public static string CarListed = "Araba Listelendi";
        public static string CarGottenById="id ile çekilen araba";
    }
}
