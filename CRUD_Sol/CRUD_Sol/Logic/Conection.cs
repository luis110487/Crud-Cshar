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
            DataBase = "";
        }

    }
}
