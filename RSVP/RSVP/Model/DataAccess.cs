using SQLite;
using System;

namespace RSVP
{
    public class SQLiteDb
    {
        string _path;
        public SQLiteDb(string path)
        {
            _path = path;
        }

        public void CreateUser()
        {
            using (SQLiteConnection db = new SQLiteConnection(_path))
            {
                db.CreateTable<User>();
            }
        }

        public void CreateEvent()
        {
            using (SQLiteConnection db = new SQLiteConnection(_path))
            {
                db.CreateTable<Event>();
            }
        }

    }

    public partial class User
    {
        [PrimaryKey, AutoIncrement]
        public Int64 Id { get; set; }

        [NotNull]
        public String Name { get; set; }

        [NotNull]
        public String Email { get; set; }

        [NotNull]
        public String Password { get; set; }

        [NotNull]
        public String PhoneNumber { get; set; }

    }

    public partial class Event
    {
        [PrimaryKey, AutoIncrement]
        public Int64 Id { get; set; }

        [NotNull]
        public String EventHostName { get; set; }

        [NotNull]
        public String EventName { get; set; }

        [NotNull]
        public String EventAddress { get; set; }

        [NotNull]
        public String EventMaxPeople { get; set; }

        [NotNull]
        public DateTime EventDateTime { get; set; }

        [NotNull]
        public DateTime EventDeadLine { get; set; }
    }

}