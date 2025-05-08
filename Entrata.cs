using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parcheggio
{
    internal class Entrata
    {
        public string id;
        public Semaphore semaforo;
        List<Macchina> cars;
        public Entrata(string id)
        {
            this.id = id;
        }
        public void Semaforo(Semaphore sema, List<Macchina> cars)
        {
            semaforo = sema;
            this.cars = cars;
        }
        public void Parcheggiare(Macchina car)
        {

            Console.WriteLine($"{car.ToString()}:VOGLIO PARCHEGGIARE. SONO ALL'ENTRATA DI ID {id}");
            semaforo.WaitOne();
            Entrato(car);
            Console.WriteLine($"{car.ToString()}:SONO ENTRATO DALL'ENTRATA {id}");
            Thread.Sleep(car.Tempo_Sosta);
           
        }
        private void Entrato(Macchina car)
        {

            cars.Add(car);
        }
    }
}
