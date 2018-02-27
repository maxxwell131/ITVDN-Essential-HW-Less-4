using System;

namespace AdditionalTask
{
    /*
     * Задание 
    Используя Visual Studio, создайте проект по шаблону Console Application.  
    Требуется: Изменить 12 пример первого урока (работа с документом) и создать
    общий абстрактный класс для всех частей документа.  
    */
    class MainClass
    {
        public static void Main(string[] args)
        {
            Document newDocument = new Document("New Post: Hello World!");
            newDocument.Body = "Text? text ....... text";
            newDocument.Footer = "Footer. Footer .....footer";

            newDocument.Show();
        }
    }
}
