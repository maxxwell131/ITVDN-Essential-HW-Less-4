using System;
namespace Task_2
{
    public class DOCHandler : AbstractHandler
    {
        public DOCHandler(string filename) : base(filename)
        {
        }

        public override void Save()
        {
            Console.WriteLine("DOCHandler " + filename + " save ");
        }
    }
}
