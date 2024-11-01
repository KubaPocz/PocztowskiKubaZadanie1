Zadanie1 z Wprowadzenia do Programowania Gier

Korzystając z Unity 3D przygotuj scenę, która zostanie skomponowana zgodnie
z przedstawionymi zasadami:

1. Na scenie umieść cztery platformy (obiekty typu Plane):
a. Platforma 1 o wymiarach 4 x 4 – z teksturą trawy
b. Platforma 2 o wymiarach 3 x 3 – z teksturą lawy wulkanicznej
c. Platforma 3 o wymiarach 5 x 9 – z teksturą skały
d. Platforma 4 o wymiarach 11 x 2 – z teksturą piasku.

3. Na platformie 1 umieść postać gracza w pierwszej osobie (możesz użyć gotowego
prefabrykatu ze sklepu).

5. Do przemieszczania się gracza pomiędzy platformami wykorzystywane są punkty
teleportacji.

7. Postać gracza ginie, gdy spadnie z platformy (ze sceny usuwana jest postać gracza a gra
się kończy)

9. Na każdej z platform gracz powinien odszukać i zabrać zasobnik (obiekt typu Cube). Po
odszukaniu i zabraniu zasobnika gracz może się teleportować na kolejną platformę. Gdy
gracz zdobędzie cztery zasobniki gra się kończy.

11. Kolejne platformy wyglądają i działają w następujący sposób:

a) Platforma 1
Platforma 1 otoczona jest murkiem, od którego odbija się poruszająca się piłka. Po
kontakcie z murkiem piłka losowo porusza się w jednym z trzech kierunków wskazanych na
rysunku 1. Gdy dojdzie do kolizji piłki z postacią gracza gra rozpoczyna się od początku.

b) Platforma 2
Platforma 2 zawiera cztery wrota. Gdy gracz znajdzie się na platformie aktywne
(widoczne) są wrota 1. Gdy gracz przejdzie przez wrota 1 uaktywniają się wrota 2, gdy gracz
przejdzie przez wrota 2 uaktywniają się wrota 3, gdy gracz przejdzie przez wrota 3 uaktywniają
się wrota 4. Gdy gracz przejdzie przez wrota 4 może zabrać zasobnik i teleportować się na
platformę 3.

c) Platforma 3
Platforma 3 zawiera postacie trzech przeciwników (obiekty Cylinder). Zadanie gracza
polega na zniszczeniu przeciwników (korzystając z mechanizmu rzucania promienia). Gdy gracz
wyeliminuje trzech przeciwników może się teleportować na platformę numer 4.

d) Platforma 4
Platforma 4 zawiera zestaw potencjalnych zasobników. Tylko jeden z zasobników jest
prawdziwy. Gdy gracz wejdzie w kolizję z właściwym zasobnikiem jego kolor powinien zmienić
się na zielony a gracz powinien uzyskać możliwość jego zabrania. Po zabraniu zasobnika z
platformy 4 się kończy.
