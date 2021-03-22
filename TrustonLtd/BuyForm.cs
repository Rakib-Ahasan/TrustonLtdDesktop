using System;
using System.Windows.Forms;

namespace TrustonLtd
{
    public partial class BuyForm : Form
    {
        public BuyForm(Panel containerPanel)
        {
            ContainerPanel = containerPanel;
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private Panel ContainerPanel;
        private Form _activeForm;

        private void OpenChildForm(Form childForm)
        {
            if (_activeForm != null)
                _activeForm.Close();
            _activeForm = childForm;
            _activeForm.TopLevel = false;
            _activeForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ContainerPanel.Controls.Add(childForm);
            ContainerPanel.Tag = childForm;

            // childForm.Visible = true;
            childForm.BringToFront();
            childForm.Show();
        }

        private void prideTile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BuyPrideForm());
        }

        private void yearnOrExtraTile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new YearnOrExtraBuyForm());
        }

        private void embroideryOrnaTile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmbroideryOrnaBuyForm());
        }

        private void threePieceTile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BuyThreePieceForm());
        }
    }
}
