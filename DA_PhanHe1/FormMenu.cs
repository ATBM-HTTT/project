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

        //private void btnUserRefresh_Click(object sender, EventArgs e)
        //{
        //        //DataTable dt = new DataTable();
        //        //OracleCommand cmd = new OracleCommand("sp_viewuser", conn);
        //        //cmd.CommandType = CommandType.StoredProcedure;
        //        //cmd.Parameters.Add(
        //        //    new OracleParameter
        //        //    {
        //        //        ParameterName = "c",
        //        //        Direction = ParameterDirection.Output,
        //        //        OracleDbType = OracleDbType.RefCursor
        //        //    }
        //        //);
        //        //cmd.ExecuteNonQuery();
        //        //OracleDataAdapter da = new OracleDataAdapter(cmd);
        //        //da.Fill(dt);
        //        //ListUser.DataSource = dt;
        //        string connectionstring = OracleConnect.connString("localhost", "1521", "orc21c", Admin_login.username, Admin_login.password);
        //        var conn = new OracleConnection(connectionstring);
        //        conn.Open();
        //        DataTable dt = new DataTable();
        //        OracleCommand cmd = new OracleCommand("select username, default_tablespace, created, last_login, account_status from dba_users", conn);
        //        OracleDataAdapter da = new OracleDataAdapter(cmd);
        //        da.Fill(dt);
        //        ListUser.DataSource = dt;
            
        //}

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddUser fm = new FormAddUser(this.conn);
            fm.ShowDialog();
            this.Show();
        }
        private void getUsers()
        {
            try
            {
                UserGridView.DataSource = this.conn.Query<Users>("sp_viewuser", commandType: CommandType.StoredProcedure).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
            }
        }
        private void getRole()
        {
            try
            {
                RoleGridView.DataSource = this.conn.Query<Roles>("sp_viewrole", commandType: CommandType.StoredProcedure).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
            }
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
                try
                {
                    UserGridView.DataSource = this.conn.Query<Users>("sp_finduser", new { usr = txtUsername }, commandType: CommandType.StoredProcedure).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
                }
            }
            
        }




        private void btnUserRefresh_Click(object sender, EventArgs e)
        {
            getUsers();
            txtUserSearch.Text = "";
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            DialogResult rq = MessageBox.Show("Bạn có thực sự muốn xóa user này?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if(rq == DialogResult.Yes)
            {
                string message = "";
                try
                {
                    int index_row = UserGridView.CurrentCell.RowIndex;
                    if (index_row != -1)
                    {
                        OracleCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
                        cmd.ExecuteNonQuery();
                        string username = UserGridView.Rows[index_row].Cells[0].Value.ToString();
                        string del_user = "drop user " + username + " CASCADE";
                        OracleCommand cmd1 = conn.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = del_user;
                        cmd1.ExecuteNonQuery();
                        message = "Xóa thành công!";
                    }
                    else
                    {
                        message = "Bạn chưa chọn user!";
                    }
                }
                catch (Exception ex)
                {
                    message = "Error! \n" + ex.ToString();
                }
                DialogResult rs = MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnUserViewPriv_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormUserPriv fm = new FormUserPriv(this.conn);
            fm.ShowDialog();
            

            this.Show();
        }

        private void btnUserRevoke_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRevoke fm = new FormRevoke();
            fm.ShowDialog();
            this.Show();
        }

        private void btnRoleSearch_Click(object sender, EventArgs e)
        {
            string txtRolename = txtRoleSearch.Text;
            if (txtRolename == "")
            {
                getRole();
            }
            else
            {
                RoleGridView.DataSource = this.conn.Query<Roles>("sp_findrole", new { role_name = txtRolename }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        private void btnRoleRefresh_Click(object sender, EventArgs e)
        {
            getRole();
            txtRoleSearch.Text = "";
        }

        private void btnRoleAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddRole fm = new FormAddRole(this.conn);
            fm.ShowDialog();
            this.Show();
        }

        private void btnRoleDelete_Click(object sender, EventArgs e)
        {
            DialogResult rq = MessageBox.Show("Bạn có thực sự muốn xóa role này?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (rq.Equals(DialogResult.Yes))
            {
                string message = "";
                try
                {
                    int index_row = RoleGridView.CurrentCell.RowIndex;
                    if (index_row != -1)
                    {
                        OracleCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
                        cmd.ExecuteNonQuery();
                        string rolename = RoleGridView.Rows[index_row].Cells[0].Value.ToString();
                        string del_role = "drop role " + rolename;
                        OracleCommand cmd1 = conn.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = del_role;
                        cmd1.ExecuteNonQuery();
                        message = "Xóa thành công!";
                    }
                    else
                    {
                        message = "Bạn chưa chọn role!";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    message = "Error! " + ex.ToString();
                }
                DialogResult rs = MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnViewRolePriv_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRoleViewPriv fm = new FormRoleViewPriv(this.conn);
            fm.ShowDialog();
            this.Show();
        }
    }
}