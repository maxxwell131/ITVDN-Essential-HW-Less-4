using System;
namespace Task_2
{
    public class TXTHandler : AbstractHandler
    {
        public TXTHandler(string filename) : base(filename)
        {
        }

        public override void Save()
        {
            Console.WriteLine("TXTHandler " + filename + " save ");
        }
    }
}
