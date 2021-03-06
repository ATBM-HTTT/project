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
        private OracleConnection conn;


        public FormAddUser(OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string message = "";
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "alter session set \"_ORACLE_SCRIPT\"=TRUE";
                cmd.ExecuteNonQuery();
                string create_user = "create user " + txtUsernameAdd.Text + " identified by " + txtPasswordAdd.Text;
                OracleCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = create_user;
                cmd1.ExecuteNonQuery();
                message = "Thêm thành công!";
                //OracleCommand cmd = new OracleCommand("sp_createuser", conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("usr", OracleDbType.Varchar2).Value = txtUsernameAdd.Text;
                //cmd.Parameters.Add("pw", OracleDbType.Varchar2).Value = txtPasswordAdd.Text;
                //cmd.Parameters.Add("message", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
                //cmd.ExecuteNonQuery();
                //message = cmd.Parameters["message"].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                message = "Error! " + ex.ToString();
            }
            

            DialogResult rs = MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);

            if (rs == DialogResult.OK)
                this.Close();
        }
    }
}
