// <copyright file="User.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DBTaskAssistant
{
    using System.Collections.Generic;

    public partial class User
    {
        public User()
        {
            this.Tasks = new HashSet<Task>();
        }

        public User(string log, string name, string surname, string password, string salt)
        {
            this.Username = log;
            this.Name = name;
            this.Surname = surname;
            this.Password = password;
            this.Salt = salt;
        }

        public string Username { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
