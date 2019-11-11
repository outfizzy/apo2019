Use Case 1: Wypłata gotówki
=====================

  **Aktor podstawowy:** Klient


Główni odbiorcy i oczekiwania względem systemu:
-----------------------------------------------

  - Klient: oczekuje szybkiej i niezawodnej wypłaty gotówki.

  - Bank: oczekuje spójności danych w systemie i zadowolenia Klienta.


Warunki wstępne:
----------------

  Klient i karta przeszły pomyślnie proces autoryzacji.

Warunki końcowe:
----------------

  Klient pobrał pieniądze, informacja o transakcji została wysłana poprzez odpowiedni interfejs do systemu informatycznego banku.

Scenariusz główny (ścieżka podstawowa):
---------------------------------------

  1. Klient wybiera opcję "Wypłata gotówki" w menu głównym.
  2. Bankomat wyświetla menu z kwotami do wypłacenia.
  3. Klient wybiera jedną z predefiniowanych kwot.
  4. Bankomat posiada odpowiednią liczbę stosownych nominałów do wypłacenia wprowadzonej kwoty, wobec czego akceptuje ją.
  5. Bankomat wysyła zapytanie do systemu bankowego z żądaną kwotą.
  6. Bankomat otrzymuje pozytywną odpowiedź od systemu bankowego zezwalającą na kontynuację procesu.
  7. Klient zgadza się na wydrukowanie potwierdzenia.
  8. Klient zabiera kartę.
  9. Klient zabiera gotówkę.
  10. Klient zabiera potwierdzenie.
  11. Bankomat wysyła informację o transakcji do systemu bankowego.
  12. Klient odchodzi od bankomatu.

Rozszerzenia (ścieżki alternatywne):
------------------------------------

  3a. Klient wybiera opcję wpisania kwoty własnej.
  3a1. Klient wpisuje swoją kwotę i zatwierdza ją.

  4a. Bankomat nie posiada odpowiedniej liczby stosownych nominałów potrzebnych do wypłacenia wprowadzonej kwoty, wobec czego nie akceptuje jej.
  4a1. Bankomat powraca do punktu 2.

  6a. Bankomat otrzymuje negatywną odpowiedź od systemu bankowego, która nie zezwala na kontynuację procesu.
  6a1. Bankomat wyświetla użytkownikowi komunikat o niepowodzeniu.
  6a2. Bankomat wysuwa kartę kończąc cały proces.

  7a. Klient nie zgadza się na wydrukowanie potwierdzenia.
  7a1. Klienta nie dotyczy punkt 10.

Wymagania specjalne:
--------------------

  - Klawiatura numeryczna.

  - Ekran dotykowy, tekst musi być widoczny z odległości 1m.

  - Stabilne połączenie sieciowe.

Wymagania technologiczne oraz ograniczenia na wprowadzane dane:
---------------------------------------------------------------

  3a. Kwota nie może być większa niż 3000 PLN oraz cyfra jedności musi być zerem (zaokrąglanie do dziesiątek).

Kwestie otwarte:
----------------

  - Czy bankomat w momencie nieposiadania odpowiedniej liczby nominałów powinien przerwać cały proces wysuwając kartę, czy wykonywać ścieżkę alternatywną 4a. zawierającą powrót do punktu 2?

  - Co w przypadku, gdy bankomat wypłaci gotówkę, a połączenie z systemem banku zawiedzie?
