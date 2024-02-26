using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal interface OperacjeBankowe
    {
        public int wyplac(int value);
        public void zdeponuj(int value);
        public int pobierz_saldo();
    }
}
