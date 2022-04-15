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
