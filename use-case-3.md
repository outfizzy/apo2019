Use Case 4: Podgląd salda
Aktor podstawowy: Klient

Główni odbiorcy i oczekiwania względem systemu:
Klient: oczekuje bezproblemowej i bezpiecznej zmiany PIN swojej karty.

Bank: oczekuje spójności danych w systemie i zadowolenia Klienta.

Warunki wstępne:
Bankomat jest w gotowości, karta oraz klient zostali poprawnie zautoryzowani.

Warunki końcowe:
Klient może podejrzeć aktualny stan konta oraz wydtukować go.

Scenariusz główny (ścieżka podstawowa):
Klient podchodzi do bankomatu.
Klient wsadza kartę.
Bankomat sprawdza poprawność karty.
Klient wprowadza aktualny PIN.
Klient wybiera opcję "Podgląd salda" w menu głównym.
Bankomat werfykuje poprawność PIN-u.
Na ekranie pojawia się aktualna kwota.
Możliwość wydrukowania aktualnego stanu konta.
Po zakończonej akcji bankomat wysuwa kartę.

Rozszerzenia (ścieżki alternatywne):
*a. W dowolnym czasie, dotyczy sytuacji kiedy system napotka problem z połączeniem sieciowym bankomat anuluje transakcje i wysuwa kartę.

3a. Fałszywa/zastrzeżona karta:
Bankomat zatrzymuje kartę.

5a. Błędny PIN (do 3 razy):
Prośba o ponowne wprowadzenie Pin-u


5b. Błędny PIN(3 raz błędny):
Bankomat zatrzymuje kartę.

8a. Błędnie potwierdzony PIN:
Bankomat wysuwa kartę.

Wymagania specjalne:
Klawiatura numeryczna

Ekran dotykowy, tekst musi być widoczny z odległości 1m

Stabilne połączenie sieciowe

Wymagania technologiczne oraz ograniczenia na wprowadzane dane:

Kwestie otwarte:

Czy karta powinna zostać wysunięta po nagłym restarcie bankomatu?
