using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jupu
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void TslDatabaseSetting_Click(object sender, EventArgs e)
        {

        }

        private void TslDataManagement_Click(object sender, EventArgs e)
        {
            FrmDataManagement childForm = new FrmDataManagement();
            childForm.Show();
            childForm.StartPosition = FormStartPosition.CenterParent;
            
        }
    }
}
