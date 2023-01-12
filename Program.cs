using Personen;

// Datentyp Bezeichner = Wert;
int zahl = 24;
string ort = "Schule";
Random gen = new Random();
bool fensterGeschlossen = true;
byte autoTueren = 4;

// ___
// 111 = 7 = 2 hoch 3 - 1

// Instanz einer Klasse = Objekt
// Klassename = Datentyp
Person p1 = new Person();
Person p2 = new Person();

p1.name = "Daniela"; // nur möglich, da name public ist
p2.name = "Fritz";

Person p3 = new Person();
p3.name = "Herta";
p3.name = "Hilda";
Console.WriteLine(p3.name);


Kontoverwaltung.Konto k1 = new Kontoverwaltung.Konto();
// Kontostand soll geschützt werden
// schlechte Idee: k1.kontostand = 1000000;
// k1.kontostand = 1000000; // funktioniert nicht mehr, da private
System.Console.WriteLine(k1.GetKontostand());
