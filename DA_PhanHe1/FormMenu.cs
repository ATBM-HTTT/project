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
using Dapper.Oracle;
using Dapper;

namespace DA_PhanHe1
{
    public partial class FormMenu : Form
    {
        private OracleConnection conn;
        
        public FormMenu(OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            getUsers();
        }

        private void getUsers()
        {
            using (this.conn)
            {
                OracleDynamicParameters dynamicParameters = new OracleDynamicParameters();
                dynamicParameters.Add(name: ":Users", dbType: OracleMappingType.RefCursor, direction: ParameterDirection.Output);
                var users = this.conn.Query<Users>("sp_viewuser", param: dynamicParameters, commandType: CommandType.StoredProcedure).ToList();
                UserGridView.DataSource = users;
            }
        }
        //private void getRole()
        //{
        //    using (this.conn)
        //    {
        //        var users = this.conn.Query<Roles>("dbo.sp_viewrole").ToList();
        //        RoleGridView.DataSource = users;
        //    }
        //}


        //private void btnUserSeach_Click(object sender, EventArgs e)
        //{
        //    string txtUsername = txtUserSearch.Text;
        //    using (this.conn)
        //    {
        //    var users = this.conn.Query<Users>("dbo.sp_finduser @username", new { username = txtUsername }).ToList();
        //    UserGridView.DataSource = users;
        //    }
        //}
        
         
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
