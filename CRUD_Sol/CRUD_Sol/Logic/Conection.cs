using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace CRUD_Sol.Logic
{
    public class Conection
    {
        private string DataBase;
        private static Conection Con = null;


        private Conection()
        {
            DataBase = "./Db_Crud.db";
        }


        public SQLiteConnection CreateConection() 
        {
            SQLiteConnection Chain= new SQLiteConnection();

            try
            {
                Chain.ConnectionString = "Data Source=" + this.DataBase;
            }
            catch (Exception ex)
            {
                Chain = null;
                throw ex;
            }

            return Chain;   
        }

        public static Conection GetConection()
        {
            if (Con == null)
            {
                Con = new Conection();
            }
            return Con;
        }
    }
}
