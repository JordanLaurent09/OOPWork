using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutobaseProject
{
    class Driver
    {
        public bool isReady { get; set; }
        public Run Run { get; set; }

        public Driver(Run run)
        {
            Run = run;
            isReady = true;
        }

        // Водитель ставит отметку о состоянии автомобиля
        public void MakeConditionGrade(double mileage)
        {
            if (isReady)
            {
                if (mileage >= 0 && mileage <= 1000)
                {
                    Run.Auto.Condition = "Отличное состояние";
                }
                else if (mileage >= 1001 && mileage <= 2500)
                {
                    Run.Auto.Condition = "Удовлетворительное состояние";
                }
                else if (mileage > 2501)
                {
                    Run.Auto.Condition = "Нуждается в ремонте";
                }
            }
            else
            {
                Console.WriteLine("Водитель отстранен! Он не может поставить отметку о состоянии автомобиля!");
            }
        }

        public void MakeFulFillmentGrade(bool isFinished)
        {
            if (isReady)
            {
                if (isFinished == true)
                {
                    Run.IsCompleted = true;
                }
            }
            else
            {
                Console.WriteLine("Водитель отстранен! Он не может поставить отметку о выполнении рейса!");
            }
        }

        public void RepairRequest()
        {
            if (isReady)
            {
                Run.Auto.RepairRequest = "Ремонт";
            }
            else Console.WriteLine("Водитель отстранен! Он не может написать заявку на ремонт!");
        }
    }
}
