
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

  - Home Page
![HomePage](https://github.com/zagbey/WalkUniq_Mvc/assets/49595767/63f6ad09-4cd4-400b-a14a-6c6ffce81dbd)

  - Register Page  
![registerPage](https://github.com/zagbey/WalkUniq_Mvc/assets/49595767/2b70efb7-0192-4929-a6bd-969ec26ffc81)

 - Login Page
![LoginPage](https://github.com/zagbey/WalkUniq_Mvc/assets/49595767/8ffec7b3-008f-4109-ad5c-1d9dc54c1bce)
 - Shopping Cart
   ![ShoppingCart](https://github.com/zagbey/WalkUniq_Mvc/assets/49595767/4b2599ab-f8e7-4bdf-9fda-81c7543f518b)
 - Stripe Payment
   ![StripeOdeme](https://github.com/zagbey/WalkUniq_Mvc/assets/49595767/aa0bec66-7b16-42fd-b325-7669e48b891a)
 - Order Confirm Page
   ![OrderConfirmedPage](https://github.com/zagbey/WalkUniq_Mvc/assets/49595767/3ccedff0-3bad-4b24-a70a-61f678da4f98)

 - Admin Content Manager (CRUD)
  ![AdminProductManagement](https://github.com/zagbey/WalkUniq_Mvc/assets/49595767/2bdd856c-a461-4311-8fd3-88360b0fab57)

 - Product Update
  ![ProductUpdate](https://github.com/zagbey/WalkUniq_Mvc/assets/49595767/c0366a57-e768-415d-b1b1-43cea9a3fc8f)

  
 - Product Create
  ![CreateProduct](https://github.com/zagbey/WalkUniq_Mvc/assets/49595767/3e215b48-45c4-4678-a791-ffed9b4e8c01)


 - Admin Users Create 
 ![AdminUsersCreatingPage](https://github.com/zagbey/WalkUniq_Mvc/assets/49595767/8cbe8230-a85d-46d3-86b6-e9a2ea22880a)

</details>
