ASP.NET Core används för att bygga enhetliga hemsidor och eller integrera sin databas (EF Core).

I startup specificerar man tex att man använder razor pages, och Databas connection, sätter endpoints osv. Lite conifguration alltså.

wwwroot innehåller dina statiska filer, alltså de filer som inte kommer att ändras alls under programmets gång, css, javascript och bilder brukar ligga här.

Razor språket ger oss möjligheten att blanda c# kod med html kod. Vilket gör det enkelt att plocka ut variabler från tex en databas och skriva ut det i html:en.

Content page, precis som det låter innehåller huvudsakligen det visuella allstå HTML koden. Här undviker man så gott man kan att skriva c# logik.
Model page använder man för c# logiken, kalla på databaser, göra uträkningar osv.

MVC står för  Model, View, Controller. 
Model: Data relaterad logik, alltså ungefär som en model page.
View: Visuellt, Ui, html/css.
Controller: Hanterar användar inputs (Get, Post, Delete), kan få data från model, kan skicka data till view.
