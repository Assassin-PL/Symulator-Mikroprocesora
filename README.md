# Symulator Mikroprocesora

## Przegląd
Ten projekt to symulator mikroprocesora napisany w języku C# z wykorzystaniem Windows Forms do stworzenia graficznego interfejsu użytkownika (GUI). Projekt demonstruje, jak można implementować i wykonywać podstawowe instrukcje assemblerowe w kontekście symulowanego mikroprocesora.

## Funkcje
- **Graficzny Interfejs Użytkownika:** Intuicyjny GUI umożliwiający wprowadzanie, ładowanie, zapisywanie oraz wykonywanie programów assemblerowych.
- **Symulacja Mikroprocesora:** Obsługa podstawowych instrukcji takich jak MOV, ADD i SUB.
- **Rejestry Procesora:** Wizualizacja stanów rejestrów procesora w czasie rzeczywistym.
- **Krokowe Wykonywanie Programu:** Możliwość wykonania programu krok po kroku.

## Wymagania
- .NET Framework (preferowany najnowszy)
- Visual Studio lub inny kompatybilny IDE

## Instalacja
1. Sklonuj repozytorium:
    ```sh
    git clone https://gitlab.com/your-username/your-repository.git
    ```
2. Przejdź do katalogu projektu:
    ```sh
    cd your-repository
    ```
3. Otwórz projekt w Visual Studio lub innym preferowanym IDE.

## Użycie
1. Otwórz projekt w Visual Studio i skompiluj go.
2. Uruchom aplikację, aby otworzyć okno symulatora mikroprocesora.
3. Wprowadzaj instrukcje assemblerowe w odpowiednim polu tekstowym lub załaduj program z pliku.
4. Wykonaj program, korzystając z dostępnych przycisków.

## Opis Plików
- `Program.cs`: Główny punkt wejścia aplikacji. Inicjalizuje GUI i uruchamia główną formę.
- `Form1.cs`: Zawiera logikę głównego okna aplikacji, w tym obsługę przycisków i aktualizację wyświetlanych informacji.
- `Form1.Designer.cs`: Kod generowany automatycznie, definiujący układ i wygląd GUI.
- `Processor.cs`: Logika symulatora mikroprocesora, w tym obsługa instrukcji i rejestrów.
- `App.config`: Plik konfiguracyjny aplikacji.

## Przykładowe Użycie
Aby skompilować i uruchomić projekt, otwórz plik `Symulator Mikroprocesora.csproj` w Visual Studio, skompiluj go i uruchom. Użyj interfejsu użytkownika, aby dodawać instrukcje, ładować programy z plików, wykonywać je i monitorować stany rejestrów.

## Wkład w Projekt
Wkłady są mile widziane! Proszę forkować repozytorium i przesyłać pull requesty.

## Licencja
Ten projekt jest licencjonowany na podstawie licencji MIT. Zobacz plik [LICENSE](LICENSE) po więcej szczegółów.

---

Jeśli napotkasz jakiekolwiek problemy lub masz sugestie dotyczące usprawnień, proszę dać znać. Miłej pracy!
