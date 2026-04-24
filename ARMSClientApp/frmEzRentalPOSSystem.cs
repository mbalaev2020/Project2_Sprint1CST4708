using System;
using System.Drawing;
using System.Windows.Forms;

namespace ARMSClientApp
{
    public class frmEzRentalPOSSystem : Form
    {
        private Label titleLabel = new Label();

        private Panel mainPanel = new Panel();
        private Button btnRentalPOS = new Button();
        private Button btnERPPortal = new Button();
        private Button btnExitApp = new Button();

        public frmEzRentalPOSSystem()
        {
            this.Text = "EzRental POS System";
            this.Name = "frmEzRentalPOSSystem";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = Color.WhiteSmoke;
            this.ClientSize = new Size(720, 320);
            this.Font = new Font("Microsoft Sans Serif", 10F);

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            titleLabel.Text = "EzRental POS System";
            titleLabel.ForeColor = Color.Black;
            titleLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(18, 12);
            this.Controls.Add(titleLabel);

            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.BackColor = Color.White;
            mainPanel.Location = new Point(18, 55);
            mainPanel.Size = new Size(684, 240);
            this.Controls.Add(mainPanel);

            // Rental POS (coming soon)
            btnRentalPOS.Text = "Rental Point-Of-Sale (Coming Soon)";
            btnRentalPOS.BackColor = Color.Gainsboro;
            btnRentalPOS.ForeColor = Color.DimGray;
            btnRentalPOS.FlatStyle = FlatStyle.Flat;
            btnRentalPOS.Enabled = false;
            btnRentalPOS.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular);
            btnRentalPOS.Size = new Size(720, 30);

            btnRentalPOS.Location = new Point( -999, -999 ); // will set below

            // ERP Portal (opens next screen)
            btnERPPortal.Text = "Enterprise Resource Planning (ERP) System Portal";
            btnERPPortal.BackColor = Color.SteelBlue;
            btnERPPortal.ForeColor = Color.White;
            btnERPPortal.FlatStyle = FlatStyle.Flat;
            btnERPPortal.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Bold);
            btnERPPortal.Size = new Size(720, 36);

            btnERPPortal.Size = new Size(620, 36);

            // Exit
            btnExitApp.Text = "Exit Application";
            btnExitApp.BackColor = Color.SteelBlue;
            btnExitApp.ForeColor = Color.White;
            btnExitApp.FlatStyle = FlatStyle.Flat;
            btnExitApp.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Bold);
            btnExitApp.Size = new Size(720, 36);

            btnExitApp.Size = new Size(220, 34);

            // Layout
            btnRentalPOS.Location = new Point(32, 55);
            btnRentalPOS.Size = new Size(620, 30);

            btnERPPortal.Location = new Point(32, 98);
            btnERPPortal.Size = new Size(620, 36);

            btnExitApp.Location = new Point(232, 165);

            btnERPPortal.Click += (s, e) =>
            {
                this.Hide();
                using (var f = new frmERPSystemPortal())
                {
                    f.ShowDialog(this);
                }
                this.Show();
            };

            btnExitApp.Click += (s, e) => this.Close();

            mainPanel.Controls.Add(btnRentalPOS);
            mainPanel.Controls.Add(btnERPPortal);
            mainPanel.Controls.Add(btnExitApp);
        }
    }
}
