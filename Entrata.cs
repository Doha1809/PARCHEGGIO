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
        object lockPosti = new object();
        public Entrata(string id)
        {
            this.id = id;

        }
        public void Semaforo(Semaphore sema, List<Macchina> cars, object lockposti)
        {
            semaforo = sema;
            this.cars = cars;
            this.lockPosti = lockposti;
        }
        Semaphore semaforo_entrata = new Semaphore(1, 1);
        public void Entrare( Macchina car)
        {
            Console.WriteLine($"{car.ToString()}VOGLIO ENTRARE");
            semaforo_entrata.WaitOne();
            Console.WriteLine($"{car.ToString()}SONO ENTRATA OLEEE");

        }

       public void Parcheggiare(Macchina car)
        {

            Console.WriteLine($"{car.ToString()}:VOGLIO PARCHEGGIARE. SONO ALL'ENTRATA DI ID {id}");
            semaforo.WaitOne();
            semaforo_entrata.Release();
            lock (lockPosti)
            {
                Entrato(car);
                Console.WriteLine($"{car.ToString()}:HO PARCHEGGIO DALL'ENTRATA {id}");
            }
                Thread.Sleep(car.Tempo_Sosta);
           
        }
        private void Entrato(Macchina car)
        {

            cars.Add(car);
        }
    }
}
