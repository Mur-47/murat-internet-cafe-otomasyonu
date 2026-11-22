# İnternet Kafe Otomasyonu

İnternet kafe yönetimi üzerine hazırlanmış C# Windows Forms öğrenme projesi.

**Durum: eğitim/portföy kaynak kodu.** Bu belge, depodaki mevcut dosyalara göre hazırlanmıştır. Üretime hazır ürün veya doğrulanmış kurulum paketi olarak sunulmaz.

## Gereksinimler

- Windows ve Visual Studio içinde **.NET masaüstü geliştirme** iş yükü.
- **.NET Framework 4.7.2 Developer Pack / targeting pack**. Bu proje ASP.NET Core veya EF Core uygulaması değildir.
- **SQL Server** ve uygulamanın beklediği şema. Şema/kurulum betiği bu depoda yok; yalnız klonlamak veritabanını kurmaz.

## Kurulum

1. Depoyu klonlayın:

   ```powershell
   git clone https://github.com/Mur-47/murat-internet-cafe-otomasyonu.git
   cd murat-internet-cafe-otomasyonu
   ```

2. Visual Studio ile [`murat internet cafe otomasyonu.sln`](murat%20internet%20cafe%20otomasyonu.sln) çözümünü açın.
3. Varsa **Restore NuGet Packages** adımını çalıştırın; eksik proje referanslarını kontrol edin.

Veritabanı kurulmadan uygulamayı başlatmayın. Önce kaynakta `SqlConnection` kullanımlarını ve `App.config` bağlantılarını inceleyin. Kendi yerel, boş test veritabanınızı kullanın; başka bir bilgisayara ait sunucu adı sizin ortamınızda çalışmayabilir. Beklenen tablolar ve varsa stored procedure'ler ayrıca hazırlanmalıdır. **Mevcut depoda bu adımları yeniden üreten bir SQL betiği yoktur.**

Bağımlılıklar ve veritabanı hazırlandıktan sonra Visual Studio'da çözümü derleyip başlangıç projesini çalıştırın. Gerçek müşteri/öğrenci verisi veya üretim veritabanıyla denemeyin.

## Dosyaları nasıl okumalı?

- [`murat internet cafe otomasyonu.sln`](murat%20internet%20cafe%20otomasyonu.sln): Visual Studio çözümü; projeyi açma noktası.
- [`murat internet cafe otomasyonu.csproj`](murat%20internet%20cafe%20otomasyonu/murat%20internet%20cafe%20otomasyonu.csproj): hedef framework, dosyalar ve bağımlılık referansları.
- [`Kaynak klasörü`](murat%20internet%20cafe%20otomasyonu): `Program.cs` başlangıç noktası, form `.cs` dosyaları ekran davranışları.
- `.Designer.cs` ve `.resx`: form tasarımı ve kaynaklar; önbellek değildir, korunur.
- `bin`, `obj`, `.vs`: yeniden üretilen derleme/IDE dosyaları; kaynak kod yerine kullanılmaz ve Git'e eklenmez.

NuGet paket tanımları:

- [`packages.config`](murat%20internet%20cafe%20otomasyonu/packages.config)

## Doğrulama ve sınırlar

- Bu düzenlemede proje yapısı, hedef framework, bağımlılık referansları ve Git dosya listesi kontrol edildi.
- Uygulama başlatılmadı; derleme, ekran akışları ve veritabanı işlemleri test edilmedi.
- Depoda bu çalışma sırasında çalıştırılmış bir otomatik test sonucu yoktur.
- Katkıda bulunurken kurulumun tamamını temiz bir kopyada, yalnız sentetik verilerle doğrulayın; çalıştırdığınız komutları ve sonuçları PR'a yazın.

## Katkı ve kullanım

Küçük değişiklikler için ayrı dal ve pull request kullanın. Parola, bağlantı sırrı, gerçek veri, yedek veya lisanslı bileşen yüklemeyin. Üçüncü taraf bileşenlerin lisansları ayrıca geçerlidir; bu düzenleme projeye yeni bir kullanım lisansı vermez.

## Geliştirici

**Murat AKTAŞ** · [GitHub](https://github.com/Mur-47)
