# AcunMedyaAkademi.API

Algoritma Tasarımı
Problem Tanımı: Kullanıcının yaşına göre ehliyet alıp alamayacağını belirleyen bir sistem.

Algoritma

Başlangıç: Kullanıcıdan yaş bilgisi alınacak.
İşlem Adımları:
Kullanıcının yaşını al.
Eğer yaş 18 veya daha büyükse, kullanıcı ehliyet alabilir.
Eğer yaş 18'den küçükse, kullanıcı ehliyet alamaz.
Çıktılar: "Ehliyet alabilirsiniz." veya "Ehliyet alamazsınız."


Belirginlik, Sonluluk ve Etkinlik

Belirginlik: Her adım net bir şekilde tanımlanmıştır.
Sonluluk: Algoritma, verilen bir yaş bilgisi ile sonlanır.
Etkinlik: Algoritma, yaş bilgisi alındığında doğru sonucu kısa sürede döndüren basit bir yapıya sahiptir.


Kodlama ve IDE Kullanımı

Seçilen Programlama Dili: C#
IDE : Rider


Projenizin Genel Amacı

Bu projede, kullanıcıların yaşına göre ehliyet alıp alamayacağını belirleyen bir web API geliştirdim.
Algoritmanızın Çalışma Mantığı:
Kullanıcının yaşını aldıktan sonra, 18 yaş ve üzeri kullanıcıların ehliyet alabileceği, altındaki kullanıcıların alamayacağı belirlenmiştir.
2 servis yazılmıştır.
CheckAgeFromDirectory: bu serviste masaüstünde bir dosya oluşturuluyor ve içerisinden okuyarak ehliyete uygun olup olmadığı kontrol ediliyor.
CheckAgeValidation: bu serviste girilen yaşın ehliyete uygun olup olmadığı kontrol ediliyor.

Faydalanılan Kaynaklar:
Microsoft Documentation
Stack Overflow, GitHub dökümantasyonu ve diğer ilgili kaynaklardan faydalanıldı.
