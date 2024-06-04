using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_TiecCuoi.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }

            set
            {
                instance = value;
            }
        }
        public DataProvider() { }
        private string connectionSTR = @"Data Source=MSI\NHAN18;Initial Catalog=QLTC;Integrated Security=True";// chuoi xac dinh ket noi voi database nao

        public DataTable ExecuteQuery(string query)
        {
            Console.WriteLine("Query: "+query);
            DataTable data = new DataTable();
            try
            {
              
                using (SqlConnection connection = new SqlConnection(connectionSTR)) // ket noi layer xuong server
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);//cau truy van thuc thi
                    SqlDataAdapter adapter = new SqlDataAdapter(command);//trung gian lay du lieu
                    adapter.Fill(data);
                    connection.Close();

                }
                return data;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error query :" + e);
               
            }

            return data;

        }

        // them
        // xoa
        public bool ExecuteDelete(string query)
        {

            
            using (SqlConnection connection = new SqlConnection(connectionSTR)) // ket noi layer xuong server
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);//cau truy van thuc thi
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                //command.ExecuteReader();

                connection.Close();
            }
            return true;
        }
        // sua 
        public bool ExecuteUpdate(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR)) // ket noi layer xuong server
            {
                connection.Open();
                Console.WriteLine("Query Update: " + query);
                SqlCommand command = new SqlCommand(query, connection);//cau truy van thuc thi
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet set = new DataSet();
                
              
                command.ExecuteNonQuery();
                //command.ExecuteReader();
                Console.Write("test");

                connection.Close();
            }
            return true;
        }
        // tim kiem






    }
}


