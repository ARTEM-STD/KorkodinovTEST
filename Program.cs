using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspectorLib;

namespace PRCR
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionInsp inspector = new FunctionInsp();


            // Метод GetCarInspection
            // Здесь мы выводим как называется автоинспекция
            Console.WriteLine($"Название автоинспекции: {inspector.GetCarInspection()}");



            // Метод GetInspector
            // Выводи кто сейчас является главным инспектором
            Console.WriteLine($"Главный инспектор: {inspector.GetInspector()}");

            

            // Метод SetInspector
            // Для начало мы опять узнаём кто явдяется главным инспектором
            Console.WriteLine($"Смена главного инспектора на смене: {inspector.GetInspector()}");
            if (inspector.SetInspector())//Здесь в методе рандомно выбирается имя из сушествующего списка сотрудников
            {
                Console.WriteLine($"Главный инспектор изменен на: {inspector.GetInspector()}");
                // Выводим как зовут нового инспектора
            }
            
            


            // Метод GenerateNumber
            // Генерируем рандомный госномер
            Console.WriteLine($"Сгенерированный госномер: {inspector.GenerateNumber()}");
           

            // Метод GetWorker
            // Выводим весь список сотрудников
            Console.WriteLine("Список сотрудников:");
            // Обрашаемся к методу содержашие ФИО сотрудников
            foreach (string FIOST in inspector.GetWorker())
            {
                Console.WriteLine($"{FIOST}");
                // ВЫводи список
            }


            // Метод AddWorker
            // Добавляем сотрудника в сушествующтй список
            Console.WriteLine($"Добавление сотрудника Сидоров С.С.: {inspector.AddWorker("Сидоров С.С.")}");
            // Выводи список сотрудников чтобы увидеть изменения
            Console.WriteLine("Список сотрудников после добавления:");
            foreach (string FIOST in inspector.GetWorker())
            {
                Console.WriteLine($"{FIOST}");
            }

            Console.ReadLine();
        }
    }
}
