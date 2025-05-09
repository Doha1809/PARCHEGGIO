using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parcheggio
{
    internal class Pacchetto
    {
        Uscita uscita;
        Entrata entrata;
      public void Entrata_e_Uscita(Entrata entrata, Uscita uscita)
        {
            this.entrata = entrata;
            this.uscita = uscita;
            
        }
        public void parking(Macchina car)
        {
            entrata.Entrare( car);
            entrata.Parcheggiare(car);
            uscita.lascio(car);
        }
    }
}
