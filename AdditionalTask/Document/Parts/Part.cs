using System;
namespace AdditionalTask
{
    abstract public class Part
    {
        protected string content;
        abstract public string Content { get; set; }

        abstract public void Show();       
    }
}
