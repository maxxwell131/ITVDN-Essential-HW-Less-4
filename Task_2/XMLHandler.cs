using System;
namespace Task_2
{
    public class XMLHandler : AbstractHandler
    {
        public XMLHandler(string filename) : base(filename)
        {
        }

        public override void Save()
        {
            Console.WriteLine("XMLHandler " + filename + " save ");        }
        }
}
