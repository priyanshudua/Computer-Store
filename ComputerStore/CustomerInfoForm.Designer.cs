namespace ComputerStore
{
    partial class CustomerInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FirstNameLabel = new Label();
            FirstName = new TextBox();
            LastNameLabel = new Label();
            LastName = new TextBox();
            TelephoneNumberLabel = new Label();
            TelephoneNumber = new TextBox();
            AddressLabel = new Label();
            Address = new TextBox();
            CreditCardDataLabel = new Label();
            CreditCardData = new TextBox();
            btnProcessOrder = new Button();
            QuantityLabel = new Label();
            Quantity = new TextBox();
            SuspendLayout();
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(155, 61);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(64, 15);
            FirstNameLabel.TabIndex = 0;
            FirstNameLabel.Text = "First Name";
            // 
            // FirstName
            // 
            FirstName.Location = new Point(155, 89);
            FirstName.Name = "FirstName";
            FirstName.PlaceholderText = "Enter your first name";
            FirstName.Size = new Size(166, 23);
            FirstName.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(439, 61);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(63, 15);
            LastNameLabel.TabIndex = 2;
            LastNameLabel.Text = "Last Name";
            // 
            // LastName
            // 
            LastName.Location = new Point(439, 89);
            LastName.Name = "LastName";
            LastName.PlaceholderText = "Enter your last name";
            LastName.Size = new Size(190, 23);
            LastName.TabIndex = 3;
            // 
            // TelephoneNumberLabel
            // 
            TelephoneNumberLabel.AutoSize = true;
            TelephoneNumberLabel.Location = new Point(155, 138);
            TelephoneNumberLabel.Name = "TelephoneNumberLabel";
            TelephoneNumberLabel.Size = new Size(108, 15);
            TelephoneNumberLabel.TabIndex = 4;
            TelephoneNumberLabel.Text = "Telephone Number";
            // 
            // TelephoneNumber
            // 
            TelephoneNumber.Location = new Point(155, 166);
            TelephoneNumber.Name = "TelephoneNumber";
            TelephoneNumber.PlaceholderText = "Enter your phone number";
            TelephoneNumber.Size = new Size(166, 23);
            TelephoneNumber.TabIndex = 5;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(439, 138);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(99, 15);
            AddressLabel.TabIndex = 6;
            AddressLabel.Text = "Shipping Address";
            // 
            // Address
            // 
            Address.Location = new Point(439, 166);
            Address.Name = "Address";
            Address.PlaceholderText = "Enter your shipping address";
            Address.Size = new Size(190, 23);
            Address.TabIndex = 7;
            // 
            // CreditCardDataLabel
            // 
            CreditCardDataLabel.AutoSize = true;
            CreditCardDataLabel.Location = new Point(439, 213);
            CreditCardDataLabel.Name = "CreditCardDataLabel";
            CreditCardDataLabel.Size = new Size(94, 15);
            CreditCardDataLabel.TabIndex = 8;
            CreditCardDataLabel.Text = "CreditCard Data ";
            // 
            // CreditCardData
            // 
            CreditCardData.Location = new Point(439, 245);
            CreditCardData.Name = "CreditCardData";
            CreditCardData.PlaceholderText = "Enter your credit card number";
            CreditCardData.Size = new Size(190, 23);
            CreditCardData.TabIndex = 9;
            // 
            // btnProcessOrder
            // 
            btnProcessOrder.BackColor = SystemColors.GradientInactiveCaption;
            btnProcessOrder.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnProcessOrder.Location = new Point(267, 332);
            btnProcessOrder.Name = "btnProcessOrder";
            btnProcessOrder.Size = new Size(198, 48);
            btnProcessOrder.TabIndex = 10;
            btnProcessOrder.Text = "Process Order";
            btnProcessOrder.UseVisualStyleBackColor = false;
            btnProcessOrder.Click += btnProcessOrder_Click;
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Location = new Point(155, 213);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(53, 15);
            QuantityLabel.TabIndex = 11;
            QuantityLabel.Text = "Quantity";
            // 
            // Quantity
            // 
            Quantity.Location = new Point(155, 245);
            Quantity.Name = "Quantity";
            Quantity.PlaceholderText = "How many computers?";
            Quantity.Size = new Size(166, 23);
            Quantity.TabIndex = 12;
            // 
            // CustomerInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Quantity);
            Controls.Add(QuantityLabel);
            Controls.Add(btnProcessOrder);
            Controls.Add(CreditCardData);
            Controls.Add(CreditCardDataLabel);
            Controls.Add(Address);
            Controls.Add(AddressLabel);
            Controls.Add(TelephoneNumber);
            Controls.Add(TelephoneNumberLabel);
            Controls.Add(LastName);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstName);
            Controls.Add(FirstNameLabel);
            Name = "CustomerInfoForm";
            Text = "CustomerInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstNameLabel;
        private TextBox FirstName;
        private Label LastNameLabel;
        private TextBox LastName;
        private Label TelephoneNumberLabel;
        private TextBox TelephoneNumber;
        private Label AddressLabel;
        private TextBox Address;
        private Label CreditCardDataLabel;
        private TextBox CreditCardData;
        private Button btnProcessOrder;
        private Label QuantityLabel;
        private TextBox Quantity;
    }
}