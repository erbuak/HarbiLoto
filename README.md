# HarbiLoto
- Uygulamanın login ekranının açılmasıyla birlikte bir geri sayım başlar ve her dakika başında bir adet çekiliş yapılır. Bu sayfa kapatılmadığı sürece istenen sayıda kullanıcı ve bu kullanıcılara ait kuponlar oluşturulabilir ve kullanıcılar arası geçiş yapılabilir.
- Ana sayfada bulunan 'Kupon Oluştur' butonu ile açılan sayfada, kullanıcı bir sonraki çekilişin yapılacağı ana 5 saniye kalıncaya kadar istediği kadar kupon yapabilir.
- Ana sayfada bulunan 'Son Çekiliş Sonucu' butonuna tıklandığında, yapılan en son çekilişe ait datayların ve kullanıcının son çekiliş için oynadığı tüm kuponların yer aldığı sayfa açılır. Bu sayfa yeni bir çekiliş olduğunda otomatik yenilenmektedir.
- Ana sayfada kullanıcıya ait tüm kuponların yer aldığı bir Data Grid View bulunur. Bu kupon datalarının yer aldığı row'lara çift tıklandığında o kuponun ait olduğu çekiliş detayları ve kullanıcının o çekilişde oynadığı tüm kuponları içeren bir sayfa açılır.
- Projede veri tabanı kullanılmamış veya serialization işlemi yapılmamıştır. Bu sebeple uygulama tamamen kapatıldığında (Login sayfası kapatıldığında) tüm veriler yok olacaktır.
