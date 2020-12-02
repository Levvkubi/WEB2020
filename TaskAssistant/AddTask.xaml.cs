// <copyright file="AddTask.xaml.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaskAssistant
{
    using System;
    using System.Linq;
    using System.Windows;
    using DBTaskAssistant;
    using DBTaskAssistant.ViewModels;

    /// <summary>
    /// Class that adds logic to Add Task View.
    /// </summary>
    public partial class AddTask : Window
    {
        AddVM addVM;
        TaskAssistantContext taskADB;
        User currentUser = new User();

        public AddTask(User loggedUser)
        {
            InitializeComponent();
            taskADB = new TaskAssistantContext();
            currentUser = loggedUser;
            addVM = (AddVM)DataContext;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int index = taskADB.Tasks.Count();
            Random rnd = new Random();

            TaskModel newTask = new TaskModel();
            newTask.Note = Node.Text;
            newTask.Date = new DateTime(addVM.date.Year, addVM.date.Month, addVM.date.Day, addVM.currHour, addVM.currMinute, 1);
            newTask.Priority = Convert.ToInt32(addVM.priority);
            newTask.Id = index++;

            Task task = new Task(newTask.Id, currentUser.Username, newTask.Note, newTask.Date, newTask.Priority);

            currentUser.Tasks.Add(task);
            taskADB.Users.Find(currentUser.Username).Tasks.Add(task);
            taskADB.Tasks.Add(task);
            taskADB.SaveChanges();
            this.Close();
        }
    }
}
