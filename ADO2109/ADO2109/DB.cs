using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace ADO2109
{
    public class DB
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\УНІВЄР\ШАГ\C#\SharpADO2109\ADO2109\ADO2109\Groups.mdf;Integrated Security=True");

        public void InsertGroup(string name)
        {
            connection.Open();
            string insertString = "insert into Gruppa(Name) Values(@name)";
            SqlCommand command = new SqlCommand(insertString, connection);
            SqlParameter param = new SqlParameter("@name", name);
            command.Parameters.Add(param);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable GetTable(string tableName)
        {
            connection.Open();
            string selectionString = "select * from " + tableName;
            SqlCommand command = new SqlCommand(selectionString, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

    }
}
