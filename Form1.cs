using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sql_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            String cs = @"data source= .\MSSQLSERVER01 ; database = july29 ; integrated security = true";
            using (SqlConnection con = new SqlConnection(cs))
            {
                string q = " insert into Accounting values('yared','yitagesu','2007-07-02',3000.00) ";
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(q,con);
                var result = sqlCommand.ExecuteNonQuery();  
                var read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    string name = read[1].ToString();
                    MessageBox.Show(name);
                }    
            }
        }
    }
}
