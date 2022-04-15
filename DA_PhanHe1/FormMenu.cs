using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_PhanHe1
{
    public partial class FormMenu : Form
    {
        private OracleConnection conn;
        
        public FormMenu(OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void user_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                //MessageBox.Show("Connected");
                this.Hide();
                FormUserList fm = new FormUserList(conn);
                fm.Show();
            }
            else
            {
                MessageBox.Show("Connected failed");
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
