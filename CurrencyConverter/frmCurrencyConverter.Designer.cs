namespace JSONDemoBCL
{
    partial class frmCurrencyConverter
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmtToConvert = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblConvertedAmount = new System.Windows.Forms.Label();
            this.lblExchangeRate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ratesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keyListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ratesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Amount in US $ to Convert:";
            // 
            // txtAmtToConvert
            // 
            this.txtAmtToConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmtToConvert.Location = new System.Drawing.Point(526, 38);
            this.txtAmtToConvert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmtToConvert.Name = "txtAmtToConvert";
            this.txtAmtToConvert.Size = new System.Drawing.Size(245, 30);
            this.txtAmtToConvert.TabIndex = 1;
            this.txtAmtToConvert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please Select the Foreign Currency to Convert To:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount in Selected Foreign Currency:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(866, 356);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(866, 413);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 31);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblConvertedAmount
            // 
            this.lblConvertedAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConvertedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertedAmount.Location = new System.Drawing.Point(537, 413);
            this.lblConvertedAmount.Name = "lblConvertedAmount";
            this.lblConvertedAmount.Size = new System.Drawing.Size(244, 25);
            this.lblConvertedAmount.TabIndex = 7;
            this.lblConvertedAmount.Text = "ConvertedAmount";
            this.lblConvertedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExchangeRate
            // 
            this.lblExchangeRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExchangeRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExchangeRate.Location = new System.Drawing.Point(537, 358);
            this.lblExchangeRate.Name = "lblExchangeRate";
            this.lblExchangeRate.Size = new System.Drawing.Size(244, 25);
            this.lblExchangeRate.TabIndex = 9;
            this.lblExchangeRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(410, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Exchange Rate for Selected Foreign Currency";
            // 
            // ratesBindingSource
            // 
            this.ratesBindingSource.DataSource = typeof(System.Collections.Generic.KeyValuePair<string, double>);
            // 
            // keyListBox
            // 
            this.keyListBox.DataSource = this.ratesBindingSource;
            this.keyListBox.DisplayMember = "Key";
            this.keyListBox.FormattingEnabled = true;
            this.keyListBox.ItemHeight = 16;
            this.keyListBox.Location = new System.Drawing.Point(526, 83);
            this.keyListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keyListBox.Name = "keyListBox";
            this.keyListBox.Size = new System.Drawing.Size(245, 244);
            this.keyListBox.TabIndex = 12;
            this.keyListBox.ValueMember = "Value";
            this.keyListBox.SelectedIndexChanged += new System.EventHandler(this.keyListBox_SelectedIndexChanged);
            // 
            // frmCurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 510);
            this.Controls.Add(this.keyListBox);
            this.Controls.Add(this.lblExchangeRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblConvertedAmount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmtToConvert);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCurrencyConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCurrencyConverter";
            this.Load += new System.EventHandler(this.frmCurrencyConverter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ratesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmtToConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblConvertedAmount;
        private System.Windows.Forms.Label lblExchangeRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource ratesBindingSource;
        private System.Windows.Forms.ListBox keyListBox;
    }
}

