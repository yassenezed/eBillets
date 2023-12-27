# 🎫 eTickets ASP.NET MVC Projesi

Bu proje, film gösterimleri için bilet satışı ve yönetimini sağlayan bir ASP.NET MVC uygulamasıdır.

## 🖥️ Proje Açıklaması

Proje, kullanıcılar ve yöneticiler için iki ayrı arayüz sunar ve film bilgileri, bilet satışı, kullanıcı profilleri gibi temel işlevselliği içerir.

### **Ana Sayfa**

- Filmlerin gösterildiği ve istenen filmlere ait biletlerin sepete eklenebildiği ana sayfa.

### **Kullanıcı Arayüzü**

1. **Giriş ve Kayıt:**
   - Kullanıcılar ve adminler "Log in" bölümünden giriş yapabilir.
   - "Register" kısmından yeni kullanıcılar eklenir.

2. **Film Koleksiyonu:**
   - Giriş yapan kullanıcılar, film koleksiyonunu görebilir ve detaylarına ulaşabilir.
   - Her film için ayrı bir sayfa bulunur. Film detay sayfasında aktör/aktrisler, yönetmenler ve gösterildiği sinema bilgilerini içeren bölümler yer alır.

3. **Bilet Satın Alma:**
   - Kullanıcılar, istedikleri filme ait biletleri sepetlerine ekleyip, PayPal ile güvenli bir şekilde ödeme gerçekleştirebilirler.
   - Profil sayfasında, kullanıcılar kişisel bilgilerini güncelleyebilir.
   - Kullanıcılar sepet geçmişlerini inceleyebilir.
   - "Search" kısmından, sitede yer alan filmler arasında arama yapabilirler.

### **Admin Arayüzü**

1. **Film Yönetimi:**
   - Admin, film detaylarını güncelleyebilme, silebilme ve yeni film ekleyebilme yeteneklerine sahiptir.

2. **Sanatçı ve Yönetmen Yönetimi:**
   - Yeni sinema, yönetmen ve aktör/aktris ekleyebilme, mevcut olanları silebilme ve güncelleme yetenekleri bulunur.

3. **Kullanıcı Yönetimi:**
   - Admin, kullanıcıları ve bu kullanıcılara ait sipariş geçmişlerini detaylı bir şekilde görüntüleyebilir.

## 🔧 Geliştirme Ortamına Başlama

### ** Setup**:

1. 🔗 Repository'yi klonlayın.
2. 📂 Proje klasörüne gidin ve Visual Studio'da projeyi açın.
3. 🔧 Microsoft SQLServer bağlantı dizesini `DbContext` ve `program.cs` içinde kendi  Microsoft SQLServer sunucu ve port bilgilerinizle güncelleyin.
4. ▶️ Visual Studio'da 'Run' tuşuna basarak projeyi başlatın.



