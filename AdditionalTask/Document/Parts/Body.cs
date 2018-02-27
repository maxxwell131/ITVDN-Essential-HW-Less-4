﻿using System;
namespace AdditionalTask
{
    public class Body : Part
    {
        public override string Content
        {
            get
            {
                if(content != null)
                {
                    return content;
                }
                else
                {
                    return "Тело документа отсутствует.";
                }
            }

            set
            {
                content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
