using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parcheggio
{
    internal class Park
    {
        private int nPosti;
        
        public int NPosti
        {
            get { return nPosti; }
        }
        
        private int nEntrate;
        public int NEntrate
        {
            get { return nEntrate; }
        }
        private int nUscite;
        public int NUscite
        {
            get { return nUscite; }
        }

       public List<Entrata> enter;
        public List<Semaphore> semafori_entrata;
        public List<Uscita> uscite;
        public Park(int nPosti, int nEntrate, int nUscite)
        {
            this.nPosti = nPosti;
            this.nEntrate = nEntrate;
            this.nUscite = nUscite;
           enter= new List<Entrata>();
            semafori_entrata= new List<Semaphore>();    
            uscite= new List<Uscita> ();       
           
        }
       


    }
}
