using System;
using System.Drawing;
using System.Windows.Forms;

namespace ARMSClientApp
{
    public class frmCustomerMSForm : Form
    {
        private Label titleLabel = new Label();
        private Panel mainPanel = new Panel();
        private Label msgLabel = new Label();
        private Panel bottomPanel = new Panel();
        private Button exitButton = new Button();

        public frmCustomerMSForm()
        {
            this.Text = "Customer Search";
            this.Name = "frmCustomerMSForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = Color.WhiteSmoke;
            this.ClientSize = new Size(980, 420);
            this.Font = new Font("Microsoft Sans Serif", 10F);

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            titleLabel.Text = "Customer Search";
            titleLabel.ForeColor = Color.Black;
            titleLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(18, 10);
            this.Controls.Add(titleLabel);

            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.BackColor = Color.White;
            mainPanel.Location = new Point(18, 55);
            mainPanel.Size = new Size(940, 270);

            msgLabel.Text = "Coming soon - under maintenance.";
            msgLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            msgLabel.AutoSize = true;
            msgLabel.Location = new Point(18, 18);
            mainPanel.Controls.Add(msgLabel);

            this.Controls.Add(mainPanel);

            bottomPanel.BorderStyle = BorderStyle.FixedSingle;
            bottomPanel.BackColor = Color.White;
            bottomPanel.Location = new Point(18, 335);
            bottomPanel.Size = new Size(940, 60);

            exitButton.Text = "Exit";
            exitButton.BackColor = Color.SteelBlue;
            exitButton.ForeColor = Color.White;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            exitButton.Size = new Size(110, 34);
            exitButton.Location = new Point(812, 12);
            exitButton.TabIndex = 0;
            exitButton.Click += (s,e) => this.Close();

            bottomPanel.Controls.Add(exitButton);
            this.Controls.Add(bottomPanel);
        }
    }
}
