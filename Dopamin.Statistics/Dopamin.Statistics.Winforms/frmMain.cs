using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dopamin.Statistics.Winforms
{
    public partial class frmMain : Form
    {
        #region Constructor

        public frmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region Buttons


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


    }
}
