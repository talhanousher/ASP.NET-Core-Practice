﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public TaskItem(int id, string title, string description, bool isCompleted)
        {
            Id = id;
            Title = title;
            Description = description;
            IsCompleted = isCompleted;
        }

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }
        public override string ToString()
        {
            return $"Task ID: {Id}, Title: {Title}, Description: {Description}, Completed: {IsCompleted}";
        }

    }
}
