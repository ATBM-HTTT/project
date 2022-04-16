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
    public partial class FormRoleViewPriv : Form
    {
        public FormRoleViewPriv()
        {
            InitializeComponent();
        }

        private void btnRolePrivView_Click(object sender, EventArgs e)
        {
            string connectionstring = OracleConnect.connString("localhost", "1521", "orc21c", Admin_login.username, Admin_login.password);
            var conn = new OracleConnection(connectionstring);
            conn.Open();
            DataTable dt = new DataTable();
            string priv_role = "select role, privilege, admin_option from role_sys_privs where role = upper('" + txtRolePriv.Text + "')";
            OracleCommand cmd = new OracleCommand(priv_role, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            RolePrivGridView.DataSource = dt;
        }

        private void btnUserPrivExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
