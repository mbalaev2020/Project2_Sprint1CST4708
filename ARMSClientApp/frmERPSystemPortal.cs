using System;
using System.Drawing;
using System.Windows.Forms;

namespace ARMSClientApp
{
    public class frmERPSystemPortal : Form
    {
        private Label titleLabel = new Label();
        private Panel mainPanel = new Panel();

        private Button btnCreditCardMgmt = new Button();

        private Button btnVehicle = new Button();
        private Button btnCRM = new Button();
        private Button btnHR = new Button();
        private Button btnFinance = new Button();
        private Button btnMarketing = new Button();
        private Button btnCustomerField = new Button();

        private Button btnExit = new Button();

        public frmERPSystemPortal()
        {
            this.Text = "Enterprise Resource Planning (ERP) System Portal";
            this.Name = "frmERPSystemPortal";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = Color.WhiteSmoke;
            this.ClientSize = new Size(720, 520);
            this.Font = new Font("Microsoft Sans Serif", 10F);

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            titleLabel.Text = "Enterprise Resource Planning (ERP) System Portal";
            titleLabel.ForeColor = Color.Black;
            titleLabel.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Bold);
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(18, 12);
            this.Controls.Add(titleLabel);

            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.BackColor = Color.White;
            mainPanel.Location = new Point(18, 55);
            mainPanel.Size = new Size(684, 440);
            this.Controls.Add(mainPanel);

            int x = 32, y = 40, w = 620, h = 32, gap = 12;

            btnCreditCardMgmt.Text = "Credit Card Management System";
            btnCreditCardMgmt.BackColor = Color.SteelBlue;
            btnCreditCardMgmt.ForeColor = Color.White;
            btnCreditCardMgmt.FlatStyle = FlatStyle.Flat;
            btnCreditCardMgmt.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Bold);
            btnCreditCardMgmt.Size = new Size(720, 36);

            btnCreditCardMgmt.Size = new Size(w, 36);
            btnCreditCardMgmt.Location = new Point(x, y);

            btnVehicle.Text = "Vehicle Inventory, Transportation, Maintenance Management System (Coming Soon)";
            btnVehicle.BackColor = Color.Gainsboro;
            btnVehicle.ForeColor = Color.DimGray;
            btnVehicle.FlatStyle = FlatStyle.Flat;
            btnVehicle.Enabled = false;
            btnVehicle.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular);
            btnVehicle.Size = new Size(720, 30);

            btnVehicle.Location = new Point(x, y + 1*(h+gap) + 14);
            btnVehicle.Size = new Size(w, h);

            btnCRM.Text = "Customer Relationship Management (CRM) System (Coming Soon)";
            btnCRM.BackColor = Color.Gainsboro;
            btnCRM.ForeColor = Color.DimGray;
            btnCRM.FlatStyle = FlatStyle.Flat;
            btnCRM.Enabled = false;
            btnCRM.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular);
            btnCRM.Size = new Size(720, 30);

            btnCRM.Location = new Point(x, y + 2*(h+gap) + 14);
            btnCRM.Size = new Size(w, h);

            btnHR.Text = "Human Resource Management System (Coming Soon)";
            btnHR.BackColor = Color.Gainsboro;
            btnHR.ForeColor = Color.DimGray;
            btnHR.FlatStyle = FlatStyle.Flat;
            btnHR.Enabled = false;
            btnHR.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular);
            btnHR.Size = new Size(720, 30);

            btnHR.Location = new Point(x, y + 3*(h+gap) + 14);
            btnHR.Size = new Size(w, h);

            btnFinance.Text = "Finance and Operations Management System (Coming Soon)";
            btnFinance.BackColor = Color.Gainsboro;
            btnFinance.ForeColor = Color.DimGray;
            btnFinance.FlatStyle = FlatStyle.Flat;
            btnFinance.Enabled = false;
            btnFinance.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular);
            btnFinance.Size = new Size(720, 30);

            btnFinance.Location = new Point(x, y + 4*(h+gap) + 14);
            btnFinance.Size = new Size(w, h);

            btnMarketing.Text = "Marketing Management System (Coming Soon)";
            btnMarketing.BackColor = Color.Gainsboro;
            btnMarketing.ForeColor = Color.DimGray;
            btnMarketing.FlatStyle = FlatStyle.Flat;
            btnMarketing.Enabled = false;
            btnMarketing.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular);
            btnMarketing.Size = new Size(720, 30);

            btnMarketing.Location = new Point(x, y + 5*(h+gap) + 14);
            btnMarketing.Size = new Size(w, h);

            btnCustomerField.Text = "Customer Field Service Management System (Coming Soon)";
            btnCustomerField.BackColor = Color.Gainsboro;
            btnCustomerField.ForeColor = Color.DimGray;
            btnCustomerField.FlatStyle = FlatStyle.Flat;
            btnCustomerField.Enabled = false;
            btnCustomerField.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular);
            btnCustomerField.Size = new Size(720, 30);

            btnCustomerField.Location = new Point(x, y + 6*(h+gap) + 14);
            btnCustomerField.Size = new Size(w, h);

            btnExit.Text = "Exit";
            btnExit.BackColor = Color.SteelBlue;
            btnExit.ForeColor = Color.White;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Bold);
            btnExit.Size = new Size(720, 36);

            btnExit.Size = new Size(220, 34);
            btnExit.Location = new Point(232, 370);

            btnCreditCardMgmt.Click += (s, e) =>
            {
                this.Hide();
                using (var f = new frmCreditCardManagementSystemPortal())
                {
                    f.ShowDialog(this);
                }
                this.Show();
            };

            btnExit.Click += (s, e) => this.Close();

            mainPanel.Controls.Add(btnCreditCardMgmt);
            mainPanel.Controls.Add(btnVehicle);
            mainPanel.Controls.Add(btnCRM);
            mainPanel.Controls.Add(btnHR);
            mainPanel.Controls.Add(btnFinance);
            mainPanel.Controls.Add(btnMarketing);
            mainPanel.Controls.Add(btnCustomerField);
            mainPanel.Controls.Add(btnExit);
        }
    }
}
