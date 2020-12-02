// <copyright file="MainView.xaml.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaskAssistant
{
    using System.Windows;
    using DBTaskAssistant;
    using DBTaskAssistant.ViewModels;

    /// <summary>
    /// Class that adds logic to Main View.
    /// </summary>
    public partial class MainView : Window
    {
        MainVM viewmodel;
        User currentUser = new User();

        public MainView(User loggedUser)
        {
            InitializeComponent();
            currentUser = loggedUser;
            viewmodel = (MainVM)DataContext;
        }

        private void AddButt_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.Effects.BlurEffect objBlur = new System.Windows.Media.Effects.BlurEffect();
            objBlur.Radius = 4;
            this.Effect = objBlur;
            AddTask addTask = new AddTask(currentUser);
            addTask.ShowDialog();

            this.Effect = null;
            viewmodel.UpdateTasks();
        }

        private void DeleteButt_Click(object sender, RoutedEventArgs e)
        {
            viewmodel.Delete();
        }

        private void SortByTime_Click(object sender, RoutedEventArgs e)
        {
            viewmodel.SortByTime();
        }

        private void SortByPriority_Click(object sender, RoutedEventArgs e)
        {

            viewmodel.SortByPriority();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void UserEdit_Click(object sender, RoutedEventArgs e)
        {
            //    //Ed_Account ed_Account = new Ed_Account();
            //    this.Close();
            //    ed_Account.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
