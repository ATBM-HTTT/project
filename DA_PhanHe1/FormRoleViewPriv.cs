﻿using System;
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
        private OracleConnection conn;

        public FormRoleViewPriv(OracleConnection conn, string rolename)
        {
            this.conn = conn;
            Rolename = rolename;
            InitializeComponent();
            getPriv();
        }
        public string Rolename { get; }

        private void getPriv()
        {
            //"select role, privilege, admin_option from role_sys_privs where role = upper('" + Rolename + "')";
            DataTable dt = new DataTable();
            string priv_role = "SELECT DBA_TAB_PRIVS.TABLE_NAME, DBA_TAB_PRIVS.PRIVILEGE, DBA_TAB_PRIVS.GRANTABLE, DBA_COL_PRIVS.COLUMN_NAME from DBA_TAB_PRIVS left join DBA_COL_PRIVS on DBA_TAB_PRIVS.TABLE_NAME = DBA_COL_PRIVS.TABLE_NAME WHERE DBA_TAB_PRIVS.GRANTEE = upper('" + Rolename + "')";
            OracleCommand cmd = new OracleCommand(priv_role, this.conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            RolePrivGridView.DataSource = dt;
        }

        private void btnRolePrivView_Click(object sender, EventArgs e)
        {
            string priv = txtRolePriv.Text;
            DataTable dt = new DataTable();
            string priv_user = "select role, privilege, admin_option from role_sys_privs where role = upper('" + Rolename + "') and privilege = upper('" + priv + "')";
            OracleCommand cmd = new OracleCommand(priv_user, this.conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            RolePrivGridView.DataSource = dt;
        }

        private void btnUserPrivExit_Click(object sender, EventArgs e)
        {
            DialogResult rq = MessageBox.Show("Bạn có thực sự muốn xóa quyền này?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (rq.Equals(DialogResult.Yes))
            {
                string message = "";
                try
                {
                        //OracleCommand cmd = conn.CreateCommand();
                        //cmd.CommandType = CommandType.Text;
                        //cmd.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
                        //cmd.ExecuteNonQuery();
                    string priv_name = cbPermission.Text;
                    string table_name = cbTable.Text;

                    //this.conn.Execute("sp_revokepriv_tab", new { grantee = Username, privilege = priv_name, table_name = table_name }, commandType: CommandType.StoredProcedure);
                    string del_priv = "revoke " + priv_name + " on " + table_name + " from " + Rolename;
                    OracleCommand cmd1 = this.conn.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = del_priv;
                    cmd1.ExecuteNonQuery();
                    message = "Xóa thành công!";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    message = "Error! " + ex.ToString();
                }
                DialogResult rs = MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRoleViewPriv_Load(object sender, EventArgs e)
        {
            cbPermission.SelectedIndex = 0;
            DataTable dt = new DataTable();
            string query = "select TABLE_NAME from user_tables";
            OracleCommand cmd = new OracleCommand(query, this.conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            cbTable.DataSource = dt;
            cbTable.DisplayMember = "TABLE_NAME";
            cbTable.ValueMember = "TABLE_NAME";
            cbTable.SelectedIndex = 0;
            checkBoxGrant.Enabled = false;
        }

        private void cbPermission_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPermission.Text == "SELECT" || cbPermission.Text == "UPDATE")
            {
                cbColumn.Enabled = true;
            }
            else
            {
                cbColumn.Enabled = false;
            }
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string table = cbTable.Text;
            DataTable col = new DataTable();
            string query = "SELECT column_name FROM USER_TAB_COLUMNS WHERE table_name = '" + table + "'";
            OracleCommand cmd = new OracleCommand(query, this.conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(col);
            col.Rows.Add("ALL COLUMN");
            cbColumn.DataSource = col;
            cbColumn.DisplayMember = "COLUMN_NAME";
            cbColumn.ValueMember = "COLUMN_NAME";
            cbColumn.SelectedIndex = cbColumn.FindStringExact("ALL COLUMN");
        }

        private void Refesh_Click(object sender, EventArgs e)
        {
            getPriv();
            txtRolePriv.Text = "";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string connectionstring = OracleConnect.connString("localhost", "1521", "orc21c", Admin_login.username, Admin_login.password);
            var conn = new OracleConnection(connectionstring);
            string message = "";
            string role = Rolename;
            string per = cbPermission.Text;
            string on = cbTable.Text;
            string col = cbColumn.Text;
            bool checkbox = checkBoxGrant.Checked ? true : false;
            string sqlGrant = "grant " + per + " on " + on;
            if(col != "ALL COLUMN")
            {
                string view = "create or replace view " + on + col + " as select " + col + " from " + on;
                try
                {
                    conn.Open();
                    OracleCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = view;
                    cmd.ExecuteNonQuery();
                    string grant_view = "grant " + per + " on " + on + col + " to " + role;
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
                sqlGrant += " to " + role;
                if (checkbox)
                {
                    if (cbColumn.Enabled == true)
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
        }


        //private void FormRoleViewPriv_Load_1(object sender, EventArgs e)
        //{
        //    txtOnGrant.Enabled = false;
        //    txtColGrant.Enabled = false;
        //}

        //private void txtPerGrant_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtPerGrant.Text.ToLower() == "select" || txtPerGrant.Text.ToLower() == "insert"
        //        || txtPerGrant.Text.ToLower() == "update" || txtPerGrant.Text.ToLower() == "delete")
        //    {
        //        txtOnGrant.Enabled = true;
        //    }
        //    else
        //    {
        //        txtOnGrant.Enabled = false;
        //    }
        //}

        //private void txtOnGrant_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtPerGrant.Text.ToLower() == "select" || txtPerGrant.Text.ToLower() == "update")
        //    {
        //        txtColGrant.Enabled = true;
        //    }
        //    else
        //    {
        //        txtColGrant.Enabled = false;
        //    }
        //}

        //        private void btnAccept_Click(object sender, EventArgs e)
        //        {
        //            string connectionstring = OracleConnect.connString("localhost", "1521", "orc21c", Admin_login.username, Admin_login.password);
        //            var conn = new OracleConnection(connectionstring);
        //            string message = "";
        //            string role = Rolename;
        //            string per = txtPerGrant.Text;
        //            string on = txtOnGrant.Text;
        //            string col = txtColGrant.Text;
        //            bool checkbox = checkBoxGrant.Checked ? true : false;
        //            string sqlGrant = "grant " + per;
        //            if (on != "")
        //            {
        //                sqlGrant += " on " + on;
        //            }
        //            if (col != "")
        //            {
        //                string view = "create or replace view " + on + col + " as select " + col + " from " + on;
        //                try
        //                {
        //                    conn.Open();
        //                    OracleCommand cmd = conn.CreateCommand();
        //                    cmd.CommandType = CommandType.Text;
        //                    cmd.CommandText = view;
        //                    cmd.ExecuteNonQuery();
        //                    string grant_view = "grant " + per + " on " + on + col + " to " + role;
        //                    if (checkbox)
        //                        grant_view += " with grant option";
        //                    OracleCommand cmd1 = conn.CreateCommand();
        //                    cmd1.CommandType = CommandType.Text;
        //                    cmd1.CommandText = grant_view;
        //                    cmd1.ExecuteNonQuery();
        //                    message = "Cấp quyền thành công!";
        //                }
        //                catch (Exception ex)
        //                {
        //                    Console.WriteLine(ex.ToString());
        //                    message = "Error! " + ex.ToString();
        //                }
        //                finally
        //                {
        //                    conn.Close();
        //                }

        //                DialogResult rs1 = MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);

        //                return;
        //            }
        //            try
        //            {
        //                conn.Open();
        //                sqlGrant += " to " + role;
        //                if (checkbox)
        //                {
        //                    if (txtColGrant.Enabled == true)
        //                        sqlGrant += " with grant option";
        //                    else
        //                        sqlGrant += " with admin option";
        //                }
        //                OracleCommand cmd1 = conn.CreateCommand();
        //                cmd1.CommandType = CommandType.Text;
        //                cmd1.CommandText = sqlGrant;
        //                cmd1.ExecuteNonQuery();
        //                message = "Cấp quyền thành công!";
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.ToString());
        //                message = "Error! " + ex.ToString();
        //            }
        //            finally
        //            {
        //                conn.Close();
        //            }

        //            DialogResult rs = MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);

        //        }
        //    }

    }
}
