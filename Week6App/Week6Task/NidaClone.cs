using System;

namespace WK6SESSAPP
{
    class NidaClone
    {

        private UserData database = new UserData();

        static void Main(string[] args)
        {
            Console.WriteLine("NIDA-NAMBA REGISTRATION SYSTEM");

            #region Task 7
            //Run the Application
            #endregion


        }

        private void Run()
        {
            Console.WriteLine("App is Running...");

            database.SaveUser();

            Console.ReadKey();

            #region Task 0
            //Display all Users

            #endregion


            #region Task 1
            //Single User by id
            Console.Write("Find user by id: ");
            var userid = Convert.ToInt32(Console.ReadLine());


            #endregion




            Console.WriteLine("App is Closing...");

            Console.ReadKey();
        }
    }
}
