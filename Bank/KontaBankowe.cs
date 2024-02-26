using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class KontoOsobiste : KontoBankowe, OperacjeBankowe
    {
        const int odsetki = 5;

        int OperacjeBankowe.pobierz_saldo() { return stan_konta(); }

        int OperacjeBankowe.wyplac(int value) { return wyplac(value); }
        void OperacjeBankowe.zdeponuj(int value) { zdeponuj(value); }
    }

    internal class KontoFirmowe : KontoBankowe, OperacjeBankowe
    {
        const int odsetki = 2;

        int OperacjeBankowe.pobierz_saldo() { return stan_konta(); }

        int OperacjeBankowe.wyplac(int value) { return wyplac(value); }
        void OperacjeBankowe.zdeponuj(int value) { zdeponuj(value); }
    }
}
