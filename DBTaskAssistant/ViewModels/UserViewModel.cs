// <copyright file="UserViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DBTaskAssistant.ViewModels
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text.RegularExpressions;

    class UserViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<User> users { get; set; }

        TaskAssistantContext taskADB;

        public UserViewModel()
        {
            this.taskADB = new TaskAssistantContext();
            this.users = new ObservableCollection<User>(taskADB.Users.ToList());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }

    public partial class UserModel : INotifyPropertyChanged, IDataErrorInfo
    {
        private string username;
        private string name;
        private string surname;
        private string password;

        public UserModel() { }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Salt { get; set; }

        public string Username
        {
            get
            {
                return this.username;
            }

            set
            {
                this.username = value;
                this.OnPropertyChanged("Username");
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                this.name = value;
                this.OnPropertyChanged("Name");
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                this.surname = value;
                this.OnPropertyChanged("Surname");
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                this.password = value;
                this.OnPropertyChanged("Password");
            }
        }

        public string Error
        {
            get
            {
                return null;
            }
        }

        public Dictionary<string, string> ErrorCollection { get; private set; } = new Dictionary<string, string>();

        public string this[string columnName]
        {
            get
            {
                string result = null;
                switch (columnName)
                {
                    case "Username":
                        if (string.IsNullOrEmpty(this.Username))
                        {
                            result = "Username cannot be empty";
                        }
                        else if (this.Username.Length < 5 || this.Username.Length > 20)
                        {
                            result = "Username must contain 5-20 symbols";
                        }
                        else if (!Regex.IsMatch(this.Username, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                        {
                            result = "Username does not match the template";
                        }

                        break;
                    case "Name":
                        if (string.IsNullOrEmpty(this.Name))
                        {
                            result = "Name cannot be empty";
                        }
                        else if (this.Name.Length < 2 || this.Name.Length > 10)
                        {
                            result = "Name must contain 2-10 symbols";
                        }
                        else if (!Regex.IsMatch(this.Name, @"^[\p{L}\p{M}' \.\-]+$"))
                        {
                            result = "Name does not match the template";
                        }

                        break;
                    case "Surname":
                        if (string.IsNullOrEmpty(this.Surname))
                        {
                            result = "Surname cannot be empty";
                        }
                        else if (this.Surname.Length < 2 || this.Surname.Length > 15)
                        {
                            result = "Surname must contain 2-15 symbols";
                        }
                        else if (!Regex.IsMatch(this.Surname, @"^[\p{L}\p{M}' \.\-]+$"))
                        {
                            result = "Surname does not match the template";
                        }

                        break;
                    case "Password":
                        if (string.IsNullOrEmpty(this.Password))
                        {
                            result = "Password cannot be empty";
                        }
                        else if (this.Password.Length < 6 || this.Password.Length > 25)
                        {
                            result = "Password must contain 6-25 symbols";
                        }

                        break;
                }

                if (this.ErrorCollection.ContainsKey(columnName))
                {
                    this.ErrorCollection[columnName] = result;
                }
                else if (result != null)
                {
                    this.ErrorCollection.Add(columnName, result);
                }

                OnPropertyChanged("ErrorCollection");
                return result;
            }
        }

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
