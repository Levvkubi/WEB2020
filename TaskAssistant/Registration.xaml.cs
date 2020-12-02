// <copyright file="Registration.xaml.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaskAssistant
{
    using System.Windows;
    using DBTaskAssistant;
    using DBTaskAssistant.ViewModels;

    /// <summary>
    /// Class that adds logic to Registration View.
    /// </summary>
    public partial class Registration : Window
    {
        TaskAssistantContext taskADB;

        string passtagText;
        string conftagText;

        public Registration()
        {
            this.InitializeComponent();
            passtagText = PassBox.Tag.ToString();
            conftagText = ConfPassBox.Tag.ToString();
        }

        private void PassBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PassBox.Password == string.Empty)
            {
                PassBox.Tag = passtagText;
            }
            else
            {
                PassBox.Tag = string.Empty;
            }
        }

        private void ConfPassBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (ConfPassBox.Password == string.Empty)
            {
                ConfPassBox.Tag = conftagText;
            }
            else
            {
                ConfPassBox.Tag = string.Empty;
            }
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            SignIn signIn = new SignIn();
            this.Close();
            signIn.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.taskADB = new TaskAssistantContext();
            var salt = DataGenerator.GetRandStr(6, 6, true);
            var userModel = new UserModel()
            {
                Name = firstNameBox.Text,
                Surname = secondNameBox.Text,
                Username = UsernameBox.Text,
                Salt = salt,
                Password = DataGenerator.GetSaltHash(PassBox.Password, salt),
            };

            var user = new User(userModel.Username, userModel.Name, userModel.Surname, userModel.Password, userModel.Salt);
            this.taskADB.Users.Add(user);
            this.taskADB.SaveChanges();

            SignIn signInPage = new SignIn();
            signInPage.Show();
            this.Close();
        }
    }
}
