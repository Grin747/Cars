# Cars
Тестовое задание АО "БРСК".

Требуется разработать приложение, реализующее следующий функционал:

1. Вывод списка всех марок авто (неактивные марки отображаются бледным) с фукцией добавления/редактирования справочника марок.

2. Вывод списка всех моделей авто (неактивные модели отображаются бледным); с фукцией добавления/редактирования справочника моделей.

3. Вывод списка моделей автомобилей, сгруппированных по маркам.

Авторизация не требуется (по желанию можно прикрутить JWT, будет весомым плюсом)

Приложение должно быть написано на ASP .NET CORE MVC.
Используемый язык: C#
БД: MS SQL/PostgreSQL
Используйте в качестве ORM Entity Framework (использование Dapper и т. д.  будет плюсом) и Bootstrap для интерфейса приложения.

При выполнении задания используйте следующие сущности:
•	Brand – марка автомобиля (BMW, Toyota и пр.);
•	Model – модель автомобиля конкретной марки (BMW X6, Toyota Corolla, и пр.).
Для каждой сущности используются поля Name (имя марки, имя модели) и поля Active (активна текущая запись или нет).
Соответственно, таблицы в БД будут иметь вид:
•	Brands, поля: Id, Name, Active (не менее 8 записей в таблице);
•	Models, поля: Id, BrandId, Name, Active (по 3-5 записей на марку автомобиля.

