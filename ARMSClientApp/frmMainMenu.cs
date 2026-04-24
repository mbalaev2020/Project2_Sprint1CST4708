using System;
using System.Drawing;
using System.Windows.Forms;

namespace ARMSClientApp
{
    public class frmMainMenu : Form
    {
        private Label titleLabel = new Label();
        private Panel menuPanel = new Panel();

        private Button btnCreditCard = new Button();
        private Button btnCustomer = new Button();
        private Button btnVehicle = new Button();
        private Button btnRental = new Button();

        private Panel bottomPanel = new Panel();
        private Button btnExit = new Button();

        public frmMainMenu()
        {
            this.Text = "ARMS - Main Menu";
            this.Name = "frmMainMenu";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = Color.WhiteSmoke;
            this.ClientSize = new Size(980, 520);
            this.Font = new Font("Microsoft Sans Serif", 10F);

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            titleLabel.Text = "ARMS - Main Menu";
            titleLabel.ForeColor = Color.Black;
            titleLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(18, 10);
            this.Controls.Add(titleLabel);

            menuPanel.BorderStyle = BorderStyle.FixedSingle;
            menuPanel.BackColor = Color.White;
            menuPanel.Location = new Point(18, 55);
            menuPanel.Size = new Size(940, 360);
            this.Controls.Add(menuPanel);

            int x = 140, y = 80, w = 660, h = 50, gap = 22;

            void styleButton(Button b, string text, int idx)
            {
                b.Text = text;
                b.BackColor = Color.SteelBlue;
                b.ForeColor = Color.White;
                b.FlatStyle = FlatStyle.Flat;
                b.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
                b.Size = new Size(w, h);
                b.Location = new Point(x, y + idx * (h + gap));
                b.TabIndex = idx;
            }

            styleButton(btnCreditCard, "Credit Card Search", 0);
            styleButton(btnCustomer,   "Customer Search", 1);
            styleButton(btnVehicle,    "Vehicle Search", 2);
            styleButton(btnRental,     "Rental Search", 3);

            btnCreditCard.Click += (s, e) => new frmCreditCardMSForm().ShowDialog(this);
            btnCustomer.Click += (s, e) => new frmCustomerMSForm().ShowDialog(this);
            btnVehicle.Click += (s, e) => new frmVehicleMSForm().ShowDialog(this);
            btnRental.Click += (s, e) => new frmRentalMSForm().ShowDialog(this);

            menuPanel.Controls.Add(btnCreditCard);
            menuPanel.Controls.Add(btnCustomer);
            menuPanel.Controls.Add(btnVehicle);
            menuPanel.Controls.Add(btnRental);

            bottomPanel.BorderStyle = BorderStyle.FixedSingle;
            bottomPanel.BackColor = Color.White;
            bottomPanel.Location = new Point(18, 425);
            bottomPanel.Size = new Size(940, 60);
            this.Controls.Add(bottomPanel);

            btnExit.Text = "Exit";
            btnExit.BackColor = Color.SteelBlue;
            btnExit.ForeColor = Color.White;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            btnExit.Size = new Size(110, 34);
            btnExit.Location = new Point(812, 12);
            btnExit.TabIndex = 4;
            btnExit.Click += (s, e) => this.Close();
            bottomPanel.Controls.Add(btnExit);
        }
    }
}
