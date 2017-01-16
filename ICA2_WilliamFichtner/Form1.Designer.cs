namespace ICA2_WilliamFichtner
{
    partial class Form1
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
            this.UI_CostLabel = new System.Windows.Forms.Label();
            this.UI_NumberLabel = new System.Windows.Forms.Label();
            this.UI_CostBox = new System.Windows.Forms.TextBox();
            this.UI_PurchaseBox = new System.Windows.Forms.TextBox();
            this.UI_SubtotalLabel = new System.Windows.Forms.Label();
            this.UI_GSTLabel = new System.Windows.Forms.Label();
            this.UI_TotalLabel = new System.Windows.Forms.Label();
            this.UI_CalculateButton = new System.Windows.Forms.Button();
            this.UI_SubtotalAmountLabel = new System.Windows.Forms.Label();
            this.UI_GSTAmountLabel = new System.Windows.Forms.Label();
            this.UI_TotalAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_CostLabel
            // 
            this.UI_CostLabel.AutoSize = true;
            this.UI_CostLabel.Location = new System.Drawing.Point(57, 47);
            this.UI_CostLabel.Name = "UI_CostLabel";
            this.UI_CostLabel.Size = new System.Drawing.Size(31, 13);
            this.UI_CostLabel.TabIndex = 9;
            this.UI_CostLabel.Text = "Cost:";
            this.UI_CostLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // UI_NumberLabel
            // 
            this.UI_NumberLabel.AutoSize = true;
            this.UI_NumberLabel.Location = new System.Drawing.Point(57, 81);
            this.UI_NumberLabel.Name = "UI_NumberLabel";
            this.UI_NumberLabel.Size = new System.Drawing.Size(107, 13);
            this.UI_NumberLabel.TabIndex = 10;
            this.UI_NumberLabel.Text = "Number to Purchase:";
            // 
            // UI_CostBox
            // 
            this.UI_CostBox.Location = new System.Drawing.Point(200, 44);
            this.UI_CostBox.Name = "UI_CostBox";
            this.UI_CostBox.Size = new System.Drawing.Size(100, 20);
            this.UI_CostBox.TabIndex = 0;
            this.UI_CostBox.TextChanged += new System.EventHandler(this.UI_CostBox_TextChanged);
            // 
            // UI_PurchaseBox
            // 
            this.UI_PurchaseBox.Location = new System.Drawing.Point(200, 78);
            this.UI_PurchaseBox.Name = "UI_PurchaseBox";
            this.UI_PurchaseBox.Size = new System.Drawing.Size(100, 20);
            this.UI_PurchaseBox.TabIndex = 1;
            this.UI_PurchaseBox.TextChanged += new System.EventHandler(this.UI_PurchaseBox_TextChanged);
            // 
            // UI_SubtotalLabel
            // 
            this.UI_SubtotalLabel.AutoSize = true;
            this.UI_SubtotalLabel.Location = new System.Drawing.Point(57, 151);
            this.UI_SubtotalLabel.Name = "UI_SubtotalLabel";
            this.UI_SubtotalLabel.Size = new System.Drawing.Size(49, 13);
            this.UI_SubtotalLabel.TabIndex = 3;
            this.UI_SubtotalLabel.Text = "Subtotal:";
            // 
            // UI_GSTLabel
            // 
            this.UI_GSTLabel.AutoSize = true;
            this.UI_GSTLabel.Location = new System.Drawing.Point(57, 190);
            this.UI_GSTLabel.Name = "UI_GSTLabel";
            this.UI_GSTLabel.Size = new System.Drawing.Size(29, 13);
            this.UI_GSTLabel.TabIndex = 5;
            this.UI_GSTLabel.Text = "GST";
            // 
            // UI_TotalLabel
            // 
            this.UI_TotalLabel.AutoSize = true;
            this.UI_TotalLabel.Location = new System.Drawing.Point(57, 235);
            this.UI_TotalLabel.Name = "UI_TotalLabel";
            this.UI_TotalLabel.Size = new System.Drawing.Size(34, 13);
            this.UI_TotalLabel.TabIndex = 7;
            this.UI_TotalLabel.Text = "Total:";
            this.UI_TotalLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // UI_CalculateButton
            // 
            this.UI_CalculateButton.Enabled = false;
            this.UI_CalculateButton.Location = new System.Drawing.Point(157, 279);
            this.UI_CalculateButton.Name = "UI_CalculateButton";
            this.UI_CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.UI_CalculateButton.TabIndex = 2;
            this.UI_CalculateButton.Text = "Calculate";
            this.UI_CalculateButton.UseVisualStyleBackColor = true;
            this.UI_CalculateButton.Click += new System.EventHandler(this.UI_CalculateButton_Click);
            // 
            // UI_SubtotalAmountLabel
            // 
            this.UI_SubtotalAmountLabel.AutoSize = true;
            this.UI_SubtotalAmountLabel.Location = new System.Drawing.Point(197, 151);
            this.UI_SubtotalAmountLabel.Name = "UI_SubtotalAmountLabel";
            this.UI_SubtotalAmountLabel.Size = new System.Drawing.Size(34, 13);
            this.UI_SubtotalAmountLabel.TabIndex = 4;
            this.UI_SubtotalAmountLabel.Text = "$0.00";
            // 
            // UI_GSTAmountLabel
            // 
            this.UI_GSTAmountLabel.AutoSize = true;
            this.UI_GSTAmountLabel.Location = new System.Drawing.Point(197, 190);
            this.UI_GSTAmountLabel.Name = "UI_GSTAmountLabel";
            this.UI_GSTAmountLabel.Size = new System.Drawing.Size(34, 13);
            this.UI_GSTAmountLabel.TabIndex = 6;
            this.UI_GSTAmountLabel.Text = "$0.00";
            // 
            // UI_TotalAmountLabel
            // 
            this.UI_TotalAmountLabel.AutoSize = true;
            this.UI_TotalAmountLabel.Location = new System.Drawing.Point(197, 235);
            this.UI_TotalAmountLabel.Name = "UI_TotalAmountLabel";
            this.UI_TotalAmountLabel.Size = new System.Drawing.Size(34, 13);
            this.UI_TotalAmountLabel.TabIndex = 8;
            this.UI_TotalAmountLabel.Text = "$0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 339);
            this.Controls.Add(this.UI_TotalAmountLabel);
            this.Controls.Add(this.UI_GSTAmountLabel);
            this.Controls.Add(this.UI_SubtotalAmountLabel);
            this.Controls.Add(this.UI_CalculateButton);
            this.Controls.Add(this.UI_TotalLabel);
            this.Controls.Add(this.UI_GSTLabel);
            this.Controls.Add(this.UI_SubtotalLabel);
            this.Controls.Add(this.UI_PurchaseBox);
            this.Controls.Add(this.UI_CostBox);
            this.Controls.Add(this.UI_NumberLabel);
            this.Controls.Add(this.UI_CostLabel);
            this.Name = "Form1";
            this.Text = "ICA02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_CostLabel;
        private System.Windows.Forms.Label UI_NumberLabel;
        private System.Windows.Forms.TextBox UI_CostBox;
        private System.Windows.Forms.TextBox UI_PurchaseBox;
        private System.Windows.Forms.Label UI_SubtotalLabel;
        private System.Windows.Forms.Label UI_GSTLabel;
        private System.Windows.Forms.Label UI_TotalLabel;
        private System.Windows.Forms.Button UI_CalculateButton;
        private System.Windows.Forms.Label UI_SubtotalAmountLabel;
        private System.Windows.Forms.Label UI_GSTAmountLabel;
        private System.Windows.Forms.Label UI_TotalAmountLabel;
    }
}

