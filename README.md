
# Walkuniq_MVC  

Bu proje bitirme projesi kapmasında yapılan ayakkabı satış mağazasıdır.Ödeme yöntemi olarak **Stripe** kullanıldı.Kullanıcılar üye olmama durumlarında erişimleri sınırlandırılmaktadır.3 farklı üye olma seçeneği sunulmakta bunlar;

- Customer 
- Company 
- Employee
 
Regıster olurken rol seçmeyen kullanıcıya default olarak **Customer** olarak atanmaktadır.Customer kullanıcı girişine sahip üyeler Admin portalına erişememektedir.Bu portala sadece **Admin** ve **Employee** erişebilmektedir.

>  - Kullanıcı isterse Facebook ile kayıt olabilmekte
---
**ADMIN**

> **CONTENT MANAGEMENT** başlığı altında
     PRODUCT,CATEGORY,COMPANY ve USER CRUD operasyonlarını yapabilmektedir.
    


> **MANAGE ORDER** ile stripe ödeme yöntemi ile alınan siparişlerin durumunu yönetebilmektedir.
>  - Sipariş durum kontrolü
>  - Sipariş iptali , bilgilerin güncellenmesi ve ödeme yapılmasını içermektedir.
---      
<details>
 
 <summary>KULLANILAN TEKNOLOJİLER</summary>

    - ASP NET MVC Core (.NET 8)
    - Role Management in ASP NET Core Identity
    - Stripe ödeme yöntemi
    - Facebook Authentication
    - Entity Framework
    - SQlite 
    - Repository Pattern
    - C#
    - HTML5
    - Bootstrap 5
    - CSS3
    - JavaScript
    - jQuery

</details>
<details>
 
 <summary>Ekran Görüntüleri</summary>

    ![Home Page]("C:\Users\90535\OneDrive\Resimler\Ekran Görüntüleri\bitirme projesi\Home Page.png")
  

</details>
