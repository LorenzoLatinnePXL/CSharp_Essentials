# ControleStructuren 8: Dubbelfeest. 

Deze toepassing dient om te berekenen hoe groot de kans is dat er in een
bepaalde groep 2 of meerdere personen samen op dezelfde dag verjaren.

Je geeft het aantal personen van de groep in en drukt op de knop
Berekenen, waarna het resultaat wordt weergegeven.

**Formule om te bepalen of de personen allemaal op een verschillende dag
verjaren:**

**Bij 2 personen: 364/365**: deze tweede persoon mag op eender welke dag
verjaren, maar niet op de verjaardag van de eerste persoon. Dit geeft
99,7260%.

**Bij 3 personen: 364/365 \* 363/365**: voor de tweede persoon zelfde
redenering als daarnet, voor de derde persoon geldt dat deze niet mag
verjaren op verjaardag van de eerste of de 2^de^ persoon: hij mag dus
verjaren op eender welke andere 363 overblijvende dagen. Deze berekening
geeft 99,1796%.

**Bij 4 personen: 364/365 \* 363/365 \* 362/365**. (98,3644%)

...

Bij 12 personen: 364/365 \* 363/365 \* 362/365 \*... \* 354/365
(83,2975%)

...

**Dit bedrag aftrekken van 1 (100%) geeft dan de kans op een "meervoudig
feest":**

Bij 2 personen: 0,2740%

Bij 3 personen: 0,8204%

Bij 4 personen: 1,6356%

...

Bij 12 personen: 16,7025%

![Afbeelding met tekst, schermopname, scherm, software Automatisch
gegenereerde
beschrijving](./media/image1.png)