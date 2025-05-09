using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parcheggio
{
    internal class Macchina
    {
        public int Tempo_Sosta;
        public string Targa;
        public string Marca;
        public Thread thread;
        Park parcheggio;
        public Macchina(int tempo_sosta, string Targa, string Marca) 
        { 
            this.Tempo_Sosta = tempo_sosta;
            this.Targa = Targa; 
            this.Marca = Marca;
        }
        public override string ToString()
        {
            return "La macchina con la targa: "+Targa +" e marca: "+ Marca+" ";
        }
    }
}
