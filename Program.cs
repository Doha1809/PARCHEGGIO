using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parcheggio
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Park parcheggio= new Park(10,4,4);
            Semaphore semaforo= new Semaphore(parcheggio.NPosti,parcheggio.NPosti);
            List<Macchina> cars = cars = new List<Macchina>();
            for(int i=0;i<parcheggio.NEntrate;i++)
            {
                Entrata enter = new Entrata(i.ToString());
                enter.Semaforo(semaforo, cars);
                parcheggio.enter.Add(enter);

            }
            for (int i = 0; i < parcheggio.NUscite; i++)
            {
                Uscita uscita = new Uscita(i.ToString());
                uscita.Semaforo(cars, semaforo);
                parcheggio.uscite.Add(uscita);  
            }
            Pacchetto pacchetti1 = new Pacchetto();
            Pacchetto pacchetti2 = new Pacchetto();
            Pacchetto pacchetti3 = new Pacchetto();
            Pacchetto pacchetti4 = new Pacchetto();
            Macchina car1 = new Macchina(200, "124", "ferrari");
            pacchetti1.Entrata_e_Uscita(parcheggio.enter[1], parcheggio.uscite[1]);
            car1.thread=new Thread(()=>pacchetti1.parking(car1));
            car1.thread.Start();
            pacchetti2.Entrata_e_Uscita(parcheggio.enter[2], parcheggio.uscite[2]);
            Macchina car2 = new Macchina(200, "125", "ferrari");
            car2.thread = new Thread(() => pacchetti2.parking(car2));
            car2.thread.Start();
            pacchetti3.Entrata_e_Uscita(parcheggio.enter[3], parcheggio.uscite[3]);
            Macchina car3 = new Macchina(200, "126", "ferrari");
            car3.thread = new Thread(() =>pacchetti3.parking(car3));
            car3.thread.Start();

            Macchina car4 = new Macchina(200, "127", "ferrari");
            car4.thread = new Thread(() => pacchetti3.parking(car4));
            car4.thread.Start();

            Console.ReadKey();
        }
     
    }
   
    
}
