namespace ComputerStore
{
    partial class MainForm
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
            searchBox = new TextBox();
            dataGridViewProducts = new DataGridView();
            btnViewDetails = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.Location = new Point(212, 49);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search for computer by model or name";
            searchBox.Size = new Size(337, 23);
            searchBox.TabIndex = 0;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(62, 87);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowTemplate.Height = 25;
            dataGridViewProducts.Size = new Size(650, 246);
            dataGridViewProducts.TabIndex = 1;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = SystemColors.GradientInactiveCaption;
            btnViewDetails.Font = new Font("Nunito", 8.999998F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewDetails.Location = new Point(252, 351);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(239, 50);
            btnViewDetails.TabIndex = 2;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewDetails);
            Controls.Add(dataGridViewProducts);
            Controls.Add(searchBox);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchBox;
        private DataGridView dataGridViewProducts;
        private Button btnViewDetails;
    }
}