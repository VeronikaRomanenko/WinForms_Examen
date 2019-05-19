namespace WinForms_Examen
{
    partial class SpisokProektov
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
            this.lsbProekti = new System.Windows.Forms.ListBox();
            this.clbDela = new System.Windows.Forms.CheckedListBox();
            this.lsbSvojstva = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsbProekti
            // 
            this.lsbProekti.FormattingEnabled = true;
            this.lsbProekti.Location = new System.Drawing.Point(13, 13);
            this.lsbProekti.Name = "lsbProekti";
            this.lsbProekti.Size = new System.Drawing.Size(259, 95);
            this.lsbProekti.TabIndex = 0;
            this.lsbProekti.SelectedIndexChanged += new System.EventHandler(this.lsbProekti_SelectedIndexChanged);
            this.lsbProekti.DoubleClick += new System.EventHandler(this.lsbProekti_DoubleClick);
            // 
            // clbDela
            // 
            this.clbDela.FormattingEnabled = true;
            this.clbDela.Location = new System.Drawing.Point(13, 115);
            this.clbDela.Name = "clbDela";
            this.clbDela.Size = new System.Drawing.Size(259, 94);
            this.clbDela.TabIndex = 1;
            this.clbDela.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbDela_ItemCheck);
            this.clbDela.SelectedIndexChanged += new System.EventHandler(this.clbDela_SelectedIndexChanged);
            this.clbDela.DoubleClick += new System.EventHandler(this.clbDela_DoubleClick);
            // 
            // lsbSvojstva
            // 
            this.lsbSvojstva.FormattingEnabled = true;
            this.lsbSvojstva.Location = new System.Drawing.Point(12, 215);
            this.lsbSvojstva.Name = "lsbSvojstva";
            this.lsbSvojstva.Size = new System.Drawing.Size(259, 95);
            this.lsbSvojstva.TabIndex = 2;
            // 
            // SpisokProektov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 322);
            this.Controls.Add(this.lsbSvojstva);
            this.Controls.Add(this.clbDela);
            this.Controls.Add(this.lsbProekti);
            this.Name = "SpisokProektov";
            this.Text = "SpisokProektov";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbProekti;
        private System.Windows.Forms.CheckedListBox clbDela;
        private System.Windows.Forms.ListBox lsbSvojstva;
    }
}