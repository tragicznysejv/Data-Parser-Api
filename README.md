#PL:

Parser danych API
- Projekt to endpoint HTTP napisany w technologii ASP.NET Core Web API (C# / .NET 10)
- Aplikacja przyjmuje ustandaryzowany ładunek w formacie JSON, dekoduje dane z formatu Base64 i parsuje je w zależności od przekazanego typu ('CSV' lub 'INTERNAL_JSON')

Wymagania techniczne:
- Zainstalowane środowisko #.NET 10 SDK

Instrukcja uruchomienia lokalnie aplikacji:
Aby przetestować aplikację na własnym komputerze, trzeba wykonać poniższe kroki w terminalu (np. PowerShell, Bash):
1. Pierwszym krokiem będzie pobranie repozytorium na swój dysk:
``bash
git clone  https://github.com/tragicznysejv/Data-Parser-Api.git
2. Drugim krokiem jest przejście do głównego folderu projektu:
cd ParserDanychApi
3. Trzecim krokiem jest uruchomienie aplikacji poleceniem:
dotnet run 
4. Po skompilowniu i uruchomieniu serwera, konsola powinna wyświetlić adres, pod którym nasłuchuje API (np. https://localhost:7288)
5. Ostatnią rzeczą jest przetestować działanie aplikacji, trzeba skopiować ten adres do przeglądarki i dopisać na końcu /swagger (np.https://localhost:7288/swagger). Otworzy się wtedy interfejs Swagger UI.