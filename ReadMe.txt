1.Purpose and Scope of the Project
This project has been developed to digitize film rental and sales processes,making it easier for users to create film lists,plan deliveries and handle payment transactions. The project is designed to optimize user experience
and manage business processes more efficiently.

2. General Structure of the Project
The project is built on a four-layered architecture.

MODEL: This layer defines the database entities and their relationships. For example, classes such as User, Film, and Membership are located here.
DAL (Data Access Layer): This layer is responsible for database operations (CRUD). A flexible data access mechanism has been established using a generic repository structure in this layer.
BLL (Business Logic Layer): This layer defines the business rules. Tasks such as user membership validation and delivery planning are performed here.
UI (MVC): This is the layer where interactions with users occur. Web user interfaces have been developed in this layer.

3. Technologies Used
- Backend: ASP.NET Core, Entity Framework Core  
- Frontend: HTML5, CSS3, Bootstrap, JavaScript  
- Database: Microsoft SQL Server  
- Others: SOLID principles, Generic Repository Pattern, MVC  

4. Key Features 
- Users can choose a membership type and make payments via credit card.  
- Users can create film lists and set delivery dates.  
- Management of delivery and order processes.  
- Integration of warehouse and courier management.  
- Process for replacing defective films.  
- Users can take advantage of film purchasing options.  

5. Project Workflow  
After registering in the system, users can select the films they want and create a list. Users set a delivery date and complete the payment process to place an order. The order is processed by the warehouse and courier and delivered to the user, with notifications sent via SMS and email. Each delivery is handled by a courier, and delivery processes are regularly tracked.  




1.Projenin Amacý ve Kapsamý
Bu proje,film kiralama ve satýþ süreçlerini dijitalleþtirmek,kullanýcýlar film listesi oluþturma,teslimat planlama ve ödeme iþlemlerini kolaylaþtýrmak amacýyla geliþtirilmiþtir. Proje,kullanýcý deneyimini optimize etmek ve iþ süreçlerini daha verimli bir þekilde yönetmek için tasarlanmýþtýr.

2.Projenin Genel Yapýsý
Proje,dört katmanlý bir mimariye sahiptir.
MODEL: Veritabaný varlýklarýn ve iliþkilerinin tanýmlandýðý katmandýr. Örneðin: User,Film,Membership gibi sýnýflar burada yer alýr.
DAL(Data Access Layer):Veritabaný iþlemlerinin(CRUD) gerçekleþtirildiði katmandýr.Bu katmanda,generic repository yapýsý kullanýlarak esnek bir veri eriþim mekanizmasý oluþturulmuþtur.
BLL(Business Logic Layer):Ýþ kurallarýnýn tanýmlandýðý katmandýr. Örneðin kullanýcý üyelik doðrulama ve teslimat planlama gibi iþler bu katmanda gerçekleþtirilir.
UI(MVC):Kullanýcýlarla etkileþimde bulunulan katmandýr.Web kullanýcý arayüzleri bu katmanda geliþtirilmiþtir.

3.Kullanýlan Teknolojiler
Backend:ASP.NET Core ,Entity Framework Core
Frontend: HTML5,CCS3,Bootstrap,Javascript
Veritabaný:Microsoft SQL Server
Diðer:SOLID prensipleri,Generic Repository Deseni,MVC

4.Temel Özellikler
Kullanýcýlarýn üyelik tipi seçerek kredi kartý ile ödeme yapabilmesi.
Kullanýcýlarýn film listesi oluþturmasý ve teslimat tarihi belirlemesi.
Teslimat ve sipariþ süreçlerinin yönetimi.
Depo ve kurye yönetimi entegrasyonu.
Bozuk filmlerin tedarik süreci.
Kullanýcýlarýn film satýn alma seçeneklerinden faydalanabilmesi.

5.Proje Akýþý
Kullanýcý sisteme üye olduktan sonra, istediði filmleri seçerek bir liste oluþturabilir. Teslimat tarihi belirleyen kullanýcý, ödeme iþlemini tamamladýktan sonra sipariþini verir. Sipariþ, depo ve kurye tarafýndan iþlenir ve kullanýcýya teslimat SMS ve e-posta ile bildirilir. Her teslimat bir kurye tarafýndan taþýnýr ve teslimat süreçleri düzenli olarak takip edilir.


