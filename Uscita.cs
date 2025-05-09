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
        Semaphore semaforo_uscita;
        public Uscita(string iD)
        {
            this.ID = iD;
            semaforo_uscita = new Semaphore(1, 1);
           
        }
        public void Semaforo(List <Macchina> cars, Semaphore semaforo)
        {
            this.semaforo= semaforo;    
            this.cars = cars;   
        }
       
        public void lascio(Macchina car)
        {
            semaforo_uscita.WaitOne();
            cars.Remove(car);
            Console.WriteLine($"{car.ToString()}:STO USCENDO");
            semaforo.Release();
            semaforo_uscita.Release();
            Console.WriteLine($"{car.ToString()}:SONO USCITO");
        }
    }
}
