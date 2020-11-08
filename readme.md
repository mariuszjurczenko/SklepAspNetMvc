# Asp.Net MVC Praktyczny Kurs
mariuszjurczenko@dev-hobby.pl 

Praktyczne rozwiązanie wykorzystujące technologię Asp.Net Mvc pokazujące krok po kroku budowanie serwisu internetowego sprzedającego kursy on-line
W kursie będziemy korzystać z Visual Studio Comunity oraz wbudowanej bazy danych localDb. 
Skorzystamy również z systemu do wersjonowania kodu i zarządzania projektem VisualStudio Online, będziemy korzystać z Gita.

Następnie rozpoczniemy pracę nad naszym projektem w którym wykorzystamy Entity Framework i podejście code first. Dodamy EF do naszego projektu, utworzymy klasy naszego modelu na podstawie których zostanie wygenerowana baza danych. W 3 odcinku dodamy przykładowe dane do naszej aplikacji, gdyż w tej chwili nasza baza danych jest pusta. EF posiada mechanizm do inicjalizowania bazy danych jakimiś przykładowymi danymi, którymi zainicjalizujemy naszą bazę.

Następnie dodamy do naszego projektu mechanizm migracji. Ponieważ wtedy, kiedy będziemy mieć już do czynienia z systemem produkcyjnym w którym będą prawdziwe dane, nie będziemy chcieli aby jakiś inicjalizator wypełniał bazę jakimiś testowymi danymi i jeszcze za każdym razem gdy uruchamiasz aplikację usuwał bazę danych razem z danymi naszych klientów. W związku z tym aby umożliwić modyfikację modelu a co za tym idzie modyfikację bazy danych w taki sposób aby dane zapisane w bazie danych nie były tracone, usuwane został wprowadzony mechanizm migracji. Migracja to właśnie możliwość zaaplikowania pewnych zmian na schemacie bazy danych w taki sposób aby dane nie były usuwane.

Następnie dodamy Makietę – prototyp aplikacji do naszego projektu, wyodrębnimy części wspólne widoków do tzw. layoutu. Dodamy strony statyczne do naszej aplikacji. Dodamy trasy dla stron statycznych. Zainstalujemy Glimpsa. Oprogramujemy stronę główną naszej aplikacji, oprogramujemy stronę z kursami w wybranej kategorii, zrobimy widok pojedynczego kursu. Dodamy scieżkę nawigacyjną, dodamy Cache, pokażę jak zrealizować mechanizm filtrowania kursów oraz autopodpowiedzi przy użyciu javaScriptu i wywołań  asynchronicznych AJAX, oraz wykorzystamy JSONa. Zaimplementujemy mechanizm koszyka. Zrobimy widoki logowania i rejestracji użytkowników. Te 2 widoki będą oparte o bardzo podobna strukturę do widoku koszyka na zakupy który już zrobiliśmy. Do naszych widoków rejestracja użytkowników i logowanie użytkowników dodamy mechanizmy obsługujące logikę rejestracji  użytkowników i logowania użytkowników, i skorzystamy tutaj z gotowych wbudowanych mechanizmów w ASP dot net MVC takich jak  ASPNET identity.

Dodamy mechanizmy pozwalające wyświetlić użytkownikowi historię jego zamówień, a administratorowi listę wszystkich zamówień złożonych przez wszystkich użytkowników, dodamy funkcjonalność która będzie nam pozwalała dodać nowy kurs do naszego sklepu oraz edytować istniejące kursy. Dodamy do naszej aplikacji możliwość monitorowania błędów, żeby wiedzieć czy np. użytkownicy naszej aplikacji  nie spotykają się z jakimiś błędami na które powinniśmy zwrócić uwagę. Do logowania komunikatów i błędów mamy gotowe mechanizmy i niema potrzeby ani sensu tworzyć własnych. W naszej aplikacji skorzystamy z Elmach i Nlog.  Elmach po dołączeniu do projektu zaloguje nam wszystkie nie wyłapane błędy. Nlog da nam możliwość logowania dowolnych  komunikatów. Dodamy do naszej aplikacji możliwość wysyłania meili, dodamy do naszej aplikacji możliwość wykonywania zadań w tle. (Hangfire). Dodamy do naszej aplikacji kontener DI (Dependency Injection). Wzorzec projektowy i wzorzec architektury oprogramowania polegający na usuwaniu bezpośrednich zależności pomiędzy komponentami.

Link do kursu https://dev-hobby.pl/kursy/asp-net-mvc-praktyczny-kurs/