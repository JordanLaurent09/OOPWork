using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskManager
{
    class ReportGenerator:IReportable
    {
        public void GenerateTaskReport(Task task)
        {
            Console.WriteLine($"Отчет о задаче сформирован: \nНомер задачи: {task.TaskId}\nНазвание задачи: {task.Title} \nОписание задачи: {task.Description}\nПриоритет задачи: {task.Priority}\n Дедлайн: {task.Deadline}\nСтатус задачи:{task.Status}\nПользователь, назначенный для задачи: {task.AssignedTo.Username}");
        }

        public void GenerateProjectReport(Project project)
        {
            Console.WriteLine($"Отчет о проекте сформирован: \nНомер проекта: {project.ProjectId}\nНазвание проекта: {project.Title}\nОписание проекта: {project.Description}");
            Console.WriteLine("Проект содержит задачи! Перечислим их названия:");


            foreach (var item in project.Tasks)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}
