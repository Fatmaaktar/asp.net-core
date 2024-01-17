## Web Uygulamalarında Genel Bazı Terimler
**Request** Client üzerinden User'in yaptığı istektir  
**Response** Sunucunun işlenen web sitesini tekrar tarayıcıya yüklemesi durumu  
**HTTP** Client ve server arası bağlantı sağlamak için kullanılan protokoldür  
### HTTP Fonksiyonları  
**GET** Sunucudan verileri listeler  
**POST** Sunucuya veri göndermek eklemek içindir  
**PUT** Var olan veriyi değiştirmek yani güncellemek içindir  
**DELETE** Verileri silmek için kullanılır

## MVC Tasarım Mimarisine Genel Bakış  
**Program.cs** Asp.NET Core Console uygulamasıdır, sunucusunu bu program sayesinde ayağa kaldırır Startup.cs'deki veriler burda çağırılır   
**Startup.cs** Bu uygulamada kullanılacak servisler, ara yazılımlar vs. çağırılır  
**appsettings.json** Projede kullanılan static değerleri barındırır  
**Dependencies** Uygulamada kullanılan harici ve dahili kütüphaneleri barındırır  
**ViewResult** Response olarak bir view (cs.html) render etmemizi sağlayan action türüdür  
**PartialViewResult** ViewResult ile aynı işlevi görür farkı ise Client tabanlı Ajax isteklerinde kullanıma yatkın  
**EmptyResult** Gelen istekler neticesinde herhangi birşey döndürmez  
**ContentResult** Metinsel içerikleri döndürür  
**ActionResult** Geriye döndürülecek action türleri değişkenlik gösterdiği durumlarda kullanılır  
**Not** Controller içerisinde "NonAction" atribütü ile işaretlenen fonksiyonlar dışarıdan request karşılamazlar.  

## Asp.net
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
## WEB GELİŞTİRME YAKLAŞIMLARI
### Olay Tabanlı Programlama
Olay Tabanlı mimari de olaylar oluşturan tarafından yayımlanır, ihtiyacı olan gelip çekmez.  
Alıcılar olayı aldığında olayı hemen işlerler. Bu olay yayımlandığında onu alan bileşen o olay ile ne yapacağına karar verir.  
Alan modül cevap dönmek zorunda değildir. Bu mimari kalıp sıralı ve istek, cevap tarzı mimarilere göre daha esnek bir mimaridir.

### API  
Uygulama Programlama Arayüzü. Client ve server arası iletişimi sağlar.  
Web uygulamaları işletim sistemleri,veri tabanları, donanımlar, veyahut yazılım kütühaneleri ile iletişim kurar.

### MVC  
Model-View-Controller  

Design Pattern(Tasrım kalıbıdır). Üretilen veri ile gösterim arasında bir soyutlama esastır.  
**Model** İşlenecek veriyi temsil eden, veri taban işlemlerinin yapıldığı katmandır  
**Controller** Model ve view arası kontrolleri sağlar. Algoritmaları, servisleri,veritabanını vs. çalıştırarak istenilen veriyi üretip ihtiyaç dahilinde viewe gönderir    
**View** Elde edilen veriyi görselleştirerek sunan katmandır.  

  #### Razor
  Razor MVC projelerinde HTML kodları içerisinde c# kodlarını kullanmamızı sağlayan teknolojidir  
  **@** razor operatörüdür,razorda yorum satırları  @* ....... *@  bu şekilde ifade edilir.  
  **Not** Razorda ayrı ayrı kullanılan  scope'lar( @{....} ) derlenince tek bir scope olarak görünür  
  Razorlarda text etiketleri, sayısal işlemler, Ternary operatörü, koşul yapıları ve döngüler kullanılabilir  
  (Sayısal işlemlerde birbirinden bağımsız işlemler ayrı parantez içine alınmalı).

  ##### Halpers  
  MVC'de 3 tane halper bulunur(yardımcı methodlar);  
  ##### URL Halpers  
  Asp .NET Core MVC uygulamalarında url oluşturmak için yardımcı methodlar içeren ve o URL'e dair bilgi veren sınıflardır  
  **Methodlar**  
  -Action  
  -ActionLink  
  -Content  
  -RouteUrl  

  **Propertyes**
  -ActionContext  


  ##### HTML Halpers  
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

  ##### Tag Helpers  
 Tag Helpers, razor sayfalardaki server-side kodları HTML elementleri olarak oluşturmayı sağlayan; View’ın daha okunabilir, anlaşılabilir ve kolay geliştirilebilir hale gelmesine olanak tanıyan,Html Helper'ın yerini almış yapılardır. Html Helper yapılarından farkı , tüm element yerine sadece attribute oluştururlar  
 Bir view'de tag helper kullanabilmek için @addTagHelper ile Microsoft.AspNetCore.MVC.TagHelpers kütüphanesi çağırılır.  
" @addTagHelper*,Microsoft.AspNetCore.MVC.TagHelpers " ifadesi ile tüm Tag Helperlar kullanılabilir.    
<br>
**Not** Bir web Uygulamasında form tetiklendiğinde içerisindeki inputların değerleri hedef endpointe Post olarak gönderilir.  
Form içerisindeki input nesneleri post edildiğinde bu nesnelere karşılık gelen proportileri barındıran  bir nesne ile otomatik olarak bind edilirler  

### Kullanıcıdan Veri Alma Yöntemleri  
1) Form Üzerinden Veri Alma: Get ve Post ile Form üzerinden kullanıcıdan veri aalınabilir  
2) Query String : Güvenlik gerktirmeyen bilgilerin Url üzerinden taşınması için kullanılan yapılardır  **Not** Yapılan requestin türü her ne olursa olsun query string değerleri taşınabilir  
3) Route
4) Headers
5) Ajax

### Kullanıcıdan Gelen Verilerin Doğrulanması  
**_Validation**  Bir değerin içinde bulunduğu şartlara uygun olması durumudur. Belirlenen koşullara uygun olup olmadığını kontrol eder. Bu kontrole göre verilen işleme tabi tutulması durumudur  
**Modelstate** MVC'de bir type'ın data anotationslarının durumunu kontrol eden ve geriye sonuç dödüren property'dir.  
### Server Validation'ları Dinamik Olarak Client Tabanlı Uygulamak  
Bu işlemi yapmak için projemize 3 kütüphane eklememiz gerekir; Jequery,JequeryValidate ve JequeryValidationUnabtrosive kütüphaneleri. Daha sonra hangi view'de client tabanlı validation işlemi yapılacaksa bu kütüphaneler kaynak olarak belirtilmeli.  

### Layout  
Sayfadan sayfaya değişkenlik göstermeyen alanları Layout'ta tanımlıyoruz. Tutarlı düzene sahip web siteleri yapmak için(Genelde Layout işlemleri bir view dosyası üzerinden gösterilir. View altında Shared altında bir "_Layout.cshtml" dosyası oluşturulur).  
**RenderBody** Render eden view'lerin Layout'ta nereye basılacağını temsil eder.  
**_ViewStart Dosyası** Tüm viewlerdeki ortak çalışmaların yapıldığı view'dir.Bütün view'lerdeki ortak layout tanımlaması bu dosyada yapılır.  
**_ViewImports Dosyası** Razor sayfaları için kütüphane ve namespace tanımlamalarını yaptığımız dosyadır.  

### Modüler Tasarım Yapılanması  
**PartialView** Modüler tasarımda her bir modülün ayrı bir .cshtml parça olarak tasarlanmasını ve ihtiyaç doğrultusunda ilgili parçanın çağrılıp kullanılımasını sağlayan bir yöntemdir.  
**ViewComponent** İhtiyacı olan dataları controller üzerinden değil direkt kendi cs dosyasından elde edebilmektedir. Böylece Controllerdaki maliyeti ortadan kaldırır.  
**Not** "Public IViewComponentResult Invoke(){}" Tasarlanan ViewComponent çağırılıp render edildiğinde içerisinde çalışmasını istediğimiz kodları bu imzada bir methodun içerisine yerleştirmeliyiz..  
### Route Yapılanması  
Gelecek olan isteğin hangi rotaya gideceğini belirleyen şablonlardır.  
#### Custom Route Handler  
Herhangi bir belirlenmiş route şemasının controller sınıflarından ziyade bisuness mantığında karşılanması ve orada iş görüp responsenin dönülmesi operasynudur(resim boyutlandırma vb. işlemler  
### Middleware  
 Web uygulamasına client'ten gelen requeste karşılık verecek response'a kadar arada farklı işlemler gerçekleştirmek ve sürecin gidişatına farklı yön vermek için. Sarmal bir şekilde tetiklenirler  
 **Not** Configure metodu içerisinde middleware'ler çağırılır. Asp .NET Core mimarisinde tüm middlewareler Use adı ile başlar  
 ### Hazır Midleware'ler  
 #### Run Metodu  
 Kendisinden sonra gelen middleware'i tetiklemez. Bu yüzden akış kesilir. Buna Short Circuit(Kısa Devre) denir  
 #### Use Metodu  
 Devreye girdikten sonra süreçte sıradaki middleware'i çağırmakta ve normal middleware işlevi bittikten sonra geriye dönüp devam edebilen yapıya sahip  
 #### Map Metodu  
 Bazen middleware'i talep gönderen path'e göre filtrelemek isteyebiliriz. Bunun için use ya da run fonksiyonlarında if kontrolü sağlayabilir yahut map metodu ile daha profesyonel işlem yapabiliriz  
 #### MapWhen Metodu  
 Map metodu ile sadece requestin yapıldığı path'e göre filtreleme yapılırken MapWhen metodu ile gelen requestin herhangi bir özelliğine göre filtreleme işlemi gerçekleştirilebilir  

 ### Dependency Injection (Bağımlılık Enjeksiyonu)  
 Temel olarak oluşturulan bir sınıf içerisinde başka bir sınıfın nesnesini new anahtar sözcüğü ile oluşturulmamasını söyleyen bir yaklaşımdır.  
 Sınıf içerisinde ihtiyaç olan nesnenin ya Configurator'dan ya da setter metoduyla parametre olarak alınması gerektiğini savunur. Böylece her iki sınıfı birbirinden izole etmiş olur.  
### IoC Nedir? Çalışma Mantığı  
Dependency Injection kullanarak enjekte edilecek olan tüm değerler/nesneler IoC Container dediğimiz bir sınıfta tutulurlar. Ve ihtiyaç doğrultusunda bu değerler çağırılarak elde edilirler  
#### Asp.NET Core'de IoC Yapılanması  
.Net uygulamalarında IoC yapılanmasını sağlayan third party frameworkler mevcuttur(Structurmap,AutoFac,Ninject vb.)  
### Built-in IoC Container  
İçerisine koyulacak nesneleri üç farklı davranışta alır...   
**Singleton** Uygulama bazlı tekil nesne oluşturur.Tüm taleplere o nesneyi gönderir  
**Scoped** Her request başına bir nesne üretir ve o requesti pipeline'nında olan tüm isteklere o nesneyi gönderir  
**Transient** Her requestin her talebine karşılık bir nesne üretir ve gönderir.  

### Area  
Web uygulamasında farklı işlevsellikleri ayırmak için kullanılan özelliktir. Bu işlevler için farklı katmanlarda bir route ayarlamamızı sağlayan ve bu katmanda o işleve özel yönetim sergileyen bir yapılanmadır.  
Her bir area içerisinde View,Controller ve Model barındırır  
#### Nerelerde kullanılır?  
1) Yönetim Paneli
2) Faturalandırma Sayfayfaları
3) İstatistiksel Paneller
4) İşlevsel Modüller Vs...

**Not** Area içinde controller Area Attribute'u ile işaretlenmelidir. Aksi taktirde farklı area'larda ki controller'lardan aynı isimde olanlar çakışır   
**Not** Her bir area içerisindeki controller'lara erişim için farklı bir route sağlamaktadır. Bu route tarafımızca sağlamnalıdır  
**MapControllerRoute** default area rotası belirlememizi sağlar  
**MapAreaControllerRoute** bir area'ya özel rota belirlememizi sağlar  

### TDO(Data Tranfer Object)  
Herhangi bir davranışı olmayan ve uygulamanın çeşıtli yerlerinde yanlızca bir veri tüketimi için kullanılan veritabanındaki herhangi bir verinin fransfer nesnesidir  
### ViewModel  
OOP yapılanmasında bir modelin kullanıcıyla etkileşimi neticesinde kullanılan ve esas datanın memberlarını temsil eden ve süreate ilgili model yerine veri taşımayı üstlenen bir nesnedir.  
Ya da birden fazla modeli tek bir nesne üzerinden birleştirme görevi gören nesnedir(her iki senaryo içinde geçerli)  

**Not** Kullanıcıya sunulan hiçbir veri direkt olarak veritabanındaki entitiy türünden olmamamlıdır. Bu tarz durumlarda ViewModel kullanılmalıdır  
#### Kontrat/Sözleşme Mantığı  
Backend'de üretilen bir verinin client'e gönderilmesi için tasarlanan ViewModel o işlemin sözleşmesi olmaktadır. Haliyle Backend'de gelecek datayı client'ın uygun formatta karşılayabilmesi için kesinlikle o türden bir nesne oluşturması gerekecektir  
#### ViewModel'i Entity Model'e Dönüştürme  
Kullanıcıdan gelen dataları ViewModel ile karşıladıktan sonra bu ViewModel'da ki verileri veritabanına kaydetmek isteyebiliriz. Bu durumda bu verileri Entitiy Model'a dönüştürmemiz gerekecektir. Bunun için aşağıdaki yöntemlerden herhangi biri kullanılabilir:  
1) Manuel
2) Implicit Operator Overload
3) Expilit Operator Overload
4) Reflection
5) AutoMapper Library

### Configuration (Yapılandırma)  
<li>
  Yapılandırma genellikle algoritmanın dışında lakin algoritmada kullanılacak olan değerleri belirleme  sürecidir
</li>
<li>
  Yapılandırma, bir uygulamanın herhangi bir ortamda gerçekleştireceği davranışlarını belirlememizi sağlayan static değerin tanımlanmasıdır
</li>
<li>
  Eski Asp.NET uygulamalarında kullanılan web.config yahut Global.asax gibi dosyalar standart framework'ün yapılandırılmasında kullanılan ortamlardır
</li>  

**appsettings.json**  Veri tabanı bağlantısı gibi sabit ifadeleri belirli bir yerden çekmek isterken appsetting dosyasını kullanılır  

#### Asp.NET Core'da ki appsettings.json Dışında Yapılandırma Araçları  
<li>
  Appsettings.json | appsettings.{Environment}.json
</li>
<li>
  Secrets.json (Secret Manager Tools)
</li>
<li>
  Environment Variables
</li>  

**Option Pattern** appsetings.json dosyasındaki konfigurasyonları Dependency Injection ile kullanmamızı sağlayan ve yapılandırılmış olan nesnel modellerle ilgili konfigurasyonları temsil etmemizi sağlayan bir tasarım desenidir  

#### Secret Manager Tools  
Web uygulamalarında development ortamında kullandığımız bazı verilerin canlıya deploy edilmesini istemeyebiliriz, bu verilerimiz;  
<li>
  Veritabanı bilgilerini barındıran connection string değerleri
</li>
<li>
  Herhangi bir kritik arz eden token değeri
</li>
<li>
  Facebook veya Google gibi third party authentication işlemleri yapmamızı sağlayan client secret id değerler vs.
</li>  
Bu veriler deploy ortamında kullanılırken, production ortamında kötü niyetli kişilerin uygulama dosyalarına erişim sağladıkları durumlarda elde edemeyecekleri vaziyette depolanmaları gerekmektedir işte bunun için Secret Manager Tool geliştirilmiştir  

**Not** Kritik arz etmeyen yani static değerlerimizi "appsetings.json" dosyasında barındırırız ancak kritik verilerimizi "secret.json" da barındırırız  

#### Environment  
Bir web uygulamasında uygulamanın bulunduğu aşamalara dayalı davranışı kontrol etmek ve yönlendirmek isteyebiliriz bunun için Environement dediğimiz değişkenler mevcuttur  

**ASPNETCORE_ENVIRONMENT**
İlgili uygulamanın hangi ortamda ayağa kalkacağını belirtir (Development,Staging ve Production) .


