using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutobaseProject
{
    class Dispatcher
    {
        // Отстранение водителя от работы
        public void DriverDismissal(Driver driver)
        {
            driver.isReady = false;
        }

        // Дает водителю заявку на рейс и назначает автомобиль 

        public Driver AppointRun()
        {
            return new Driver(new Run(new Automobile()));
        }

        // Отправляет автомобиль на ремонт по заявке водителя

        public void RepairAuto(Automobile auto)
        {
            if (auto.RepairRequest == "Ремонт")
            {
                auto.RepairRequest = "Автомобиль отремонтирован";
                auto.Condition = "Отличное состояние";
            }
        }
    }
}
