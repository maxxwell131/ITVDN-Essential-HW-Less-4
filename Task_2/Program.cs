using System;
using System.Collections.Generic;

namespace Task_2
{
    /*Задание 2 
    Используя Visual Studio, создайте проект по шаблону Console Application.  
    Требуется:  
    Создайте класс AbstractHandler. 
    В теле класса создать методы void Open(), void Create(), void Chenge(),
    void Save(). 
    Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового 
    класса AbstractHandler. 
    Написать программу, которая будет выполнять определение документа и для 
    каждого формата должны быть методы открытия, создания, редактирования,
    сохранения определенного формата документа.  
    */
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<AbstractHandler> abstractHandlerList = new List<AbstractHandler>();

            abstractHandlerList.Add(new XMLHandler("*.xml"));
            abstractHandlerList.Add(new TXTHandler("*.txt"));
            abstractHandlerList.Add(new DOCHandler("*.doc"));

            foreach (AbstractHandler obj in abstractHandlerList)
            {
                obj.Open();
                obj.Create();
                obj.Change();
                obj.Save();
            }
        }
    }
}
