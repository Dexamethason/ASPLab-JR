# ASPLab-JR

## Wersja ASP.Net
Projekt wykorzystuje ASP.NET w wersji 6.0.

## Baza danych
Do przechowywania danych wykorzystana jest baza danych SQLite.

## Dodatkowe biblioteki
- **Moq**: Biblioteka używana do tworzenia mocków w testach jednostkowych.
- **xUnit**: Framework do testów jednostkowych używany w projekcie.

## Dane użytkowników
Dostęp do aplikacji zapewniają następujące dane logowania:
- Użytkownik zwykły:
  - Login: user@gmail.com
  - Hasło: user
- Użytkownik z uprawnieniami administracyjnymi:
  - Login: admin@gmail.com
  - Hasło: admin

## Proces uruchomienia
Aby uruchomić aplikację w środowisku deweloperskim, należy wykonać następujące kroki:
1. Sklonuj repozytorium.
2. Przed uruchomieniem aplikacji wykonaj polecenie `dotnet ef database update` w terminalu. Migracja bazy danych jest już przygotowana.
3. Uruchom aplikację.

## Własne funkcjonalności
- **Wyszukiwarka**: W aplikacji zaimplementowano wyszukiwarkę dla każdego z trzech głównych modeli (Photo, Author, Address).
- **Edycja**: Edytowanie, usuwanie oraz dodawanie Zdjęć, Autorów i Adresów
- **Wyświetlanie powiązanych modeli**: W szczegółach Autora dostępna jest funkcja wyświetlająca powiązane modele.
- **API**:
  - https://localhost:7111/api/v1/address
  - https://localhost:7111/api/v1/author
  - https://localhost:7111/api/v1/photo

## Link do repozytorium
[GitHub - Dexamethason/ASPLab-JR](https://github.com/Dexamethason/ASPLab-JR)
