using System;
namespace Task_2
{
    abstract public class AbstractHandler
    {
        protected string filename;

        public void Open()
        {
            Console.WriteLine("Document " + filename + " open");
        }

        public void Create()
        {
            Console.WriteLine("Document " + filename + " create");
        }

        public void Change()
        {
            
            Console.WriteLine("Document " + filename + " change");

        }

        abstract public void Save();

        public AbstractHandler(string filename)
        {
            this.filename = filename;
        }
    }
}
