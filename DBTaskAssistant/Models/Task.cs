// <copyright file="Task.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DBTaskAssistant
{
    using System;

    /// <summary>
    /// Class Task that describes the Model.
    /// </summary>
    public partial class Task
    {
        public Task() { }

        public Task(int id, string usname, string note, DateTime date, int priority)
        {
            this.Id = id;
            this.Username = usname;
            this.Note = note;
            this.Date = date;
            this.Priority = priority;
        }

        /// <summary>
        /// Gets or sets unique task Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets username which is binded to the task.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets task note.
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Gets or sets task date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets task priority.
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// Gets or sets auto generated value after connection to DB.
        /// </summary>
        public virtual User UsernameNavigation { get; set; }
    }
}
