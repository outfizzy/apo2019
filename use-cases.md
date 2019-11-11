Opis skrócony przypadków użycia
===============================

Aktorzy procesu i ich cele
--------------------------

| Aktor   | Cel                                                          |
| ------- | ------------------------------------------------------------ |
| Klient  | Chce wypłacić, wpłacić gotówkę, sprawdzić stan konta, zmienić PIN. |
| Technik | Chce uruchomić, zrestartować lub zatrzymać bankomat i uzupełnić brakującą gotówkę. |

Słownik
-------

| Hasło         | Opis                                                         |
| ------------- | ------------------------------------------------------------ |
| Czytnik kart  | Umożliwia odczyt danych zawartych na karcie klienta.         |
| Klient        | Osoba korzystająca z bankomatu.                              |
| Technik       | Osoba uprawniona do zarządzania bankomatem.                  |
| PIN           | 4 cyfrowy kod zabezpieczający dostęp do karty.               |
| Karta         | Karta uprawniająca do wypłaty gotówki lub umożliwiająca złożenie zlecenia płatniczego. |
| Gotówka       | Forma pieniądza w postaci banknotów.                         |
| Potwierdzenie | Dowód potwierdzający wykonanie zlecenia.                     |
| Menu          | Element interfejsu służący do wyboru czynności.              |

Przypadki użycia
----------------

### Use case 1: Wypłata gotówki

Klient podchodzi do bankomatu, wkłada kartę do czytnika. Następuje wybór języka przez użytkownika. Klient zostaje również poproszony o wpisanie PIN. Gdy wprowadzi poprawny, ukazuje się menu, z którego zostanie wybrana opcja "Wypłata gotówki". Do wyboru jest kilka sztywnych kwot, ale także widnieje pozycja z możliwością wpisania własnej sumy do wypłacenia. Użytkownik wybiera jedną z w/w możliwości. Jeśli klient ma odpowiednią kwotę pieniędzy w banku wówczas nastąpi wypłata gotówki. Na ekranie pojawi się informacja o możliwości wydrukowania potwierdzenia, na którą użytkownik może zareagować TAK lub NIE. W przypadku wyboru TAK, potwierdzenie zostanie wydrukowane. Później następuje wysunięcie karty z bankomatu.


### Use case 2: Wpłata gotówki
Klient podchodzi do bankomatu, wkłada kartę do czytnika. Ukazuje się ekran z wyborem języka, który wybiera użytkownik. Klient proszony jest o wprowadzenie numeru PIN po czym ukazuje się menu. Klient wybiera opcję "Wpłata gotówki". Pokazuje się informacja, że pieniądze przelane zostaną na rachunek powiązany z kartą, którą klient potwierdza lub anuluje. Klient potwierdza informacje i ukazuje się ekran z prośbą o wsadzenie gotówki do otworu pod ekranem. Klient wsadza gotówkę, bankomat zabiera gotówkę, przelicza i wydaje informacje o ilości pieniędzy. Klient potwierdza informację, bankomat wydaje kartę oraz drukuje potwierdzenie wykonanej operacji. Klient zabiera kartę i odchodzi od bankomatu.

### Use case 3: Podgląd salda
Klient podchodzi do bankomatu, wkłada kartę do czytnika. Ukazuje się ekran z wyborem języka. Użytkownik wybiera interesujący go język. Klient jest proszony o wprowadzenie PIN, ukazuje się menu z którego użytkownik wybiera pokaż saldo. Jeśli pin był poprawny bankomat pokazuje aktualny stan konta oraz możliwość wydruku, wypłatę gotówki oraz zakończenie transakcji. Po wybraniu opcji 1 drukuje się papier z stanem konta oraz wysuwa się karta. Po wybraniu trzeciej opcji wysuwa się tylko karta zaś po wybraniu opcji przechodzimy do akcji wypłaty z bankomatu

### Use case 4: Zmiana PIN
Klient podchodzi do bankomatu, wkłada kartę do czytnika. Ukazuje się ekran z wyborem języka. Bankomat prosi o wpisanie numeru PIN. Klient po zatwierdzeniu karty wybiera z wyświetlonego menu opcję "Zmień PIN". Klient proszony jest o wprowadzenie nowego numer PIN i jego ponowne wprowadzenie w celu weryfikacji. Bankomat wyświetla komunikat o poprawności zmiany numeru PIN, po czym wysuwa kartę z bankomatu. Klient zabiera kartę i odchodzi od bankomatu.
