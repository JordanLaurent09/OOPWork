using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutobaseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Driver> driversOnDuty = new List<Driver>();

            Dispatcher dispatcher = new Dispatcher();

            // Диспетчер распределяет рейсы между водителями

            // Первый водитель
            Driver one = dispatcher.AppointRun();

            // Километраж первого рейса 2000 км
            one.Run.Mileage = 2000;

            // Проверка состояния автомобиля до рейса
            Console.WriteLine(one.Run.Auto.Condition);

            // Проверка состояния автомобиля после рейса
            one.MakeConditionGrade(one.Run.Mileage);

            Console.WriteLine(one.Run.Auto.Condition);

            // Водитель помечает, что рейс выполнен
            one.MakeFulFillmentGrade(true);

            driversOnDuty.Add(one);

            // Второй водитель
            Driver two = dispatcher.AppointRun();

            // Километраж второго рейса 200 км
            two.Run.Mileage = 200;

            // Проверка состояния автомобиля до рейса
            Console.WriteLine(two.Run.Auto.Condition);

            // Проверка состояния автомобиля после рейса
            two.MakeConditionGrade(two.Run.Mileage);

            Console.WriteLine(two.Run.Auto.Condition);

            // Водитель помечает, что рейс выполнен
            two.MakeFulFillmentGrade(true);

            driversOnDuty.Add(two);

            // Третий водитель
            Driver three = dispatcher.AppointRun();

            // Километраж третьего рейса 3000 км
            three.Run.Mileage = 3000;

            // Проверка состояния автомобиля до рейса
            Console.WriteLine(three.Run.Auto.Condition);

            // Проверка состояния автомобиля после рейса
            three.MakeConditionGrade(three.Run.Mileage);

            Console.WriteLine(three.Run.Auto.Condition);

            // Водитель помечает, что рейс выполнен
            three.MakeFulFillmentGrade(true);

            driversOnDuty.Add(three);

            // Диспетчер может отстранить водителя
            dispatcher.DriverDismissal(driversOnDuty[0]);

            driversOnDuty[0].MakeConditionGrade(100);
            driversOnDuty[0].MakeFulFillmentGrade(true);
            driversOnDuty[0].RepairRequest();

            // Водитель дает заявку на ремонт

            Console.WriteLine(driversOnDuty[2].Run.Auto.Condition);

            driversOnDuty[2].RepairRequest();

            Console.WriteLine(driversOnDuty[2].Run.Auto.RepairRequest);

            // Диспетчер отправляет автомобиль на ремонт
            dispatcher.RepairAuto(driversOnDuty[2].Run.Auto);

            // Как итог - автомобиль полностью отремонтирован
            Console.WriteLine(driversOnDuty[2].Run.Auto.Condition);

            Console.WriteLine(driversOnDuty[2].Run.Auto.RepairRequest);
        }
    }
}
