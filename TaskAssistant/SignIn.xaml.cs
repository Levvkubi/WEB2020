// <copyright file="SignIn.xaml.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaskAssistant
{
    using System.Linq;
    using System.Windows;
    using DBTaskAssistant;

    /// <summary>
    /// Class that adds logic to SignIn View.
    /// </summary>
    public partial class SignIn : Window
    {
        TaskAssistantContext taskADB;

        string tagText;

        public SignIn()
        {
            this.InitializeComponent();
            this.tagText = PassBox.Tag.ToString();
        }

        private void PassBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.PassBox.Password == string.Empty)
            {
                PassBox.Tag = tagText;
            }
            else
            {
                PassBox.Tag = string.Empty;
            }
        }

        private void regist_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            this.Close();
            registration.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            taskADB = new TaskAssistantContext();
            MessageBox.Show(taskADB.Tasks.ToList().Count.ToString());

            //var loggedUser = from u in taskADB.Users.ToList()
            //                 where u.Username == usernameBox.Text && DataGenerator.GetSaltHash(PassBox.Password, u.Salt) == u.Password
            //                 select u;

            //if (loggedUser.ToList().Count > 0)
            //{
            //    MainView mainPage = new MainView(loggedUser.First());
            //    mainPage.Show();
            //    this.Close();
            //}
        }
    }
}
