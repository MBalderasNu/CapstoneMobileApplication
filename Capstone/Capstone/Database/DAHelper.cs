using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Capstone.DatabaseModels;
using Capstone.TeamProfilePageData;
using Microsoft.WindowsAzure.MobileServices;
using SQLite;

namespace Capstone.Database
{
    public class DAHelper
    {
        static object locker = new object();
        public static SQLiteConnection database;
        

        public DAHelper()
        {
           

            database = GetConnection();
            // create the tables  
            database.CreateTable<DCUsers>();
            //database.CreateTable<PlayerDataModel>();

          


        }

        public static SQLite.SQLiteConnection GetConnection()
        {
            SQLiteConnection sqlitConnection;
            var sqliteFilename = "DraftingDataAccounts.db3";
#if __ANDROID__

             string folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var databasePath = Path.Combine(folder, sqliteFilename);
#else
#if __IOS__
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var databasePath = Path.Combine(folder, "..", sqliteFilename);
#endif
#endif
            sqlitConnection = new SQLite.SQLiteConnection(databasePath);

            return sqlitConnection;
        }



        public IEnumerable<DCUsers> GetAllUsers()
        {
            lock (locker)
            {
                return (from i in database.Table<DCUsers>() select i).ToList();
            }
        }

        public DCUsers GetALLUSERINFO(string username, string playerOne, string playerTwo, string playerThree, string playerFour, string playerFive, string playerSix, string playerSeven, string favteam)
        {
            lock (locker)
            {
                return database.Table<DCUsers>().FirstOrDefault(x => x.Username == username && x.PlayerOne == playerOne && x.PlayerTwo == x.PlayerTwo && x.PlayerThree == playerThree && x.PlayerFour == playerFour && x.PlayerFive == playerFive && x.PlayerSix == playerSix && x.PlayerSeven == playerSeven && x.FavTeam == favteam);
            }
        }


        public DCUsers GetUserName(string userName)
        {
            lock (locker)
            {
                return database.Table<DCUsers>().FirstOrDefault(x => x.Username == userName);
            }
        }
        public DCUsers GetUsernamenPassword(string userName, string passWord)
        {
            lock (locker)
            {
                return database.Table<DCUsers>().FirstOrDefault(x => x.Username == userName && x.Password == passWord);
            }
        }
        public int SaveUser(DCUsers user)
        {
            lock (locker)
            {
                if (user.UserId != 0)
                {
                    //Update Item  
                    database.Update(user);
                    return user.UserId;
                }
                else
                {
                    //Insert item  
                    return database.Insert(user);
                }
            }
        }

        public int DeleteItem(int id)
        {
            lock (locker)
            {
                return database.Delete<DCUsers>(id);
            }
        }
    }
}
