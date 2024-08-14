# PolCar_WinForms

Całe rozwiązanie składa się z dwoch projeków. W tym przypadku też solucji. 
To było moje pierwsze wykorzystanie EntityFramework'a - wiec proszę o wyrozumiałość :).
Aby przetestować należy najpierw uruchomić skrypty SQL, nastepnie odpalić projekt z API a nastepnie można uruchomić apliokację WinFrom. \
W górnym panelu znajduje się ComboBox, w którym wybireany jest pracownik , po wybraniu pracownika pokazałyby się zadania. Po uruchomieniu do pamięci  wgrywane są informację takie jak priorytety, statusy zadań, pracownicy wszystkie dane pobierane przez API. 
Niewszystkie funcjoalnosci udało mi się zaimplementować. Można otworzyć okno w celu dodania zadania , ale niestety podczas testowania po stronie API wyskakuje bład związany z EF. 
