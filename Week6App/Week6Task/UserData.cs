using NidaCloneApp;
using System;
using System.Collections;
using System.Collections.Generic;

namespace WK6SESSAPP
{
    public class UserData
    {
        private int USRID = 0;

        private int UserLimit = 5;

        public int USERID { get { return USRID++; } set { USRID = value ; } }

        private List<User> usersDB = new List<User>();

        private NidaNumberGenerator generator = new NidaNumberGenerator();

        public int ID { get { return USRID ++; } }

        public void SaveUser()
        {
            
            for (int i = USERID; i < UserLimit; i++)
            {
                var user_ = new User();
                user_.Id = USERID;

                #region Task 4
                //Assign necessary data to the user_ object

                Console.WriteLine("User ID:" + user_.Id);

                Console.Write("Enter your Firstname: ");
                Console.ReadKey();

                Console.Write("Enter your Lastname: ");
                Console.ReadKey();

                Console.Write("Enter your Email Address: ");
                Console.ReadKey();

                Console.Write("Enter your Age: ");
                Console.ReadKey();
                #endregion
                usersDB.Add(user_);

                Console.WriteLine("Data Succesfully saved!");

            }

        }

        public void AllUsers()
        {
            foreach (var item in usersDB)
            {
                #region Task 5
                //Include Nida Identity Number for all users
                #endregion
                string user = string.Format("\nUserID = ${0}\n Firstname: ${1}\n Lastname" +
                    ": ${2}\n Email: ${3}\n Age: ${4}\n NidaNo:",
                    item.Id, item.FirstName, item.LastName,
                    item.EmailAddress, item.Age);

                Console.WriteLine(user);
            }
        }


        #region Task 6
        //Write a function to find a user by there id
        #endregion
    }
}