using System;
using System.Drawing;
using System.Windows.Forms;

namespace ARMSClientApp
{
    public class frmCreditCardManagementSystemPortal : Form
    {
        private Label titleLabel = new Label();
        private Panel mainPanel = new Panel();

        private Button btnSearch = new Button();
        private Button btnRegistration = new Button();
        private Button btnUpdate = new Button();
        private Button btnDelete = new Button();
        private Button btnList = new Button();

        private Button btnExit = new Button();

        public frmCreditCardManagementSystemPortal()
        {
            this.Text = "Credit Card Management System Portal";
            this.Name = "frmCreditCardManagementSystemPortal";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = Color.WhiteSmoke;
            this.ClientSize = new Size(520, 420);
            this.Font = new Font("Microsoft Sans Serif", 10F);

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            titleLabel.Text = "Credit Card Management System Portal";
            titleLabel.ForeColor = Color.Black;
            titleLabel.Font = new Font("Microsoft Sans Serif", 11.5F, FontStyle.Bold);
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(18, 12);
            this.Controls.Add(titleLabel);

            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.BackColor = Color.White;
            mainPanel.Location = new Point(18, 55);
            mainPanel.Size = new Size(484, 340);
            this.Controls.Add(mainPanel);

            int x = 62, y = 40, w = 360, h = 34, gap = 16;

            btnSearch.Text = "Credit Card Search";
            btnSearch.BackColor = Color.SteelBlue;
            btnSearch.ForeColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Bold);
            btnSearch.Size = new Size(720, 36);

            btnSearch.Size = new Size(w, h);
            btnSearch.Location = new Point(x, y);

            btnRegistration.Text = "Credit Card Registration (Coming Soon)";
            btnRegistration.BackColor = Color.Gainsboro;
            btnRegistration.ForeColor = Color.DimGray;
            btnRegistration.FlatStyle = FlatStyle.Flat;
            btnRegistration.Enabled = false;
            btnRegistration.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular);
            btnRegistration.Size = new Size(720, 30);

            btnRegistration.Size = new Size(w, h);
            btnRegistration.Location = new Point(x, y + 1*(h+gap));

            btnUpdate.Text = "Credit Card Update (Coming Soon)";
            btnUpdate.BackColor = Color.Gainsboro;
            btnUpdate.ForeColor = Color.DimGray;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular);
            btnUpdate.Size = new Size(720, 30);

            btnUpdate.Size = new Size(w, h);
            btnUpdate.Location = new Point(x, y + 2*(h+gap));

            btnDelete.Text = "Credit Card Delete (Coming Soon)";
            btnDelete.BackColor = Color.Gainsboro;
            btnDelete.ForeColor = Color.DimGray;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Enabled = false;
            btnDelete.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular);
            btnDelete.Size = new Size(720, 30);

            btnDelete.Size = new Size(w, h);
            btnDelete.Location = new Point(x, y + 3*(h+gap));

            btnList.Text = "Credit Card List (Coming Soon)";
            btnList.BackColor = Color.Gainsboro;
            btnList.ForeColor = Color.DimGray;
            btnList.FlatStyle = FlatStyle.Flat;
            btnList.Enabled = false;
            btnList.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular);
            btnList.Size = new Size(720, 30);

            btnList.Size = new Size(w, h);
            btnList.Location = new Point(x, y + 4*(h+gap));

            btnExit.Text = "Exit";
            btnExit.BackColor = Color.SteelBlue;
            btnExit.ForeColor = Color.White;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Bold);
            btnExit.Size = new Size(720, 36);

            btnExit.Size = new Size(200, 34);
            btnExit.Location = new Point(140, y + 5*(h+gap) + 10);

            btnSearch.Click += (s, e) =>
            {
                this.Hide();
                using (var f = new frmCreditCardMSForm())
                {
                    f.ShowDialog(this);
                }
                this.Show();
            };

            btnExit.Click += (s, e) => this.Close();

            mainPanel.Controls.Add(btnSearch);
            mainPanel.Controls.Add(btnRegistration);
            mainPanel.Controls.Add(btnUpdate);
            mainPanel.Controls.Add(btnDelete);
            mainPanel.Controls.Add(btnList);
            mainPanel.Controls.Add(btnExit);
        }
    }
}
