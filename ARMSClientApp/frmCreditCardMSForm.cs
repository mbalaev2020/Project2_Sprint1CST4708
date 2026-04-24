
using System;
using System.Drawing;
using System.Windows.Forms;
using ARMSBOLayer;

namespace ARMSClientApp
{
    public class frmCreditCardMSForm : Form
    {
        // Modular-Level CreditCard object POINTER that can be seen by the entire Form
        private CreditCard objCreditCard;

        // ====== PANELS (match requirement naming) ======
        private Panel searchSectionPanel = new Panel();
        private Panel searchDisplaySectionPanel = new Panel();
        private Panel searchPrintSectionPanel = new Panel();
        private Panel searchClearExitSectionPanel = new Panel();

        // ====== SEARCH SECTION ======
        private Label titleLabel = new Label();
        private Label searchPromptLabel = new Label();
        private Label searchTargetCreditCardNumbertLabel = new Label(); // requirement has 'tLabel'
        private TextBox searchTargetCreditCardNumberTextBox = new TextBox();
        private Button searchCreditCardButton = new Button();

        // ====== DISPLAY SECTION ======
        private Label searchResultsSectionTitleLabel = new Label();

        private Label searchResultsCardNumberLabel = new Label();
        private TextBox searchResultsCardNumberTextBox = new TextBox();

        private Label searchResultsOwnerNameLabel = new Label();
        private TextBox searchResultsOwnerNameTextBox = new TextBox();

        private Label searchResultsCardMerchantCompanyLabel = new Label();
        private TextBox searchResultsCardMerchantCompanyTextBox = new TextBox();

        private Label searchResultsCardNetworkCompanyLabel = new Label();
        private TextBox searchResultsCardNetworkCompanyTextBox = new TextBox();

        private Label searchResultsCardIssuingBankLabel = new Label();
        private TextBox searchResultsCardIssuingBankTextBox = new TextBox();

        private Label searchResultsCardMerchantBankLabel = new Label();
        private TextBox searchResultsCardMerchantBankTextBox = new TextBox();

        private Label searchResultsExpirationDateLabel = new Label();
        private TextBox searchResultsExpirationDateTextBox = new TextBox();

        private Label searchResultsAddressLine1Label = new Label();
        private TextBox searchResultsAddressLine1TextBox = new TextBox();

        private Label searchResultsAddressLine2Label = new Label();
        private TextBox searchResultsAddressLine2TextBox = new TextBox();

        private Label searchResultsCityLabel = new Label();
        private TextBox searchResultsCityTextBox = new TextBox();

        private Label searchResultsStateLabel = new Label();
        private TextBox searchResultsStateTextBox = new TextBox();

        private Label searchResultsZipCodeLabel = new Label();
        private TextBox searchResultsZipCodeTextBox = new TextBox();

        private Label searchResultsCountryLabel = new Label();
        private TextBox searchResultsCountryTextBox = new TextBox();

        private Label searchResultsCardLimitLabel = new Label();
        private TextBox searchResultsCardLimitTextBox = new TextBox();

        private Label searchResultsCardAvailableCreditLabel = new Label();
        private TextBox searchResultsCardAvailableCreditTextBox = new TextBox();

        private Label searchResultsCardActivationStatusLabel = new Label();
        private TextBox searchResultsCardActivationStatusTextBox = new TextBox();

        // ====== PRINT / CLEAR / EXIT ======
        private Label searchPrintPromptLabel = new Label();
        private Button searchPrintButton = new Button();
        private Button searchClearButton = new Button();
        private Button searchExitButton = new Button();

        public frmCreditCardMSForm()
        {
            this.Text = "Credit Card Search";
            this.Name = "frmCreditCardMSForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = Color.WhiteSmoke;
            this.ClientSize = new Size(980, 760);
            this.Font = new Font("Microsoft Sans Serif", 10F);

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // ====== TITLE ======
            titleLabel.Name = "titleLabel";
            titleLabel.Text = "Credit Card Search";
            titleLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(18, 10);
            this.Controls.Add(titleLabel);

            // ====== SEARCH PANEL (top) ======
            searchSectionPanel.Name = "searchSectionPanel";
            searchSectionPanel.BorderStyle = BorderStyle.FixedSingle;
            searchSectionPanel.BackColor = Color.White;
            searchSectionPanel.Size = new Size(940, 95);
            searchSectionPanel.Location = new Point(18, 48);

            searchPromptLabel.Name = "searchPromptLabel";
            searchPromptLabel.Text = "Enter Credit Card Number, Click Search";
            searchPromptLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            searchPromptLabel.AutoSize = true;
            searchPromptLabel.Location = new Point(12, 12);

            searchTargetCreditCardNumbertLabel.Name = "searchTargetCreditCardNumbertLabel";
            searchTargetCreditCardNumbertLabel.Text = "Credit Card Number";
            searchTargetCreditCardNumbertLabel.AutoSize = true;
            searchTargetCreditCardNumbertLabel.Location = new Point(12, 44);

            searchTargetCreditCardNumberTextBox.Name = "searchTargetCreditCardNumberTextBox";
            searchTargetCreditCardNumberTextBox.Size = new Size(320, 24);
            searchTargetCreditCardNumberTextBox.Location = new Point(155, 40);
            searchTargetCreditCardNumberTextBox.TabIndex = 0;

            searchCreditCardButton.Name = "searchCreditCardButton";
            searchCreditCardButton.Text = "Search";
            searchCreditCardButton.BackColor = Color.SteelBlue;
            searchCreditCardButton.ForeColor = Color.White;
            searchCreditCardButton.FlatStyle = FlatStyle.Flat;
searchCreditCardButton.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            searchCreditCardButton.Size = new Size(95, 32);
            searchCreditCardButton.Location = new Point(490, 38);
            searchCreditCardButton.TabIndex = 1;
            searchCreditCardButton.Click += searchCreditCardButton_Click;

            searchSectionPanel.Controls.Add(searchPromptLabel);
            searchSectionPanel.Controls.Add(searchTargetCreditCardNumbertLabel);
            searchSectionPanel.Controls.Add(searchTargetCreditCardNumberTextBox);
            searchSectionPanel.Controls.Add(searchCreditCardButton);
            this.Controls.Add(searchSectionPanel);

            // ====== DISPLAY PANEL (left) ======
            searchDisplaySectionPanel.Name = "searchDisplaySectionPanel";
            searchDisplaySectionPanel.BorderStyle = BorderStyle.FixedSingle;
            searchDisplaySectionPanel.BackColor = Color.White;
            searchDisplaySectionPanel.Size = new Size(640, 520);
            searchDisplaySectionPanel.Location = new Point(18, 160);

            searchResultsSectionTitleLabel.Name = "searchResultsSectionTitleLabel";
            searchResultsSectionTitleLabel.Text = "Credit Card Information:";
            searchResultsSectionTitleLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            searchResultsSectionTitleLabel.AutoSize = true;
            searchResultsSectionTitleLabel.Location = new Point(12, 12);

            searchDisplaySectionPanel.Controls.Add(searchResultsSectionTitleLabel);

            int leftLbl = 18;
            int leftTb = 240;
            int rowTop = 42;
            int rowH = 28;
            int tbW = 370;

            Action<Label, TextBox, string, string, string, int> addRow = (lbl, tb, text, lblName, tbName, idx) =>
            {
                lbl.Name = lblName;
                lbl.Text = text;
                lbl.AutoSize = true;
                lbl.Location = new Point(leftLbl, rowTop + idx * rowH);

                tb.Name = tbName;
                tb.Size = new Size(tbW, 24);
                tb.Location = new Point(leftTb, rowTop + idx * rowH - 3);
                tb.ReadOnly = true;
                tb.TabStop = false;

                searchDisplaySectionPanel.Controls.Add(lbl);
                searchDisplaySectionPanel.Controls.Add(tb);
            };

            addRow(searchResultsCardNumberLabel, searchResultsCardNumberTextBox, "Credit Card Number", "searchResultsCardNumberLabel", "searchResultsCardNumberTextBox", 0);
            addRow(searchResultsOwnerNameLabel, searchResultsOwnerNameTextBox, "Owner Name", "searchResultsOwnerNameLabel", "searchResultsOwnerNameTextBox", 1);
            addRow(searchResultsCardMerchantCompanyLabel, searchResultsCardMerchantCompanyTextBox, "Card Merchant Company", "searchResultsCardMerchantCompanyLabel", "searchResultsCardMerchantCompanyTextBox", 2);
            addRow(searchResultsCardNetworkCompanyLabel, searchResultsCardNetworkCompanyTextBox, "Card Network Company", "searchResultsCardNetworkCompanyLabel", "searchResultsCardNetworkCompanyTextBox", 3);
            addRow(searchResultsCardIssuingBankLabel, searchResultsCardIssuingBankTextBox, "Card Issuing Bank", "searchResultsCardIssuingBankLabel", "searchResultsCardIssuingBankTextBox", 4);
            addRow(searchResultsCardMerchantBankLabel, searchResultsCardMerchantBankTextBox, "Card Merchant Bank", "searchResultsCardMerchantBankLabel", "searchResultsCardMerchantBankTextBox", 5);
            addRow(searchResultsExpirationDateLabel, searchResultsExpirationDateTextBox, "Expiration Date", "searchResultsExpirationDateLabel", "searchResultsExpirationDateTextBox", 6);
            addRow(searchResultsAddressLine1Label, searchResultsAddressLine1TextBox, "Address Line 1", "searchResultsAddressLine1Label", "searchResultsAddressLine1TextBox", 7);
            addRow(searchResultsAddressLine2Label, searchResultsAddressLine2TextBox, "Address Line 2", "searchResultsAddressLine2Label", "searchResultsAddressLine2TextBox", 8);
            addRow(searchResultsCityLabel, searchResultsCityTextBox, "City", "searchResultsCityLabel", "searchResultsCityTextBox", 9);
            addRow(searchResultsStateLabel, searchResultsStateTextBox, "State", "searchResultsStateLabel", "searchResultsStateTextBox", 10);
            addRow(searchResultsZipCodeLabel, searchResultsZipCodeTextBox, "Zip Code", "searchResultsZipCodeLabel", "searchResultsZipCodeTextBox", 11);
            addRow(searchResultsCountryLabel, searchResultsCountryTextBox, "Country", "searchResultsCountryLabel", "searchResultsCountryTextBox", 12);
            addRow(searchResultsCardLimitLabel, searchResultsCardLimitTextBox, "Card Limit", "searchResultsCardLimitLabel", "searchResultsCardLimitTextBox", 13);
            addRow(searchResultsCardAvailableCreditLabel, searchResultsCardAvailableCreditTextBox, "Card Available Credit", "searchResultsCardAvailableCreditLabel", "searchResultsCardAvailableCreditTextBox", 14);
            addRow(searchResultsCardActivationStatusLabel, searchResultsCardActivationStatusTextBox, "Card Activation Status", "searchResultsCardActivationStatusLabel", "searchResultsCardActivationStatusTextBox", 15);

            this.Controls.Add(searchDisplaySectionPanel);

            // ====== PRINT PANEL (right) ======
            searchPrintSectionPanel.Name = "searchPrintSectionPanel";
            searchPrintSectionPanel.BorderStyle = BorderStyle.FixedSingle;
            searchPrintSectionPanel.BackColor = Color.White;
            searchPrintSectionPanel.Size = new Size(300, 520);
            searchPrintSectionPanel.Location = new Point(670, 160);

            searchPrintPromptLabel.Name = "searchPrintPromptLabel";
            searchPrintPromptLabel.Text = "Print Credit Card Information:";
            searchPrintPromptLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold | FontStyle.Italic);
            searchPrintPromptLabel.AutoSize = true;
            searchPrintPromptLabel.Location = new Point(18, 18);

            searchPrintButton.Name = "searchPrintButton";
            searchPrintButton.Text = "Print";
            searchPrintButton.BackColor = Color.SteelBlue;
            searchPrintButton.ForeColor = Color.White;
            searchPrintButton.FlatStyle = FlatStyle.Flat;
searchPrintButton.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            searchPrintButton.Size = new Size(95, 32);
            searchPrintButton.Location = new Point(95, 60);
            searchPrintButton.TabIndex = 2;
            searchPrintButton.Enabled = false; // enable only after a record is found
            searchPrintButton.Click += searchPrintButton_Click;

            searchPrintSectionPanel.Controls.Add(searchPrintPromptLabel);
            searchPrintSectionPanel.Controls.Add(searchPrintButton);
            this.Controls.Add(searchPrintSectionPanel);

            // ====== CLEAR/EXIT PANEL (bottom) ======
            searchClearExitSectionPanel.Name = "searchClearExitSectionPanel";
            searchClearExitSectionPanel.BorderStyle = BorderStyle.FixedSingle;
            searchClearExitSectionPanel.BackColor = Color.White;
            searchClearExitSectionPanel.Size = new Size(940, 60);
            searchClearExitSectionPanel.Location = new Point(18, 690);

            searchClearButton.Name = "searchClearButton";
            searchClearButton.Text = "Clear";
            searchClearButton.BackColor = Color.SteelBlue;
            searchClearButton.ForeColor = Color.White;
            searchClearButton.FlatStyle = FlatStyle.Flat;
searchClearButton.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            searchClearButton.Size = new Size(95, 32);
            searchClearButton.Location = new Point(120, 12);
            searchClearButton.TabIndex = 3;
            searchClearButton.Click += searchClearButton_Click;

            searchExitButton.Name = "searchExitButton";
            searchExitButton.Text = "Exit";
            searchExitButton.BackColor = Color.SteelBlue;
            searchExitButton.ForeColor = Color.White;
            searchExitButton.FlatStyle = FlatStyle.Flat;
searchExitButton.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            searchExitButton.Size = new Size(95, 32);
            searchExitButton.Location = new Point(720, 12);
            searchExitButton.TabIndex = 4;
            searchExitButton.Click += searchExitButton_Click;

            searchClearExitSectionPanel.Controls.Add(searchClearButton);
            searchClearExitSectionPanel.Controls.Add(searchExitButton);
            this.Controls.Add(searchClearExitSectionPanel);
        }

        // SEARCH click event-handler (algorithm from requirement)
        private void searchCreditCardButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Step1 - Create object using modular-level pointer
                objCreditCard = new CreditCard();

                // Step2 - Call Load(ID)
                bool found = objCreditCard.Load(searchTargetCreditCardNumberTextBox.Text.Trim());

                // Step3 - if found populate UI
                if (found)
                {
                    searchResultsCardNumberTextBox.Text = objCreditCard.CreditCardNumber;
                    searchResultsOwnerNameTextBox.Text = objCreditCard.CreditCardOwnerName;
                    searchResultsCardMerchantCompanyTextBox.Text = objCreditCard.CreditCardProcessingMerchantServiceCompanyName;
                    searchResultsCardNetworkCompanyTextBox.Text = objCreditCard.CreditCardNetworkCompanyName;
                    searchResultsCardIssuingBankTextBox.Text = objCreditCard.CreditCardIssuingBankName;
                    searchResultsCardMerchantBankTextBox.Text = objCreditCard.CreditCardCorporateMerchantBankName;

                    searchResultsExpirationDateTextBox.Text = objCreditCard.ExpDate.ToShortDateString();
                    searchResultsAddressLine1TextBox.Text = objCreditCard.AddressLine1;
                    searchResultsAddressLine2TextBox.Text = objCreditCard.AddressLine2;
                    searchResultsCityTextBox.Text = objCreditCard.City;
                    searchResultsStateTextBox.Text = objCreditCard.StateCode;
                    searchResultsZipCodeTextBox.Text = objCreditCard.ZipCode;
                    searchResultsCountryTextBox.Text = objCreditCard.Country;

                    searchResultsCardLimitTextBox.Text = objCreditCard.CreditCardLimit.ToString("0.00");
                    searchResultsCardAvailableCreditTextBox.Text = objCreditCard.CreditCardAvailableCredit.ToString("0.00");
                    searchResultsCardActivationStatusTextBox.Text = objCreditCard.CreditCardActivationStatus ? "Active" : "Inactive";

                    // enable Print only after record is found
                    searchPrintButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Credit Card record NOT found!");
                    ClearForm();
                }
            }
            catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        }

        // PRINT click event-handler
        private void searchPrintButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (objCreditCard != null)
                {
                    objCreditCard.Print();
                    MessageBox.Show("Credit Card information was sent to Network_Printer.txt");
                }
                else
                {
                    MessageBox.Show("Please search for a credit card first, then click Print.");
                }
            }
            catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        }

        // CLEAR click event-handler
        private void searchClearButton_Click(object sender, EventArgs e)
        {
            try
            {
                ClearForm();
            }
            catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        }

        private void ClearForm()
        {
            searchTargetCreditCardNumberTextBox.Text = "";

            searchResultsCardNumberTextBox.Text = "";
            searchResultsOwnerNameTextBox.Text = "";
            searchResultsCardMerchantCompanyTextBox.Text = "";
            searchResultsCardNetworkCompanyTextBox.Text = "";
            searchResultsCardIssuingBankTextBox.Text = "";
            searchResultsCardMerchantBankTextBox.Text = "";
            searchResultsExpirationDateTextBox.Text = "";
            searchResultsAddressLine1TextBox.Text = "";
            searchResultsAddressLine2TextBox.Text = "";
            searchResultsCityTextBox.Text = "";
            searchResultsStateTextBox.Text = "";
            searchResultsZipCodeTextBox.Text = "";
            searchResultsCountryTextBox.Text = "";
            searchResultsCardLimitTextBox.Text = "";
            searchResultsCardAvailableCreditTextBox.Text = "";
            searchResultsCardActivationStatusTextBox.Text = "";

            searchPrintButton.Enabled = false;

            // Requirement: set modular-level pointer to NULL
            objCreditCard = null;
        }

        // EXIT click event-handler
        private void searchExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
