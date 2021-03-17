using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonHands1
{
    public class DBConn
    {
        private static DBConn instance;

        public static DBConn conn = new DBConn();

        private DBConn() { }  //it will avoid creation of object with new keyword.. there clas will hold onlyone instance of its own 
        //public DBConn() { }
        public static DBConn getInstance()
        {
            if (instance == null)
                instance = conn;

            return instance;
        }
    }
}
