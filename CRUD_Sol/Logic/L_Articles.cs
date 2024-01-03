using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data;

namespace CRUD_Sol.Logic
{
    internal class L_Articles
    {
        public DataTable ListArticles(string cText)
        {
            SQLiteDataReader Result;
            DataTable Table = new DataTable();
            SQLiteConnection sQLiteCon = new SQLiteConnection();

            try
            {
                sQLiteCon = Conection.GetConection().CreateConection();
                cText = "%" + cText.Trim() + "%";
                string Sql_Task = "SELECT  a.codigo_ar, a.descripcion_ar, a.marca_ar, b.descipcion_me, c.descipcion_ca, a.codigo_me, a.codigo_ca " +
                                    "FROM tb_articulos a " +
                                    "INNER JOIN tb_medidas b ON a.codigo_me = b.codigo_me " +
                                    "INNER JOIN tb_categorias c ON a.codigo_ca = c.codigo_ca " +
                                    "WHERE a.descripcion_ar LIKE '" + cText + "'";
                SQLiteCommand coman = new SQLiteCommand(Sql_Task, sQLiteCon);
                sQLiteCon.Open();
                Result = coman.ExecuteReader();
                Table.Load(Result);
                return Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sQLiteCon.State == ConnectionState.Open) sQLiteCon.Close();
            }
        }
    }
}