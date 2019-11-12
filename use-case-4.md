Use Case 4: Zmiana PIN
=====================

**Aktor podstawowy:** Klient


Główni odbiorcy i oczekiwania względem systemu:
-----------------------------------------------

- Klient: oczekuje bezproblemowej i bezpiecznej zmiany PIN swojej karty.

- Bank: oczekuje spójności danych w systemie i zadowolenia Klienta.


Warunki wstępne:
----------------

Klient i karta przeszły pomyślnie proces autoryzacji.

Warunki końcowe:
----------------

Numer PIN jest zmieniony. System bankowy jest zaktualizowany. Karta jest wysunięta z czytnika.

Scenariusz główny (ścieżka podstawowa):
---------------------------------------

  1. Klient wybiera opcję "Zmiana PIN" w menu głównym.
  2. Klient wprowadza nowy PIN.
  3. Klient wprowadza drugi raz nowy PIN w celu potwierdzenia.
  4. Bankomat aktualizuje system bankowy.
  5. Bankomat wyświetla potwierdzenie zmiany PIN i wysuwa kartę.
  6. Klient odchodzi od bankomatu.

Rozszerzenia (ścieżki alternatywne):
------------------------------------

 *a. W dowolnym czasie, dotyczy sytuacji kiedy system napotka problem z połączeniem sieciowym bankomat anuluje transakcje i wysuwa kartę.

3a. Błędnie potwierdzony PIN:

1. Bankomat wysuwa kartę.

Wymagania specjalne:
--------------------

  - Klawiatura numeryczna

  - Ekran dotykowy, tekst musi być widoczny z odległości 1m

  - Stabilne połączenie sieciowe

Wymagania technologiczne oraz ograniczenia na wprowadzane dane:
---------------------------------------------------------------

7a. Nowy PIN musi być inny od aktualnego.

Kwestie otwarte:
----------------

  - Czy klient może zmieniać PIN wielokrotnie w ciągu tego samego dnia?

  - Czy karta powinna zostać wysunięta po nagłym restarcie bankomatu?
