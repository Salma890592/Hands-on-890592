using System;

namespace SingletonHands1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.What will happen if you don’t make the constructor as private?

            //DBConn obj1 = new DBConn();
            //DBConn obj2 = new DBConn();

            //if (obj1.Equals(obj2))
            //    Console.WriteLine("The objects are same");
            //else
            //    Console.WriteLine("The objects are different");

            // hence we can create multiple objects if constructor is public






            //2.What happens to the class if static keywords are attached to a member.?

            //DBConn obj1 = DBConn.conn;
            //Console.WriteLine(obj1);



            //3.Will you be able to instantiate the object without ‘new’ operator? yes.

            DBConn obj3 = DBConn.getInstance();
            DBConn obj4 = DBConn.getInstance();
            //  DBConn obj4 = new DBConn();


            if (obj3.Equals(obj4))
                Console.WriteLine("The objects are same");




            Console.ReadKey();
        }
    }

}
