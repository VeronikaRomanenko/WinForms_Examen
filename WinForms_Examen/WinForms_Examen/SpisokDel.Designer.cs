namespace WinForms_Examen
{
    partial class SpisokDel
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.rdbDen = new System.Windows.Forms.RadioButton();
            this.rdbNedela = new System.Windows.Forms.RadioButton();
            this.rdbMesaz = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 55);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(259, 124);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            this.checkedListBox1.DoubleClick += new System.EventHandler(this.checkedListBox1_DoubleClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 185);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 108);
            this.listBox1.TabIndex = 1;
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Checked = true;
            this.rdbAll.Location = new System.Drawing.Point(42, 7);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(44, 17);
            this.rdbAll.TabIndex = 2;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "Все";
            this.rdbAll.UseVisualStyleBackColor = true;
            this.rdbAll.CheckedChanged += new System.EventHandler(this.rdbAll_CheckedChanged);
            // 
            // rdbDen
            // 
            this.rdbDen.AutoSize = true;
            this.rdbDen.Location = new System.Drawing.Point(161, 7);
            this.rdbDen.Name = "rdbDen";
            this.rdbDen.Size = new System.Drawing.Size(66, 17);
            this.rdbDen.TabIndex = 3;
            this.rdbDen.Text = "На день";
            this.rdbDen.UseVisualStyleBackColor = true;
            this.rdbDen.CheckedChanged += new System.EventHandler(this.rdbDen_CheckedChanged);
            // 
            // rdbNedela
            // 
            this.rdbNedela.AutoSize = true;
            this.rdbNedela.Location = new System.Drawing.Point(42, 30);
            this.rdbNedela.Name = "rdbNedela";
            this.rdbNedela.Size = new System.Drawing.Size(80, 17);
            this.rdbNedela.TabIndex = 4;
            this.rdbNedela.Text = "На неделю";
            this.rdbNedela.UseVisualStyleBackColor = true;
            this.rdbNedela.CheckedChanged += new System.EventHandler(this.rdbNedela_CheckedChanged);
            // 
            // rdbMesaz
            // 
            this.rdbMesaz.AutoSize = true;
            this.rdbMesaz.Location = new System.Drawing.Point(161, 30);
            this.rdbMesaz.Name = "rdbMesaz";
            this.rdbMesaz.Size = new System.Drawing.Size(74, 17);
            this.rdbMesaz.TabIndex = 5;
            this.rdbMesaz.Text = "На месяц";
            this.rdbMesaz.UseVisualStyleBackColor = true;
            this.rdbMesaz.CheckedChanged += new System.EventHandler(this.rdbMesaz_CheckedChanged);
            // 
            // SpisokDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 305);
            this.Controls.Add(this.rdbMesaz);
            this.Controls.Add(this.rdbNedela);
            this.Controls.Add(this.rdbDen);
            this.Controls.Add(this.rdbAll);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "SpisokDel";
            this.Text = "SpisokDel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.RadioButton rdbDen;
        private System.Windows.Forms.RadioButton rdbNedela;
        private System.Windows.Forms.RadioButton rdbMesaz;
    }
}