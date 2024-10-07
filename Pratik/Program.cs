var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();


// Controller: Kullanýcýdan gelen istekleri (request) karþýlayan ve uygun bir response dönen sýnýflardýr. Genellikle iþ mantýðý burada iþlenir ve Model ile View arasýndaki iletiþimi saðlar.
// Action: Controller içerisinde yer alan ve HTTP isteklerini (GET, POST vb.) iþleyen metotlardýr. Örneðin, kullanýcýnýn bir sayfaya ulaþmasý veya form göndermesi gibi durumlarda çalýþýr.
// Model: Uygulamanýn verilerini ve bu verilerle ilgili iþ kurallarýný temsil eden sýnýflardýr. Genellikle veritabaný iþlemleri burada yapýlýr.
// View: Kullanýcýya gösterilen arayüz kýsmýdýr. View’lar, HTML, CSS ve Razor kullanarak oluþturulan sayfalardýr. Controller'dan gelen veriler burada görüntülenir.
// Razor: ASP.NET Core'da HTML ile C# kodunu bir arada kullanmamýzý saðlayan bir þablon motorudur. Dinamik web sayfalarý oluþturmak için kullanýlýr.
// RazorView: Razor dosyalarý (cshtml) ile oluþturulan sayfalarýn çalýþma anýndaki görüntülenme halidir. Dinamik olarak verilerle doldurulur.
// wwwroot: Statik dosyalarýn (CSS, JS, resimler vb.) depolandýðý klasördür. Bu klasörde yer alan dosyalara doðrudan eriþilebilir.

// builder.Build(): Uygulama yapýlandýrmasýný tamamlayan ve uygulama nesnesini oluþturan metottur. Bu nesne uygulamanýn ayarlarýný, middleware’leri ve rota yapýlandýrmalarýný barýndýrýr.
// app.Run(): Uygulamanýn baþlatýlmasýný ve gelen isteklerin middleware pipeline üzerinden iþlenerek yanýtlanmasýný saðlayan metottur. Uygulama bu noktadan sonra çalýþmaya baþlar ve istekleri dinler.
