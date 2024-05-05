using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RSVP
{
    public class DAL
    {
        private string _dbPath = Path.Combine(
            System.Environment.GetFolderPath(Environment.SpecialFolder
                .Personal), "UserDb.db");

        public DAL()
        {
            if (!File.Exists(_dbPath))
            {
                SQLiteDb db = new SQLiteDb(_dbPath);
                db.CreateUser();
            }
        }

        public void AddUser(User usertoAdd)
        {
            using (SQLiteConnection db = new SQLiteConnection(_dbPath))
            {
                bool exists = false;

                foreach (User u in db.Table<User>())
                {
                    if (u.Id == usertoAdd.Id
                        && u.Email == usertoAdd.Email
                        && u.Password == usertoAdd.Password
                        && u.PhoneNumber == usertoAdd.PhoneNumber)
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    db.Insert(usertoAdd);
                }
            }
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (SQLiteConnection db = new SQLiteConnection(_dbPath))
            {
                users = db.Table<User>().ToList();
            }

            return users;
        }
    }
}
