using System;
using System.Collections.Generic;
using System.Text;
using TaskFlow.Domain.Common;
using TaskFlow.Domain.Enum;
using static TaskFlow.Domain.Enum.TaskEnum;

namespace TaskFlow.Domain.Entites
{
    public class TaskItem : BaseEntity
    {
        public string Title { get; private set; } = string.Empty;
        public string? Description { get; private set; }
        public Guid ProjectId { get; private set; }
        public Guid TenatId { get; private set; }
        public Guid? AssigneId { get; private set; }
        public Priority Priority { get; private set; } = Priority.Medium;
        public TaskStatu Status { get; private set; } = TaskStatu.Todo;
        public DateTime? DueDate { get; private set; }
        public string ? AiSummary { get; private set; }
        // constructor 
        private TaskItem()
        {

        }
        // Factory Method
        public static TaskItem Create(
            string title, Guid projectId, Guid tenatId, Priority priority = Priority.Medium, string description = null, Guid? assigneeId = null)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Task title Cannot be empty");
            return new TaskItem
            {
                Title = title,
                ProjectId = projectId,
                TenatId = tenatId,
                Priority = priority,
                Description = description,
                AssigneId = assigneeId,
                Status = TaskStatu.Todo

            };



        }
        // Behaviour Methods
        public void Assign (Guid userId)
        {
            AssigneId = userId;
            MarkAsUpdated();
        }

        public void UpdateStatus(TaskStatu newStatus)
        {
            Status = newStatus;
            MarkAsUpdated();
        }
        public void SetAiSummary(string summary)
        {
            AiSummary = summary;
            MarkAsUpdated();
        }

        public void UpdateDetails(string title, string? description, Priority priority)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be empty");
            Title = title;
            Description = description;
            Priority = priority;
            MarkAsUpdated();
        }
    }
}

