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


// Controller: Kullan�c�dan gelen istekleri (request) kar��layan ve uygun bir response d�nen s�n�flard�r. Genellikle i� mant��� burada i�lenir ve Model ile View aras�ndaki ileti�imi sa�lar.
// Action: Controller i�erisinde yer alan ve HTTP isteklerini (GET, POST vb.) i�leyen metotlard�r. �rne�in, kullan�c�n�n bir sayfaya ula�mas� veya form g�ndermesi gibi durumlarda �al���r.
// Model: Uygulaman�n verilerini ve bu verilerle ilgili i� kurallar�n� temsil eden s�n�flard�r. Genellikle veritaban� i�lemleri burada yap�l�r.
// View: Kullan�c�ya g�sterilen aray�z k�sm�d�r. View�lar, HTML, CSS ve Razor kullanarak olu�turulan sayfalard�r. Controller'dan gelen veriler burada g�r�nt�lenir.
// Razor: ASP.NET Core'da HTML ile C# kodunu bir arada kullanmam�z� sa�layan bir �ablon motorudur. Dinamik web sayfalar� olu�turmak i�in kullan�l�r.
// RazorView: Razor dosyalar� (cshtml) ile olu�turulan sayfalar�n �al��ma an�ndaki g�r�nt�lenme halidir. Dinamik olarak verilerle doldurulur.
// wwwroot: Statik dosyalar�n (CSS, JS, resimler vb.) depoland��� klas�rd�r. Bu klas�rde yer alan dosyalara do�rudan eri�ilebilir.

// builder.Build(): Uygulama yap�land�rmas�n� tamamlayan ve uygulama nesnesini olu�turan metottur. Bu nesne uygulaman�n ayarlar�n�, middleware�leri ve rota yap�land�rmalar�n� bar�nd�r�r.
// app.Run(): Uygulaman�n ba�lat�lmas�n� ve gelen isteklerin middleware pipeline �zerinden i�lenerek yan�tlanmas�n� sa�layan metottur. Uygulama bu noktadan sonra �al��maya ba�lar ve istekleri dinler.
