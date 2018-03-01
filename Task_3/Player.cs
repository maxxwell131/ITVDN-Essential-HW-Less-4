using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Player : IRecodable, IPlayable
    {
        public void Pause()
        {
            Console.WriteLine("Pause()");
        }

        void IRecodable.Record()
        {
            Console.WriteLine("IRecodable.Record()");
        }

        public void Stop()
        {
            Console.WriteLine("Stop()");
        }

        public void Play()
        {
            Console.WriteLine("Play()");
        }
    }
}
