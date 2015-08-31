//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.OleDb;
//using System.Data;
//using System.IO;
//
//namespace ForTesting
//{
//    class VisualFoxProConnection
//    {
//        OleDbConnection connection;
//        OleDbCommand command;
//        private void ConnectTo()
//        {
////            var rootPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString()).ToString();
////            var dbPath = string.Format(@"{0}\db.dbf", rootPath);
//            var dbPath = @"C:\Users\alex__000\Documents\Nestor Julio Proyect\Padron\padron.dbf";
//            connection = new OleDbConnection(string.Format(@"Provider=vfpoledb;Data Source=C:C:\Users\alex__000\Documents\Nestor Julio Proyect\Padron\padron.dbf;Persist Security Info=False", dbPath)); 
//            connection.
//            command = connection.CreateCommand();
//        }
//        public VisualFoxProConnection()
//        {
//            ConnectTo();
//        }
//
//        //select un proyectos
//        public string selectProyecto()
//        {
//            try
//            {
//                string p = "nada";
//                command.CommandText = "SELECT * FROM padron";
//                command.CommandType = CommandType.Text;
//                connection.Open();
//
//                OleDbDataReader reader = command.ExecuteReader();
//
//                if (reader.Read())
//                {
//                    p = reader["NOMBRE"].ToString();
//                }
//                return p;
//
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//            finally
//            {
//                if (connection != null)
//                {
//                    connection.Close();
//                }
//            }
//        }//final un proyectos
//    }
//}
