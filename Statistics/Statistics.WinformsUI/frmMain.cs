using System.Windows.Forms;

namespace Statistics.WinformsUI
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

        private void btnUniform_Click(object sender, System.EventArgs e)
        {
            var fUniformDistribution = new frmUniformDistribution();
            fUniformDistribution.Show();
        }

        private void btnTriangular_Click(object sender, System.EventArgs e)
        {
            var fTriangularDistribution = new frmTriangularDistribution();
            fTriangularDistribution.Show();
        }

        private void btnNormal_Click(object sender, System.EventArgs e)
        {
            var fNormalDistribution = new frmNormalDistribution();
            fNormalDistribution.Show();
        }

        private void btnSkewed_Click(object sender, System.EventArgs e)
        {
            var fSkewedNormalDistribution = new frmSkewedNormalDistribution();
            fSkewedNormalDistribution.Show();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
