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
        private Form1 frm2;
        
        SqlConnection cn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=TopLista");
        SqlCommand cmd = new SqlCommand();
        String time = "";
        String level = "";
        DateTime myDateTime = DateTime.Now;
        string sqlFormattedDate = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();//ToString("yyyy-mm-dd HH:mm:ss");
        public GameEnd(String ido, String szint)
        {
            level = szint;
            time = ido;
            cmd.Connection = cn;
            InitializeComponent();
        }


        private void Bevitel_Click(object sender, EventArgs e)
        {
            
            frm2 = new Form1();
            if (nameBox.Text != "")
            {
                cn.Open();
                cmd.CommandText = "INSERT INTO Lista (Name,Time,Date,Level) VALUES ('" + nameBox.Text + "', '" + time + "', '" + sqlFormattedDate + "', '" + level + "' )";
                cmd.ExecuteNonQuery();
                cmd.Clone();
                MessageBox.Show("Record Inserted!");
                nameBox.Text = "";
            }
            
            
        }
    }
}
