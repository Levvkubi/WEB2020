// <copyright file="DataGenerator.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DBTaskAssistant
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;

    /// <summary>
    /// Class that generates random data.
    /// </summary>
    public class DataGenerator
    {
        private static int minLogLen = 3;
        private static int maxLogLen = 12;
        private static int minPassLen = 8;
        private static int maxPassLen = 30;
        private static int minNamesLen = 3;
        private static int maxNamesLen = 12;
        private static int minNoteLen = 0;
        private static int maxNoteLen = 100;
        private static int maxPrior = 10;
        private static int saltLen = 6;

        public DataGenerator() { }

        public static string GetRandStr(int minLen, int maxLen, bool useDigit = false)
        {
            string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (useDigit)
            {
                valid += "1234567890";
            }

            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            int length = rnd.Next(minLen, maxLen + 1);
            for (int i = 0; i < length; i++)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }

            return res.ToString();
        }

        private static bool Contain(List<User> users, string login)
        {
            foreach (var item in users)
            {
                if (item.Username == login)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool Contain(List<Task> tasks, int id)
        {
            foreach (var item in tasks)
            {
                if (item.Id == id)
                {
                    return true;
                }
            }

            return false;
        }

        public static string GetSaltHash(string pass, string salt)
        {
            string toHash = pass + salt;
            HashAlgorithm hesher = new SHA256Managed();
            byte[] toHasgBytes = Encoding.UTF8.GetBytes(toHash);
            byte[] hash = hesher.ComputeHash(toHasgBytes);
            return Convert.ToBase64String(hash);
        }

        public static void GenerateData(TaskAssistantContext context, int usersCount = 30, int tasksCount = 50)
        {
            string login, name, surname, pass, salt, heshpass;
            for (int i = 0; i < usersCount; i++)
            {
                do
                {
                    login = GetRandStr(minLogLen, maxLogLen, true);
                } while (Contain(context.Users.ToList(), login));
                name = GetRandStr(minNamesLen, maxNamesLen, false);
                surname = GetRandStr(minNamesLen, maxNamesLen, false);
                pass = GetRandStr(minPassLen, maxPassLen, true);
                salt = GetRandStr(saltLen, saltLen, true);
                heshpass = GetSaltHash(pass, salt);
                User user = new User(login, name, surname, heshpass, salt);
                context.Users.Add(user);
            }

            context.SaveChanges();

            Random rnd = new Random();

            int startId = 1;
            if (context.Tasks.Count() > 0)
            {
                startId = context.Tasks.ToList()[context.Tasks.ToList().Count - 1].Id + 1;
            }

            int id, prior;
            string usname, note;
            List<User> users = context.Users.ToList();
            if (users.Count > 0)
            {
                for (int i = 0; i < tasksCount; i++)
                {
                    DateTime time = DateTime.Now;
                    time.AddDays(rnd.Next(10));
                    time.AddHours(rnd.Next(24));
                    id = startId + i;
                    while (Contain(context.Tasks.ToList(), id))
                    {
                        id = rnd.Next(context.Tasks.Count() * 2);
                    }

                    usname = users[rnd.Next(users.Count)].Username;
                    note = GetRandStr(minNoteLen, maxNoteLen, true);
                    prior = rnd.Next(maxPrior);
                    Task task = new Task(id, usname, note, time, prior);
                    context.Tasks.Add(task);
                }
            }

            context.SaveChanges();
        }
    }
}
