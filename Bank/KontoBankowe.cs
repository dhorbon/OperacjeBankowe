using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class KontoBankowe
    {
        private int saldo;

        public int stan_konta() {  return saldo; }
        public int wyplac(int value)
        {
            if(value > saldo)
            {
                return 1;
            }
            else
            {
                saldo -= value;
                return 0;
            }
        } 
        public void zdeponuj(int value) {  saldo += value; }
    }
}
