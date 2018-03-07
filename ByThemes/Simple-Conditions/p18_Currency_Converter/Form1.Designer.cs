namespace p18_Currency_Converter
{
    partial class FormConverter
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
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCrrncy = new System.Windows.Forms.ComboBox();
            this.labelBGN = new System.Windows.Forms.Label();
            this.labelArrow = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.DecimalPlaces = 2;
            this.numericUpDownAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownAmount.Location = new System.Drawing.Point(50, 89);
            this.numericUpDownAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(270, 30);
            this.numericUpDownAmount.TabIndex = 0;
            this.numericUpDownAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.ValueChanged += new System.EventHandler(this.numericUpDownAmount_ValueChanged);
            // 
            // comboBoxCrrncy
            // 
            this.comboBoxCrrncy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCrrncy.FormattingEnabled = true;
            this.comboBoxCrrncy.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.comboBoxCrrncy.Location = new System.Drawing.Point(662, 89);
            this.comboBoxCrrncy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCrrncy.Name = "comboBoxCrrncy";
            this.comboBoxCrrncy.Size = new System.Drawing.Size(180, 33);
            this.comboBoxCrrncy.TabIndex = 1;
            this.comboBoxCrrncy.SelectedIndexChanged += new System.EventHandler(this.comboBoxCrrncy_SelectedIndexChanged);
            // 
            // labelBGN
            // 
            this.labelBGN.AutoSize = true;
            this.labelBGN.Location = new System.Drawing.Point(360, 98);
            this.labelBGN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBGN.Name = "labelBGN";
            this.labelBGN.Size = new System.Drawing.Size(54, 25);
            this.labelBGN.TabIndex = 2;
            this.labelBGN.Text = "BGN";
            // 
            // labelArrow
            // 
            this.labelArrow.AutoSize = true;
            this.labelArrow.Location = new System.Drawing.Point(513, 102);
            this.labelArrow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelArrow.Name = "labelArrow";
            this.labelArrow.Size = new System.Drawing.Size(31, 25);
            this.labelArrow.TabIndex = 3;
            this.labelArrow.Text = "->";
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(45, 233);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(798, 89);
            this.labelResult.TabIndex = 4;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelResult.Click += new System.EventHandler(this.labelResult_Click);
            // 
            // FormConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 395);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelArrow);
            this.Controls.Add(this.labelBGN);
            this.Controls.Add(this.comboBoxCrrncy);
            this.Controls.Add(this.numericUpDownAmount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConverter";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.FormConverter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.ComboBox comboBoxCrrncy;
        private System.Windows.Forms.Label labelBGN;
        private System.Windows.Forms.Label labelArrow;
        private System.Windows.Forms.Label labelResult;
    }
}

