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

namespace DA_PhanHe1
{
    public partial class FormUserList : Form
    {
        private OracleConnection conn;

        public FormUserList()
        {
            InitializeComponent();
        }

        public FormUserList(OracleConnection conn)
        {
            this.conn = conn;
        }
    }
}
