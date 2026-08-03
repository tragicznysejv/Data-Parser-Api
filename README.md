**PL:**

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
cd Data-Parser-Api
3. Trzecim krokiem jest uruchomienie aplikacji poleceniem:
dotnet run 
4. Po skompilowniu i uruchomieniu serwera, konsola powinna wyświetlić adres, pod którym nasłuchuje API (np. https://localhost:7288)
5. Ostatnią rzeczą jest przetestować działanie aplikacji, trzeba skopiować ten adres do przeglądarki i dopisać na końcu /swagger (np.https://localhost:7288/swagger). Otworzy się wtedy interfejs Swagger UI.

**EN:**

API Data Parser
- The project is an HTTP endpoint written using ASP.NET Core Web API (C# / .NET 10)
- The application accepts a standardized payload in JSON format, decodes data from Base64, and parses it based on the specified type (‘CSV’ or ‘INTERNAL_JSON’)

Technical Requirements:
- #.NET 10 SDK installed

Instructions for running the application locally:
To test the application on your own computer, follow these steps in a terminal (e.g., PowerShell, Bash):
1. The first step is to clone the repository to your disk:
``bash
git clone  https://github.com/tragicznysejv/Data-Parser-Api.git
2. The second step is to navigate to the project’s root folder:
cd Data-Parser-Api
3. The third step is to run the application using the command:
dotnet run
4. After the server has been compiled and started, the console should display the address where the API is listening (e.g., https://localhost:7288)
5. The final step is to test the application. Copy this address into your browser and add /swagger at the end (e.g.,https://localhost:7288/swagger). This will open the Swagger UI interface.
