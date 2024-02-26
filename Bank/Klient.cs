using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Klient
    {
        private string imie;
        private string nazwisko;
        private string pesel;

        public List<OperacjeBankowe> konta = new();

        public Klient(string imie, string nazwisko, string pesel)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
        }

        public string podaj_dane()
        {
            return imie + "\n" + nazwisko + "\n" + pesel + "\n";
        }

        public void dodaj_konto(int type)
        {
            if(type == 1)
            {
                konta.Add(new KontoOsobiste());
            }
            else
            {
                konta.Add(new KontoFirmowe());
            }
        }
    }
}
