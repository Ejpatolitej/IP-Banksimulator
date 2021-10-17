# IP-Banksimulator
Individuellt Projekt Banksimulator

Programmet startar och visar ett välkomstmeddelande, och användaren får skriva in sitt användarnamn.
Programmet letar i listan med användare för att se om användaren finns, om inte får användaren försöka igen.
Finns användarnamnet får användaren skriva in sin pinkod, användaren har 3 försök. Om användaren skriver fel pin 3 gånger stängs programmet ner.
Är det rätt pin skriver programmet ut menyn.
Användaren kan välja att se sitt konto, flytta pengar mellan 2 konton, ta ut pengar eller logga ut.
Väljer användaren första alternativet så visas användarnamn, pin, kontonamn och pengar på konton.
Väljer användaren andra alternativet får användaren välja konto att flytta pengar från, sen vilket konto att flytta till.
Användaren får sedan välja hur mycket användaren vill flytta och programmet kollar om det finns tillräckligt med pengar på kontot, och om mängden är över 0.
Väljer användaren tredje alternativet får användaren välja konto att ta ut pengar från, sedan vilken mängd att ta ut.
Programmet kollar så att det finns tillräckligt med pengar, och att mängden är över 0.
Programmet frågar sedan efter pin igen. Om användaren skriver fel pin får användaren försöka igen.
Väljer användaren fjärde alternativet så skriver programmet ett logga ut meddelande och användaren kommer tillbaka till välkomstmeddelandet och får skriva in användarnamn igen.


REFLEKTION
Denna uppgiften var en utmaning för mig... Det jag gjorde fel i början var att jag försökte hitta ett sätt att göra en typ av array där jag kunde ha både int och string
för att göra det enklare för mig att använda värdet i alla konton. Jag började läsa på hur man gör en ny klass för att göra en användare och en lista som jag sedan kunde
använda på just det sättet. Men det visade sig vara lite för omständigt. Hade jag lagt ner lite mer tid så hade det nog inte varit några problem, men jag har haft
ett par veckor där jag har haft, låt säga, väldigt låg energi.
Att bygga skelettet för koden var ganska enkel, jag ville göra det så simpelt som möjligt, utan att krångla till det för en person som skulle se min kod.
Jag valde t.ex. att använda en switch för menyn istället för en if sats, mest för läsligheten av koden, men också för att jag redan använder if satser i min kod och
tänkte att det hade varit roligt och mer intressant att använda en switch, eftersom jag inte använder en någon annanstans.
Jag hade kunnat använda mig av fler metoder, t.ex. utskrivandet av användarkontot, och för att leta igenom min List och userArray. Hade jag suttit mer så hade jag nog gjort
det också.
Något som jag förmodligen borde gjort är att lägga in en del try catch, för att slippa krasch. Så om jag har tid senare så kommer jag göra det, men tror inte det blir av.
Har som sagt haft ett par tuffa veckor, dålig ursäkt, men kändes inte som prio eftersom det inte fanns med i kriterierna heller.
Jag hade definitivt möjlighet att slänga in fler saker från extrautmaningarna, så som att sätta in pengar. Den metoden har jag i stort sett redan, bara att ändra uttag till
insättning, så det kanske jag gör lite snabbt efter jag skrivit detta.
Kan också lägga till att man får en timeout i 3 min om man skriver fel pin, borde bara vara att sätta in en Thread.Sleep i 3 min och se till att det loopar tillbaka till login.
EDIT: La till insättning och att man får en timeout i 3 min.
Som sagt så ville jag göra en klass för att lägga till användare, och då hade det inte varit några problem att lägga till det som en extrautmaning heller,
men borde inte vara något problem nu heller. Eftersom jag använder en lista är den ju dynamisk. Då borde jag kunna lägga in det också som en del av användarmenyn.
Så skapar den en ny array i min list, som lägger in användarnamn på första indexplatsen, pin på andra, och sen får man skriva in hur många konton man vill öppna.
Men hade varit kul att testa att göra en klass bara för att lära sig hur det fungerar.
Annars har det mest varit logiken som spökat, lite med breaks och loopar som varit knäppt för mig. Men det hjälpte att skriva ner det på ett fysiskt papper, ibland så måste
man väll bara se det framför sig för att förstå vad man tänker.
Det var en kul uppgift! Jag ser framemot att få lära mig nya grejer! Denna kursen har varit väldigt mycket repetition från Programmering 1, men med fler logiska lösningar som
jag definitivt behöver jobba på!
