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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.redactToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // SpisokProektov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 322);
            this.Controls.Add(this.lsbSvojstva);
            this.Controls.Add(this.clbDela);
            this.Controls.Add(this.lsbProekti);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SpisokProektov";
            this.Text = "SpisokProektov";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbProekti;
        private System.Windows.Forms.CheckedListBox clbDela;
        private System.Windows.Forms.ListBox lsbSvojstva;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}