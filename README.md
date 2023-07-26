# Asp.net
Microsoft tarafından geliştirilmiş web uygulama geliştirme mimarisidir. 
## Asp.NET Core
- Microsoft tarafından geliştirilen ücretsiz ve açık kaynak web gelişltirme mimarisidir.
- Asp.NET'in halefidir
- Windows, Linux vs. çalışır
  ### Asp.NET Core'nin Asp.Net'ten farkları
  - daha performanslı
  - Cross platform(her yerde çalışır)
  - Modüler altyapı
  - Bağımlılık Enjeksiyonu
  - Asenkron işlemler
  - Razor Pages
## MVC Nedir?  
Model-View-Controller  
Design Pattern(Tasrım kalıbıdır). Üretilen veri ile gösterim arasında bir soyutlama esastır.  
**Model** İşlenecek veriyi temsil eden, veri taban işlemlerinin yapıldığı katmandır  
**Controller** Model ve view arası kontrolleri sağlar. Algoritmaları, servisleri,veritabanını vs. çalıştırarak istenilen veriyi üretip ihtiyaç dahilinde viewe gönderir    
**View** Elde edilen veriyi görselleştirerek sunan katmandır.  

  ## Razor
  Razor MVC projelerinde HTML kodları içerisinde c# kodlarını kullanmamızı sağlayan teknolojidir  
  **@** razor operatörüdür,razorda yorum satırları  @* ....... *@  bu şekilde ifade edilir.  
  **Not** Razorda ayrı ayrı kullanılan  scope'lar( @{....} ) derlenince tek bir scope olarak görünür  
  Razorlarda text etiketleri, sayısal işlemler, Ternary operatörü, koşul yapıları ve döngüler kullanılabilir  
  (Sayısal işlemlerde birbirinden bağımsız işlemler ayrı parantez içine alınmalı).

  ## Halpers  
  MVC'de 3 tane halper bulunur(yardımcı methodlar);  
  ### URL Halpers  
  Asp .NET Core MVC uygulamalarında url oluşturmak için yardımcı methodlar içeren ve o URL'e dair bilgi veren sınıflardır  
  **Methodlar**  
  -Action
  -ActionLink
  -Content
  -RouteUrl

  **Propertyes**
  -ActionContext  


  ### HTML Halpers  
  Html etiketlerini server tabanlı oluşturmamızı sağlayan yardımcı methodları barındırır. Hedeflenen .cshtml dosyalarını render etmemizi sağlar. Contexte ait bilgi verir. Veri taşıma kontrollerine erişmemizi sağlar.  
  **Methodlar**  
  -html.Partial
  -Html.RenderPartial
  -Html.ActionLink
  -Html Form Methodları (Html.BeginForm,Html.CheckBox,Html.TextBox,Html.Display,Html.Password,Html.TextArea,Html.ValidationMessage)

  **Properties**  
  -ViewContext
  -TempData 
  -ViewData 
  -ViewBag

  ### Tag Helpers  
 Tag Helpers, razor sayfalardaki server-side kodları HTML elementleri olarak oluşturmayı sağlayan; View’ın daha okunabilir, anlaşılabilir ve kolay geliştirilebilir hale gelmesine olanak tanıyan,Html Helper'ın yerini almış yapılardır. Html Helper yapılarından farkı , tüm element yerine sadece attribute oluştururlar.

