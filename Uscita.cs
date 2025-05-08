using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parcheggio
{
    internal class Uscita
    {
        Semaphore semaforo;
        List <Macchina> cars;
        string ID;
        public Uscita(string iD)
        {
            this.ID = iD;
        }
        public void Semaforo(List <Macchina> cars, Semaphore semaforo)
        {
            this.semaforo= semaforo;    
            this.cars = cars;   
        }
        public void lascio(Macchina car)
        {
            cars.Remove(car);
            Console.WriteLine($"{car.ToString()}:STO USCENDO");
            cars.Remove(car);
            semaforo.Release();
            Console.WriteLine($"{car.ToString()}:SONO USCITO");
        }
    }
}
