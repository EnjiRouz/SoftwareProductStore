# SoftwareProductStore
Software Product Store solution with some included Onion architecture-related projects : WebApplication, Services, Data, Business, Domain

В данном решении существуют заготовки для:
* бизнес-логики размещения заказа для доставки и его оплаты онлайн по карте;
* работы с созданием, изменением, удалением информации о продукте;
* работы с базой данных.

В основе решения лежит проект ASP.NET MVC 5.
В качестве хранилища данных используется база данных MS SQL Server, взаимодействие с которой осуществляется с помощью Entity Framework (можно подгрузить с NuGet).
Для связки зависимостей используется контейнер зависимостей Ninject.MVC5 (можно подгрузить с NuGet).
