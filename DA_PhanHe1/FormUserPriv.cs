using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Dapper;
namespace DA_PhanHe1
{
    public partial class FormUserPriv : Form
    {
        private OracleConnection conn;


        public FormUserPriv(OracleConnection conn, string username)
        {
            this.conn = conn;
            InitializeComponent();
            Username = username;
            getPriv();
        }

        public string Username { get; }

        private void getPriv()
        {
            DataTable dt = new DataTable();
            string priv_user = "select grantee, grantor, privilege, table_name, grantable from dba_tab_privs where grantor = upper('" + Username + "')";
            OracleCommand cmd = new OracleCommand(priv_user, this.conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            UserPrivGridView.DataSource = dt;
        }
        private void btnUserPrivEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUserPrivRevoke_Click(object sender, EventArgs e)
        {
            DialogResult rq = MessageBox.Show("Bạn có thực sự muốn xóa quyền này?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (rq.Equals(DialogResult.Yes))
            {
                string message = "";
                try
                {
                    int index_row = UserPrivGridView.CurrentCell.RowIndex;
                    if (index_row != -1)
                    {
                        OracleCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
                        cmd.ExecuteNonQuery();
                        string priv_name = UserPrivGridView.Rows[index_row].Cells[2].Value.ToString();
                        string table_name = UserPrivGridView.Rows[index_row].Cells[3].Value.ToString();

                        //this.conn.Execute("sp_revokepriv_tab", new { grantee = Username, privilege = priv_name, table_name = table_name }, commandType: CommandType.StoredProcedure);
                        string del_priv = "revoke \'" + priv_name + "\' on \'" + table_name + "\' from \'" + Username + "\'";
                        OracleCommand cmd1 = conn.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = del_priv;
                        cmd1.ExecuteNonQuery();
                        message = "Xóa thành công!";
                    }
                    else
                    {
                        message = "Bạn chưa chọn quyền!";
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

        private void btnUserPrivSeach_Click(object sender, EventArgs e)
        {
            //string connectionstring = OracleConnect.connString("localhost", "1521", "orc21c", Admin_login.username, Admin_login.password);
            //var conn = new OracleConnection(connectionstring);
            //conn.Open();
            string priv = txtUserPriv.Text;
            DataTable dt = new DataTable();
            string priv_user = "select grantee, grantor, privilege, table_name, grantable from dba_tab_privs where grantor = upper('" + Username + "') and privilege = upper('" + priv + "')";
            OracleCommand cmd = new OracleCommand(priv_user, this.conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            UserPrivGridView.DataSource = dt;
        }

        private void FormUserPriv_Load(object sender, EventArgs e)
        {
            txtOnGrant.Enabled = false;
            txtColGrant.Enabled = false;
        }


        private void txtPerGrant_TextChanged(object sender, EventArgs e)
        {
            if(txtPerGrant.Text.ToLower() == "select" || txtPerGrant.Text.ToLower() == "insert"
                || txtPerGrant.Text.ToLower() == "update" ||  txtPerGrant.Text.ToLower() == "delete")
            {
                txtOnGrant.Enabled = true;
            }
            else
            {
                txtOnGrant.Enabled = false;
            }
        }

        private void txtOnGrant_TextChanged(object sender, EventArgs e)
        {
            if(txtPerGrant.Text.ToLower() == "select" || txtPerGrant.Text.ToLower() == "update")
            {
                txtColGrant.Enabled = true;
            }
            else
            {
                txtColGrant.Enabled = false;
            }
        }

      

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string connectionstring = OracleConnect.connString("localhost", "1521", "orc21c", Admin_login.username, Admin_login.password);
            var conn = new OracleConnection(connectionstring);
            string message = "";
            string user = Username;
            string per = txtPerGrant.Text;
            string on = txtOnGrant.Text;
            string col = txtColGrant.Text;
            bool checkbox = checkBoxGrant.Checked ? true : false;
            string sqlGrant = "grant " + per;
            if (on != "")
            {
                sqlGrant += " on " + on;
            }
            if (col != "")
            {
                string view = "create or replace view " + on + col + " as select " + col + " from " + on;
                try
                {
                    conn.Open();
                    OracleCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = view;
                    cmd.ExecuteNonQuery();
                    string grant_view = "grant " +per+ " on " +on+col + " to " + user;
                    if (checkbox)
                        grant_view += " with grant option";
                    OracleCommand cmd1 = conn.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = grant_view;
                    cmd1.ExecuteNonQuery();
                    message = "Cấp quyền thành công!";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    message = "Error! " + ex.ToString();
                }
                finally
                {
                    conn.Close();
                }

                DialogResult rs1 = MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                
                return;
            }
            try
            {
                conn.Open();
                sqlGrant += " to " + user;
                if (checkbox)
                {
                    if(txtColGrant.Enabled == true)
                        sqlGrant += " with grant option";
                    else
                        sqlGrant += " with admin option";
                }
                OracleCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = sqlGrant;
                cmd1.ExecuteNonQuery();
                message = "Cấp quyền thành công!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                message = "Error! " + ex.ToString();
            }
            finally
            {
                conn.Close();
            }

            DialogResult rs = MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);

            //if (rs == DialogResult.OK)
            //    this.Close();
        }

        //private void txtUserPriv_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtUserPriv.Text != "")
        //    {
        //        txtPerGrant.Enabled = true;
        //        checkBoxGrant.Enabled = true;
        //        btnAccept.Enabled = true;
        //    }
        //    else
        //    {
        //        txtPerGrant.Enabled = false;
        //        checkBoxGrant.Enabled = false;
        //        btnAccept.Enabled = false;
        //    }
        //}
    }
}
