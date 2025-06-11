using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    internal class Real
    {
            private double amount;

        public Real(double amount)
        {
           if (amount < 0) amount = 0;

           else this.amount = amount;

        }
        public double GetAmount()
        {
            return amount;

        }
        public void SetAmount(double amount)
        {

            this.amount = amount;
        }

        public double Amount
        {
            get
            {
                return this.amount;
            }
            set
            {
               
                this.amount = value;
            }
        }
    }
    }

