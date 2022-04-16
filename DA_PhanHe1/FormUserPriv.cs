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
    }
}
