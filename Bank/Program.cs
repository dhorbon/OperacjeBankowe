using Bank;

Klient klient = new("jan", "kowalski", "00000000000");

Console.WriteLine(klient.podaj_dane());

klient.dodaj_konto(1);

klient.dodaj_konto(2);

klient.konta[0].zdeponuj(1000000);

if (klient.konta[0].wyplac(200000) == 1)
{
    Console.WriteLine("brak srodkow na koncie");
}
else
{
    Console.WriteLine("pomyslnie dodano srodki");
}

Console.WriteLine(klient.konta[0].pobierz_saldo().ToString().Insert(klient.konta[0].pobierz_saldo().ToString().Length-2, ","));

klient.konta[1].zdeponuj(100000);

if (klient.konta[1].wyplac(200000) == 1)
{
    Console.WriteLine("brak srodkow na koncie");
}
else
{
    Console.WriteLine("pomyslnie dodano srodki");
}

Console.WriteLine(klient.konta[1].pobierz_saldo().ToString().Insert(klient.konta[1].pobierz_saldo().ToString().Length - 2, ","));