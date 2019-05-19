namespace WinForms_Examen
{
    partial class Poisk
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
            this.txbPoisk = new System.Windows.Forms.TextBox();
            this.btnPoisk = new System.Windows.Forms.Button();
            this.rdbPoName = new System.Windows.Forms.RadioButton();
            this.rdbPoTeg = new System.Windows.Forms.RadioButton();
            this.rdbPoPrioritet = new System.Windows.Forms.RadioButton();
            this.clbDela = new System.Windows.Forms.CheckedListBox();
            this.lsbProekti = new System.Windows.Forms.ListBox();
            this.lsbSvojstva = new System.Windows.Forms.ListBox();
            this.cmbPrioritet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txbPoisk
            // 
            this.txbPoisk.Location = new System.Drawing.Point(13, 13);
            this.txbPoisk.Name = "txbPoisk";
            this.txbPoisk.Size = new System.Drawing.Size(284, 20);
            this.txbPoisk.TabIndex = 0;
            // 
            // btnPoisk
            // 
            this.btnPoisk.Location = new System.Drawing.Point(85, 83);
            this.btnPoisk.Name = "btnPoisk";
            this.btnPoisk.Size = new System.Drawing.Size(124, 54);
            this.btnPoisk.TabIndex = 1;
            this.btnPoisk.Text = "Поиск";
            this.btnPoisk.UseVisualStyleBackColor = true;
            this.btnPoisk.Click += new System.EventHandler(this.btnPoisk_Click);
            // 
            // rdbPoName
            // 
            this.rdbPoName.AutoSize = true;
            this.rdbPoName.Location = new System.Drawing.Point(13, 42);
            this.rdbPoName.Name = "rdbPoName";
            this.rdbPoName.Size = new System.Drawing.Size(92, 17);
            this.rdbPoName.TabIndex = 3;
            this.rdbPoName.TabStop = true;
            this.rdbPoName.Text = "По названию";
            this.rdbPoName.UseVisualStyleBackColor = true;
            // 
            // rdbPoTeg
            // 
            this.rdbPoTeg.AutoSize = true;
            this.rdbPoTeg.Location = new System.Drawing.Point(112, 42);
            this.rdbPoTeg.Name = "rdbPoTeg";
            this.rdbPoTeg.Size = new System.Drawing.Size(72, 17);
            this.rdbPoTeg.TabIndex = 4;
            this.rdbPoTeg.TabStop = true;
            this.rdbPoTeg.Text = "По тегам";
            this.rdbPoTeg.UseVisualStyleBackColor = true;
            // 
            // rdbPoPrioritet
            // 
            this.rdbPoPrioritet.AutoSize = true;
            this.rdbPoPrioritet.Location = new System.Drawing.Point(198, 42);
            this.rdbPoPrioritet.Name = "rdbPoPrioritet";
            this.rdbPoPrioritet.Size = new System.Drawing.Size(99, 17);
            this.rdbPoPrioritet.TabIndex = 5;
            this.rdbPoPrioritet.TabStop = true;
            this.rdbPoPrioritet.Text = "По приоритету";
            this.rdbPoPrioritet.UseVisualStyleBackColor = true;
            this.rdbPoPrioritet.CheckedChanged += new System.EventHandler(this.rdbPoPrioritet_CheckedChanged);
            // 
            // clbDela
            // 
            this.clbDela.FormattingEnabled = true;
            this.clbDela.Location = new System.Drawing.Point(12, 271);
            this.clbDela.Name = "clbDela";
            this.clbDela.Size = new System.Drawing.Size(284, 109);
            this.clbDela.TabIndex = 6;
            this.clbDela.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbDela_ItemCheck);
            this.clbDela.SelectedIndexChanged += new System.EventHandler(this.clbDela_SelectedIndexChanged);
            this.clbDela.DoubleClick += new System.EventHandler(this.clbDela_DoubleClick);
            // 
            // lsbProekti
            // 
            this.lsbProekti.FormattingEnabled = true;
            this.lsbProekti.Location = new System.Drawing.Point(13, 157);
            this.lsbProekti.Name = "lsbProekti";
            this.lsbProekti.Size = new System.Drawing.Size(284, 108);
            this.lsbProekti.TabIndex = 7;
            this.lsbProekti.SelectedIndexChanged += new System.EventHandler(this.lsbProekti_SelectedIndexChanged);
            this.lsbProekti.DoubleClick += new System.EventHandler(this.lsbProekti_DoubleClick);
            // 
            // lsbSvojstva
            // 
            this.lsbSvojstva.FormattingEnabled = true;
            this.lsbSvojstva.Location = new System.Drawing.Point(13, 386);
            this.lsbSvojstva.Name = "lsbSvojstva";
            this.lsbSvojstva.Size = new System.Drawing.Size(284, 108);
            this.lsbSvojstva.TabIndex = 8;
            // 
            // cmbPrioritet
            // 
            this.cmbPrioritet.FormattingEnabled = true;
            this.cmbPrioritet.Location = new System.Drawing.Point(13, 13);
            this.cmbPrioritet.Name = "cmbPrioritet";
            this.cmbPrioritet.Size = new System.Drawing.Size(283, 21);
            this.cmbPrioritet.TabIndex = 9;
            // 
            // Poisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 504);
            this.Controls.Add(this.cmbPrioritet);
            this.Controls.Add(this.lsbSvojstva);
            this.Controls.Add(this.lsbProekti);
            this.Controls.Add(this.clbDela);
            this.Controls.Add(this.rdbPoPrioritet);
            this.Controls.Add(this.rdbPoTeg);
            this.Controls.Add(this.rdbPoName);
            this.Controls.Add(this.btnPoisk);
            this.Controls.Add(this.txbPoisk);
            this.Name = "Poisk";
            this.Text = "Poisk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPoisk;
        private System.Windows.Forms.Button btnPoisk;
        private System.Windows.Forms.RadioButton rdbPoName;
        private System.Windows.Forms.RadioButton rdbPoTeg;
        private System.Windows.Forms.RadioButton rdbPoPrioritet;
        private System.Windows.Forms.CheckedListBox clbDela;
        private System.Windows.Forms.ListBox lsbProekti;
        private System.Windows.Forms.ListBox lsbSvojstva;
        private System.Windows.Forms.ComboBox cmbPrioritet;
    }
}