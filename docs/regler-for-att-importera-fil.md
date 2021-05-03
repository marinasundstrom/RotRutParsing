# Regler för att importera fil till Rot och rut – företag

*Källa: [Skatteverket.se](https://www.skatteverket.se/foretagochorganisationer/sjalvservice/allaetjanster/tjanster/rotochrutforetag/reglerforattimporterafiltillrotochrut.4.76a43be412206334b89800033198.html)*

Istället för att fylla i begäran om utbetalning för rot- och rutarbete manuellt kan uppgifterna fyllas i genom att en XML-fil importeras till tjänsten. Uppgifterna i XML-filen fylls i med automatik och den inloggande användaren behöver bara leta rätt på filen som ska importeras på sin dator. Det regelverk som gäller för XML-filen framgår nedan beroende på vilken typ av fil du vill importera. Det går inte att blanda begäran om utbetalning för rotarbete och utbetalning för rutarbete i samma fil.

Vissa regler verifieras direkt i XML-schemat medan andra verifieras när begäran i nästa steg skickas in från e-tjänsten. De regler som gäller för att kunna skicka in en begäran för rot- och rutarbete visas i tabellen nedan.

## Validering i e-tjänsten
* Köparens person-/organisationsnummer ska vara formellt korrekt.
* Köparens personnummer får inte vara identiskt med utförarens personnummer.
* Köparen ska fylla minst 18 år under betalningsåret
* Betalningsdatum får inte vara senare än ansökningsdatum
* Begärt belopp får inte överstiga gränsen för skattereduktion. [Se Rot- och rutavdragets storlek](https://www.skatteverket.se/privat/fastigheterochbostad/rotochrutarbete/saharfungerarrotochrutavdraget.4.d5e04db14b6fef2c866097.html#Rotochrutavdragetsstorlek).
* Begärt belopp får inte vara större än Betalt belopp.
* Begärt belopp + Betalt belopp får inte vara större än arbetskostnaden.
* Betalningsdatum för samtliga köpare måste gälla för samma betalningsår.
* Bostadsrättsföreningens organisationsnummer ska vara formellt korrekt
* Arbetade timmar och materialkostnad måste anges för minst ett arbetsområde.

## Valideringar av XML-schema
* Att personnumret är numerisk
* Betalningsdatum ska vara senare än 2009-06-30
* Det måste alltid finnas uppgifter om minst en köpare.
* Max antal köpare är 100 st.

## Övrigt
För arbeten med fastpris ska alltid faktiskt antal arbetade timmar anges. 