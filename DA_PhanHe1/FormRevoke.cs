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
    public partial class FormRevoke : Form
    {
        private OracleConnection conn;
        public FormRevoke(OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }
    }
}
