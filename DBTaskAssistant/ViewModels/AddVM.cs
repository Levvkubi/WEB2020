// <copyright file="AddVM.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DBTaskAssistant
{
    using System;
    using System.Collections.ObjectModel;
    using DevExpress.Mvvm;

    public class AddVM : ViewModelBase
    {
        public Task task;

        public ObservableCollection<int> hours { get; set; }

        public ObservableCollection<int> priorities { get; set; }

        public ObservableCollection<int> minutes { get; set; }

        public int currHour { get; set; }

        public int currMinute { get; set; }

        public DateTime date { get; set; }

        public string Node { get; set; }

        public int priority { get; set; }

        public AddVM()
        {
            this.hours = new ObservableCollection<int>();
            this.minutes = new ObservableCollection<int>();
            this.priorities = new ObservableCollection<int>();
            for (int i = 1; i < 4; i++)
            {
                this.priorities.Add(i);
            }

            for (int i = 1; i < 25; i++)
            {
                this.hours.Add(i);
            }

            for (int j = 0; j < 60; j++)
            {
                this.minutes.Add(j);
            }

            this.currHour = DateTime.Now.Hour;
            this.currMinute = DateTime.Now.Minute;
            this.date = DateTime.Now;
            this.priority = 3;
        }

        public void Zapovn(ObservableCollection<Task> tasks, Task currtask, bool change)
        {
            if (!change)
            {
                this.currHour = DateTime.Now.Hour;
                this.currMinute = DateTime.Now.Minute;
                this.date = DateTime.Now;
                this.priority = 3;
            }
            else
            {
                this.currHour = currtask.Date.Hour;
                this.currMinute = currtask.Date.Minute;
                this.Node = currtask.Note;
                this.priority = currtask.Priority;
            }
        }
    }
}
