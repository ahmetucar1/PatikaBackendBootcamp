var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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


/*
- Controller = MVC yapısında kullanıcı isteklerini işleyen, veriyi Model’den alıp View’a gönderen ve uygulamanın iş mantığını yöneten bileşendir.
- Action = MVC’de bir Controller içindeki metottur ve kullanıcının isteğine göre belirli bir işlemi gerçekleştirip bir View veya veri döndürür.  
- Model = MVC’de uygulamanın veri yapısını temsil eden bileşendir ve veri tabanı ile Controller arasında veri alışverişini sağlar.
-  View = MVC’de kullanıcıya gösterilecek arayüzü oluşturan bileşendir ve Model’den gelen veriyi görselleştirerek sunar.
- Razor = MVC’de HTML içinde C# kodu yazmayı sağlayan, dinamik ve verimli bir şablon motorudur.
- RazorView = MVC’de Razor sözdizimini kullanarak dinamik HTML içeriği oluşturan ve kullanıcıya sunulan arayüzü render eden bileşendir.
- wwwroot = MVC uygulamasında statik dosyaların (CSS, JavaScript, resimler vb.) barındırıldığı kök dizindir ve bu dosyalar doğrudan web tarayıcılarına sunulur. 
- builder.Build() = Servisleri, middleware'leri ve ayarları birleştirerek uygulamayı dağıtıma hazır hale getirir.
- app.Run() = Web uygulamasının çalışmaya başlamasını sağlayan ve gelen istekleri işlemek için bir HTTP sunucusu başlatan metoddur.
*/
