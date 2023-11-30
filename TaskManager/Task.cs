using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskManager
{
    class Task:TaskBase
    {
        public override int TaskId { get; set; }
        public override string Title { get; set; }
        public override string Description { get; set; }
        public override Status Status { get; set; }
        public override Priority Priority { get; set; }
        public override DateTime Deadline { get; set; }
        public override User AssignedTo { get; set; }


        public Task(int taskId, string title, string description, Status status, Priority priority, DateTime deadline)
        {
            TaskId = taskId;
            Title = title;
            Description = description;
            Status = status;
            Priority = priority;
            Deadline = deadline;
        }




        // Назначаем задаче пользователя
        public override void Assign(User user)
        {
            AssignedTo = user;
        }

        // Изменяем статус задачи
        public override void ChangeStatus(Status status)
        {
            Status = status;
        }
    }
}
