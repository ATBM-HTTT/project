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
namespace DA_PhanHe1
{
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string connectionstring = OracleConnect.connString("localhost", "1521", "orc21c", Admin_login.username, Admin_login.password);
            var conn = new OracleConnection(connectionstring);
            string message = "";
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("sp_createuser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("usr", OracleDbType.Varchar2).Value = txtUsernameAdd.Text;
                cmd.Parameters.Add("pw", OracleDbType.Varchar2).Value = txtPasswordAdd.Text;
                cmd.Parameters.Add("message", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                message = cmd.Parameters["message"].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            DialogResult rs = MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);

            if (rs == DialogResult.OK)
                this.Close();
        }
    }
}
