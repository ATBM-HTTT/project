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
    public partial class FormUserPriv : Form
    {
        private OracleConnection conn;


        public FormUserPriv(OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();

        }

        private void btnUserPrivEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUserPrivView_Click(object sender, EventArgs e)
        {
            //string connectionstring = OracleConnect.connString("localhost", "1521", "orc21c", Admin_login.username, Admin_login.password);
            //var conn = new OracleConnection(connectionstring);
            //conn.Open();
            DataTable dt = new DataTable();
            string priv_user = "select grantee, grantor, privilege, table_name, grantable from dba_tab_privs where grantor = upper('" + txtUserPriv.Text + "')";
            OracleCommand cmd = new OracleCommand(priv_user, this.conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            UserPrivGridView.DataSource = dt;
        }
    }
}
