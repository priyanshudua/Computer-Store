namespace ComputerStore
{
    partial class ProductInfoForm
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
            ComputerTypeLabel = new Label();
            ModelLabel = new Label();
            ComputerType = new TextBox();
            Model = new TextBox();
            QuantityOnStockLabel = new Label();
            QuantityOnStock = new TextBox();
            QuantitySoldLabel = new Label();
            QuantitySold = new TextBox();
            PriceLabel = new Label();
            Price = new TextBox();
            CPUSpeedLabel = new Label();
            CPUSpeed = new TextBox();
            RAMCapacityLabel = new Label();
            RAMCapacity = new TextBox();
            HDCapacityLabel = new Label();
            HDCapacity = new TextBox();
            pictureBoxProduct = new PictureBox();
            btnPurchase = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            SuspendLayout();
            // 
            // ComputerTypeLabel
            // 
            ComputerTypeLabel.AutoSize = true;
            ComputerTypeLabel.Location = new Point(51, 38);
            ComputerTypeLabel.Name = "ComputerTypeLabel";
            ComputerTypeLabel.Size = new Size(94, 15);
            ComputerTypeLabel.TabIndex = 0;
            ComputerTypeLabel.Text = "Computer Type :";
            // 
            // ModelLabel
            // 
            ModelLabel.AutoSize = true;
            ModelLabel.Location = new Point(51, 72);
            ModelLabel.Name = "ModelLabel";
            ModelLabel.Size = new Size(47, 15);
            ModelLabel.TabIndex = 1;
            ModelLabel.Text = "Model :";
            // 
            // ComputerType
            // 
            ComputerType.Location = new Point(167, 30);
            ComputerType.Name = "ComputerType";
            ComputerType.Size = new Size(175, 23);
            ComputerType.TabIndex = 2;
            // 
            // Model
            // 
            Model.Location = new Point(167, 64);
            Model.Name = "Model";
            Model.Size = new Size(175, 23);
            Model.TabIndex = 3;
            // 
            // QuantityOnStockLabel
            // 
            QuantityOnStockLabel.AutoSize = true;
            QuantityOnStockLabel.Location = new Point(51, 108);
            QuantityOnStockLabel.Name = "QuantityOnStockLabel";
            QuantityOnStockLabel.Size = new Size(104, 15);
            QuantityOnStockLabel.TabIndex = 4;
            QuantityOnStockLabel.Text = "Quantity In Stock :";
            // 
            // QuantityOnStock
            // 
            QuantityOnStock.Location = new Point(167, 100);
            QuantityOnStock.Name = "QuantityOnStock";
            QuantityOnStock.Size = new Size(175, 23);
            QuantityOnStock.TabIndex = 5;
            // 
            // QuantitySoldLabel
            // 
            QuantitySoldLabel.AutoSize = true;
            QuantitySoldLabel.Location = new Point(51, 142);
            QuantitySoldLabel.Name = "QuantitySoldLabel";
            QuantitySoldLabel.Size = new Size(85, 15);
            QuantitySoldLabel.TabIndex = 6;
            QuantitySoldLabel.Text = "Quantity Sold :";
            // 
            // QuantitySold
            // 
            QuantitySold.Location = new Point(167, 134);
            QuantitySold.Name = "QuantitySold";
            QuantitySold.Size = new Size(175, 23);
            QuantitySold.TabIndex = 7;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(51, 177);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(39, 15);
            PriceLabel.TabIndex = 8;
            PriceLabel.Text = "Price :";
            // 
            // Price
            // 
            Price.Location = new Point(167, 169);
            Price.Name = "Price";
            Price.Size = new Size(175, 23);
            Price.TabIndex = 9;
            // 
            // CPUSpeedLabel
            // 
            CPUSpeedLabel.AutoSize = true;
            CPUSpeedLabel.Location = new Point(51, 210);
            CPUSpeedLabel.Name = "CPUSpeedLabel";
            CPUSpeedLabel.Size = new Size(71, 15);
            CPUSpeedLabel.TabIndex = 10;
            CPUSpeedLabel.Text = "CPU Speed :";
            // 
            // CPUSpeed
            // 
            CPUSpeed.Location = new Point(167, 202);
            CPUSpeed.Name = "CPUSpeed";
            CPUSpeed.Size = new Size(175, 23);
            CPUSpeed.TabIndex = 11;
            // 
            // RAMCapacityLabel
            // 
            RAMCapacityLabel.AutoSize = true;
            RAMCapacityLabel.Location = new Point(51, 244);
            RAMCapacityLabel.Name = "RAMCapacityLabel";
            RAMCapacityLabel.Size = new Size(88, 15);
            RAMCapacityLabel.TabIndex = 12;
            RAMCapacityLabel.Text = "RAM Capacity :";
            // 
            // RAMCapacity
            // 
            RAMCapacity.Location = new Point(167, 236);
            RAMCapacity.Name = "RAMCapacity";
            RAMCapacity.Size = new Size(175, 23);
            RAMCapacity.TabIndex = 13;
            // 
            // HDCapacityLabel
            // 
            HDCapacityLabel.AutoSize = true;
            HDCapacityLabel.Location = new Point(51, 282);
            HDCapacityLabel.Name = "HDCapacityLabel";
            HDCapacityLabel.Size = new Size(79, 15);
            HDCapacityLabel.TabIndex = 14;
            HDCapacityLabel.Text = "HD Capacity :";
            // 
            // HDCapacity
            // 
            HDCapacity.Location = new Point(167, 274);
            HDCapacity.Name = "HDCapacity";
            HDCapacity.Size = new Size(175, 23);
            HDCapacity.TabIndex = 15;
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.Location = new Point(389, 30);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(350, 267);
            pictureBoxProduct.TabIndex = 16;
            pictureBoxProduct.TabStop = false;
            // 
            // btnPurchase
            // 
            btnPurchase.BackColor = SystemColors.GradientActiveCaption;
            btnPurchase.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPurchase.Location = new Point(280, 348);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(183, 50);
            btnPurchase.TabIndex = 17;
            btnPurchase.Text = "Purchase Item";
            btnPurchase.UseVisualStyleBackColor = false;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // ProductInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPurchase);
            Controls.Add(pictureBoxProduct);
            Controls.Add(HDCapacity);
            Controls.Add(HDCapacityLabel);
            Controls.Add(RAMCapacity);
            Controls.Add(RAMCapacityLabel);
            Controls.Add(CPUSpeed);
            Controls.Add(CPUSpeedLabel);
            Controls.Add(Price);
            Controls.Add(PriceLabel);
            Controls.Add(QuantitySold);
            Controls.Add(QuantitySoldLabel);
            Controls.Add(QuantityOnStock);
            Controls.Add(QuantityOnStockLabel);
            Controls.Add(Model);
            Controls.Add(ComputerType);
            Controls.Add(ModelLabel);
            Controls.Add(ComputerTypeLabel);
            Name = "ProductInfoForm";
            Text = "ProductInfoForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ComputerTypeLabel;
        private Label ModelLabel;
        private TextBox ComputerType;
        private TextBox Model;
        private Label QuantityOnStockLabel;
        private TextBox QuantityOnStock;
        private Label QuantitySoldLabel;
        private TextBox QuantitySold;
        private Label PriceLabel;
        private TextBox Price;
        private Label CPUSpeedLabel;
        private TextBox CPUSpeed;
        private Label RAMCapacityLabel;
        private TextBox RAMCapacity;
        private Label HDCapacityLabel;
        private TextBox HDCapacity;
        private PictureBox pictureBoxProduct;
        private Button btnPurchase;
    }
}