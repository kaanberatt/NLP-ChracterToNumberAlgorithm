# NLP-ChracterToNumberAlgorithm

NLP – Karakter’den Numara’ya Dönüşüm Çalışması 
 
Geliştirme Sırasında kullanılan teknoloji ve araçlar:

  • Visual Studio 2022
  
  • .Net 6.0
  
  • C# 
  
  • MVC Web API 
 
Proje İçeriği 
1 adet string input alan MVC Web API metodu geliştirilecektir. İlgili string input JSON formatında API 
metoduna POST işlemi ile gönderilecektir. Testler sırasında aşağıdaki JSON sorgusu için gönderim 
yapılacaktır. 


    "UserText": "yüz bin lira kredi kullanmak istiyorum"  

 
POST ile gönderilen bu text verisi, API metodu içinde işlenerek cümle içindeki yazı ile yazılmış rakamlar, 
numeric formata dönüştürülecektir. Yani yukarıdaki örnekte belirtilen text aşağıdaki output haline 
dönüştürülecektir.


     "Output": "100000 lira kredi kullanmak istiyorum" 

Proje için geliştirilecek olan API metodu yukarıdaki JSON verisini output olarak geri döndürmelidir. 
Özetle proje sadece 1 adet string input alarak, geriye yine sadece 1 adet string output döndürecektir 
 
Projenin testleri sırasında kullanılacak örnek input ve output değerleri sonraki sayfada yer alan tabloda 
belirtilmiştir. API methoduna test sırasında gönderilecek olan bu ve buna benzer input değerleri 
tablodaki örnek output değerlerine çevrilerek JSON sonuç halinde geriye döndürülmelidir. 
 
Notlar: 
1. Yazılan user text değerleri küçük-büyük harf bağımsız olmalıdır. (YÜZBİN ya da yüzbin şeklinde 
yazılabilir) 
 
 
 ![Screenshot 2023-03-14 101529](https://user-images.githubusercontent.com/82910211/224924182-3987b044-7527-48ee-bc0b-20dc1184dff2.png)


 
 
Opsiyonel ek özellik (BONUS) : 

Yukarıdaki ifadelerin hem rakam hem metin içeren hallerinin de NLP tarafından desteklenir hale 
getirilmesi ile ilgili ek bir özellik geliştirilmesi beklenmektedir. Geliştireceğiniz servisi aşağıdaki ifadeleri 
de destekler halde teslim edebilirseniz bu ek bir artı kazandıracaktır. 

![Screenshot 2023-03-14 101544](https://user-images.githubusercontent.com/82910211/224924434-3967b6c7-ef7e-4ac5-8942-fb1ead322cea.png)

 
