# Библиотека для работы с API R-Keeper 7

Библиотека под .NET Core 3.1, позволяет выполнять запросы к API кассовому серверу R-Keeper v7(зал, доставка, колл-центр) по HTTP-протоколу. Реализовано только несколько запросов, эта библиотека представлена как пример, а не законченный проект.

Обмен данными представляет собой обмен XML-документами

```xml
<?xml version="1.0" encoding="windows-1251"?>
<RK7Query>
  <RK7CMD CMD="GetSystemInfo"/>
</RK7Query>
```

Компания UCS предоставляет XSD схемы всех запросов и ответов, на их основе были сгенерированы классы которые сериализуются в процессе работы. Для добавления новых запросов надо сконвертировать нужные XSD файлы в классы .NET.

## Подключение к  API
По умолчанию в API R-Keeper выключен HTTP-интерфейс, для доступа необходимо его включить и перезагрузить кассовый сервер. 

## Конфигурация и запуск

```c#
RK7Die.Client rk7Client = new RK7Die.Client(
  clientOptions: new ClientOptions
  {
    Host = "https://x.x.x.x:xxxx",
    Username = "xxxx",
    Password = "xxxx",
    Path = "/rk7api/v0/xmlinterface.xml"
  });

//Запрос GetOrderList, получить все заказы за текущую смену
var resultGetOrderList = await rk7Client.SendQuery(new QueryGetOrderList(), typeof(ResultGetOrderList));
```
Для запуска Example надо прописать все данные сервера в appsettings.json

Официальная документация от UCS: https://apidocs.ucs.ru/doku.php/ru:rk7xmlinterface

## Дополнительные функции 

* Внедрение зависимостей
* Ведение журнала ILogger
* Конфигурация через IConfigureOptions<TOptions>
* Асинхронные методы

