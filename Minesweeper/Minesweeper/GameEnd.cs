using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Timers;
namespace Minesweeper
{
    public partial class GameEnd : Form
    {
        public GameEnd()
        {
            InitializeComponent();
            
            
            //command.Parameters.Add("@Time", );
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = @"Server=(localdb)\MSSQLLocalDB;Database=TopLista";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            string sql = "INSERT INTO lista (Name) VALUES (@Name)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Name", text_Name_Box.Text);
            
        }

    }
}
