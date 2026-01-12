# Bitirme Ödevi - Spor Üyelik Yönetim Sistemi

## 📋 Proje Hakkında

Bu proje, bir spor tesisinin üyelik sistemini yönetmek için geliştirilmiş bir Windows Forms uygulamasıdır. Üyelerin kayıt, düzenleme, silme ve ödeme işlemlerini yönetmek için kullanılan masaüstü bir uygulamadır.

**Teknoloji:** C# (.NET Framework 4.7.2) + Windows Forms  
**Veritabanı:** SQL Server LocalDB (SporDb.mdf)

---

## ✨ Özellikler

- **Giriş Sistemi:** Kullanıcı adı ve şifre ile kimlik doğrulama
- **Üye Yönetimi:**
  - ✅ Yeni üye ekleme
  - ✅ Üye bilgilerini görüntüleme
  - ✅ Üye bilgilerini güncelleme ve silme
- **Ödeme Takibi:** Üyelerin ödeme bilgilerini kaydı
- **Zamanlama:** Üyelerin antrenman zamanlamasını belirleme

---

## 📁 Proje Yapısı

```
BitirmeOdevi/
├── Login.cs / Login.Designer.cs       # Giriş ekranı
├── AnaSayfa.cs / AnaSayfa.Designer.cs # Ana menü
├── UyeEkle.cs / UyeEkle.Designer.cs   # Üye ekleme formu
├── GuncelleSil.cs / GuncelleSil.Designer.cs  # Üye güncelleme/silme
├── UyeleriGoruntule.cs / UyeleriGoruntule.Designer.cs  # Üyeleri listeleme
├── Odeme.cs / Odeme.Designer.cs       # Ödeme işlemleri
├── Program.cs                         # Uygulamanın giriş noktası
├── App.config                         # Uygulama yapılandırması
├── BitirmeOdevi.csproj               # Proje dosyası
├── Properties/                        # Proje özellikleri
└── Resources/                         # Uygulama kaynakları (görseller, vs.)
```

---

## 🚀 Kurulum ve Kullanma

### Gereklilikler
- Visual Studio 2019 veya daha yeni versiyonu
- .NET Framework 4.7.2
- SQL Server LocalDB
- SporDb.mdf veritabanı dosyası

### Adımlar

1. **Projeyi Aç:**
   ```bash
   BitirmeOdevi.sln dosyasını Visual Studio'da açın
   ```

2. **Veritabanı Yapılandırması:**
   - `SporDb.mdf` dosyasını `C:\Users\[YourUsername]\OneDrive\Belgeler\` dizinine yerleştirin
   - Veritabanında `UyeTbl` tablosu oluşturun (Ad Soyad, Telefon, Cinsiyet, Yaş, Ödeme, Zamanlama sütunları)

3. **Uygulamayı Çalıştırın:**
   - Visual Studio'da F5 tuşuna basın veya Run düğmesine tıklayın

4. **Giriş Yapın:**
   - Kullanıcı Adı: `Berkcan`
   - Şifre: `1234`

---

## 🔐 Giriş Bilgileri

Uygulamaya erişim için:
- **Kullanıcı Adı:** Berkcan
- **Şifre:** 1234

---

## 📊 Ana Fonksiyonlar

### 1. Login (Giriş)
- Kullanıcı kimlik doğrulaması
- Boş alan kontrolü
- Hatalı giriş mesajları

### 2. Ana Sayfa (Menu)
- Üye Ekle
- Üyeleri Görüntüle
- Güncelle/Sil
- Ödeme İşlemleri

### 3. Üye Ekleme
- Ad Soyad
- Telefon Numarası
- Cinsiyet
- Yaş
- Ödeme Bilgisi
- Zamanlama (Sabah/Öğle/Akşam)
- SQL Server'a kaydetme

### 4. Üyeleri Görüntüleme
- Veritabanındaki tüm üyeleri listeleme

### 5. Güncelleme/Silme
- Mevcut üyelerin bilgilerini güncelleme
- Üyeleri sistemden silme

### 6. Ödeme Yönetimi
- Üyelerin ödeme bilgilerini takip

---

## 🔧 Kullanılan Teknolojiler

- **Dil:** C# (C Sharp)
- **Framework:** .NET Framework 4.7.2
- **GUI:** Windows Forms
- **Veritabanı:** SQL Server (LocalDB)
- **Veri Erişimi:** ADO.NET (SqlConnection, SqlCommand)

---

## ⚠️ Önemli Notlar

- Veritabanı bağlantı dizesi `UyeEkle.cs` dosyasında hardcoded'dir ve sisteminize göre düzeltilmesi gerekebilir
- SQL enjeksiyon saldırılarına karşı savunmasız olabilir; parametreli sorguların kullanılması önerilir
- Şifre hardcoded şekilde kaydedilmiştir; üretim ortamında güvenli bir kimlik doğrulama sistemi uygulanmalıdır

---

## 📝 Lisans

Bu proje öğrenme amaçlı bir bitirme ödevi projesidir.

---

## 👤 Geliştirici

**Berkcan** - Proje Sahibi

---

## 🎓 Notlar

Bu proje, bir bitirme ödevi olarak geliştirilmiştir ve temel veritabanı, forms tasarımı ve C# programlaması konseptlerini içermektedir. Üretim ortamında kullanmadan önce güvenlik düzeltmeleri yapılması önerilir.
