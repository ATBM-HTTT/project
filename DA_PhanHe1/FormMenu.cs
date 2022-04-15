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
            getRole();
            
        }

        private void btnUserRefresh_Click(object sender, EventArgs e)
        {
                //DataTable dt = new DataTable();
                //OracleCommand cmd = new OracleCommand("sp_viewuser", conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add(
                //    new OracleParameter
                //    {
                //        ParameterName = "c",
                //        Direction = ParameterDirection.Output,
                //        OracleDbType = OracleDbType.RefCursor
                //    }
                //);
                //cmd.ExecuteNonQuery();
                //OracleDataAdapter da = new OracleDataAdapter(cmd);
                //da.Fill(dt);
                //ListUser.DataSource = dt;
                string connectionstring = OracleConnect.connString("localhost", "1521", "orc21c", Admin_login.username, Admin_login.password);
                var conn = new OracleConnection(connectionstring);
                conn.Open();
                DataTable dt = new DataTable();
                OracleCommand cmd = new OracleCommand("select username, default_tablespace, created, last_login, account_status from dba_users", conn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                ListUser.DataSource = dt;
            
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddUser fm = new FormAddUser();
            fm.Show();
        }
        private void getUsers()
        {
            
             UserGridView.DataSource = this.conn.Query<Users>("sp_viewuser", commandType: CommandType.StoredProcedure).ToList();
            
        }
        private void getRole()
        {
            RoleGridView.DataSource = this.conn.Query<Roles>("sp_viewrole", commandType: CommandType.StoredProcedure).ToList();
        }


        private void btnUserSeach_Click(object sender, EventArgs e)
        {
            string txtUsername = txtUserSearch.Text;
            if (txtUsername == "")
            {
                getUsers();
            }
            else
            {
                UserGridView.DataSource = this.conn.Query<Users>("sp_finduser", new { usr = txtUsername }, commandType: CommandType.StoredProcedure).ToList();
            }
            
        }




        private void btnUserRefresh_Click(object sender, EventArgs e)
        {
            UserGridView.Refresh();
        }

    }
}