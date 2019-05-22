namespace WinForms_Examen
{
    partial class Redactor
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDedline = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSpisokDel = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.chbAddFile = new System.Windows.Forms.CheckBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbOpisanie = new System.Windows.Forms.TextBox();
            this.cmbPrioritet = new System.Windows.Forms.ComboBox();
            this.lsbTegi = new System.Windows.Forms.ListBox();
            this.btnAddTeg = new System.Windows.Forms.Button();
            this.txbTeg = new System.Windows.Forms.TextBox();
            this.chbAddDedline = new System.Windows.Forms.CheckBox();
            this.dtpDedline = new System.Windows.Forms.DateTimePicker();
            this.txbFile = new System.Windows.Forms.TextBox();
            this.lsbSpisokDel = new System.Windows.Forms.ListBox();
            this.btnAddDelo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.redactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Location = new System.Drawing.Point(0, 493);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(513, 50);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание";
            // 
            // lblDedline
            // 
            this.lblDedline.AutoSize = true;
            this.lblDedline.Location = new System.Drawing.Point(86, 247);
            this.lblDedline.Name = "lblDedline";
            this.lblDedline.Size = new System.Drawing.Size(52, 13);
            this.lblDedline.TabIndex = 4;
            this.lblDedline.Text = "Дедлайн";
            this.lblDedline.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Приоритет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Теги";
            // 
            // lblSpisokDel
            // 
            this.lblSpisokDel.AutoSize = true;
            this.lblSpisokDel.Location = new System.Drawing.Point(12, 328);
            this.lblSpisokDel.Name = "lblSpisokDel";
            this.lblSpisokDel.Size = new System.Drawing.Size(65, 13);
            this.lblSpisokDel.TabIndex = 7;
            this.lblSpisokDel.Text = "Список дел";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(86, 294);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(74, 13);
            this.lblFile.TabIndex = 6;
            this.lblFile.Text = "Путь к файлу";
            this.lblFile.Visible = false;
            // 
            // chbAddFile
            // 
            this.chbAddFile.AutoSize = true;
            this.chbAddFile.Location = new System.Drawing.Point(15, 271);
            this.chbAddFile.Name = "chbAddFile";
            this.chbAddFile.Size = new System.Drawing.Size(116, 17);
            this.chbAddFile.TabIndex = 8;
            this.chbAddFile.Text = "Прикрепить файл";
            this.chbAddFile.UseVisualStyleBackColor = true;
            this.chbAddFile.CheckedChanged += new System.EventHandler(this.chbAddFile_CheckedChanged);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(89, 29);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(412, 20);
            this.txbName.TabIndex = 9;
            // 
            // txbOpisanie
            // 
            this.txbOpisanie.Location = new System.Drawing.Point(89, 59);
            this.txbOpisanie.Multiline = true;
            this.txbOpisanie.Name = "txbOpisanie";
            this.txbOpisanie.Size = new System.Drawing.Size(412, 46);
            this.txbOpisanie.TabIndex = 10;
            // 
            // cmbPrioritet
            // 
            this.cmbPrioritet.FormattingEnabled = true;
            this.cmbPrioritet.Location = new System.Drawing.Point(89, 114);
            this.cmbPrioritet.Name = "cmbPrioritet";
            this.cmbPrioritet.Size = new System.Drawing.Size(134, 21);
            this.cmbPrioritet.TabIndex = 11;
            // 
            // lsbTegi
            // 
            this.lsbTegi.FormattingEnabled = true;
            this.lsbTegi.Location = new System.Drawing.Point(89, 147);
            this.lsbTegi.Name = "lsbTegi";
            this.lsbTegi.Size = new System.Drawing.Size(199, 69);
            this.lsbTegi.TabIndex = 12;
            this.lsbTegi.SelectedIndexChanged += new System.EventHandler(this.lsbTegi_SelectedIndexChanged);
            // 
            // btnAddTeg
            // 
            this.btnAddTeg.Location = new System.Drawing.Point(294, 181);
            this.btnAddTeg.Name = "btnAddTeg";
            this.btnAddTeg.Size = new System.Drawing.Size(207, 35);
            this.btnAddTeg.TabIndex = 13;
            this.btnAddTeg.Text = "Добавить тег";
            this.btnAddTeg.UseVisualStyleBackColor = true;
            this.btnAddTeg.Click += new System.EventHandler(this.btnAddTeg_Click);
            // 
            // txbTeg
            // 
            this.txbTeg.Location = new System.Drawing.Point(294, 155);
            this.txbTeg.Name = "txbTeg";
            this.txbTeg.Size = new System.Drawing.Size(207, 20);
            this.txbTeg.TabIndex = 14;
            // 
            // chbAddDedline
            // 
            this.chbAddDedline.AutoSize = true;
            this.chbAddDedline.Location = new System.Drawing.Point(15, 224);
            this.chbAddDedline.Name = "chbAddDedline";
            this.chbAddDedline.Size = new System.Drawing.Size(121, 17);
            this.chbAddDedline.TabIndex = 15;
            this.chbAddDedline.Text = "Добавить дедлайн";
            this.chbAddDedline.UseVisualStyleBackColor = true;
            this.chbAddDedline.CheckedChanged += new System.EventHandler(this.chbAddDedline_CheckedChanged);
            // 
            // dtpDedline
            // 
            this.dtpDedline.CustomFormat = "dd MMMM yyyy,   HH:mm";
            this.dtpDedline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDedline.Location = new System.Drawing.Point(150, 241);
            this.dtpDedline.Name = "dtpDedline";
            this.dtpDedline.Size = new System.Drawing.Size(166, 20);
            this.dtpDedline.TabIndex = 16;
            this.dtpDedline.Visible = false;
            // 
            // txbFile
            // 
            this.txbFile.Location = new System.Drawing.Point(166, 291);
            this.txbFile.Name = "txbFile";
            this.txbFile.Size = new System.Drawing.Size(335, 20);
            this.txbFile.TabIndex = 17;
            this.txbFile.Visible = false;
            // 
            // lsbSpisokDel
            // 
            this.lsbSpisokDel.FormattingEnabled = true;
            this.lsbSpisokDel.Location = new System.Drawing.Point(89, 328);
            this.lsbSpisokDel.Name = "lsbSpisokDel";
            this.lsbSpisokDel.Size = new System.Drawing.Size(245, 147);
            this.lsbSpisokDel.TabIndex = 18;
            this.lsbSpisokDel.SelectedIndexChanged += new System.EventHandler(this.lsbSpisokDel_SelectedIndexChanged);
            this.lsbSpisokDel.DragDrop += new System.Windows.Forms.DragEventHandler(this.lsbSpisokDel_DragDrop);
            this.lsbSpisokDel.DragEnter += new System.Windows.Forms.DragEventHandler(this.lsbSpisokDel_DragEnter);
            this.lsbSpisokDel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lsbSpisokDel_MouseDown);
            // 
            // btnAddDelo
            // 
            this.btnAddDelo.Location = new System.Drawing.Point(340, 351);
            this.btnAddDelo.Name = "btnAddDelo";
            this.btnAddDelo.Size = new System.Drawing.Size(161, 76);
            this.btnAddDelo.TabIndex = 19;
            this.btnAddDelo.Text = "Добавить дело";
            this.btnAddDelo.UseVisualStyleBackColor = true;
            this.btnAddDelo.Click += new System.EventHandler(this.btnAddDelo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redactToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // redactToolStripMenuItem
            // 
            this.redactToolStripMenuItem.Name = "redactToolStripMenuItem";
            this.redactToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.redactToolStripMenuItem.Text = "&Редактировать";
            this.redactToolStripMenuItem.Click += new System.EventHandler(this.redactToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.deleteToolStripMenuItem.Text = "&Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Redactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 543);
            this.Controls.Add(this.btnAddDelo);
            this.Controls.Add(this.lsbSpisokDel);
            this.Controls.Add(this.txbFile);
            this.Controls.Add(this.dtpDedline);
            this.Controls.Add(this.chbAddDedline);
            this.Controls.Add(this.txbTeg);
            this.Controls.Add(this.btnAddTeg);
            this.Controls.Add(this.lsbTegi);
            this.Controls.Add(this.cmbPrioritet);
            this.Controls.Add(this.txbOpisanie);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.chbAddFile);
            this.Controls.Add(this.lblSpisokDel);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDedline);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Redactor";
            this.Text = "Redactor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDedline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSpisokDel;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.CheckBox chbAddFile;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbOpisanie;
        private System.Windows.Forms.ComboBox cmbPrioritet;
        private System.Windows.Forms.ListBox lsbTegi;
        private System.Windows.Forms.Button btnAddTeg;
        private System.Windows.Forms.TextBox txbTeg;
        private System.Windows.Forms.CheckBox chbAddDedline;
        private System.Windows.Forms.DateTimePicker dtpDedline;
        private System.Windows.Forms.TextBox txbFile;
        private System.Windows.Forms.ListBox lsbSpisokDel;
        private System.Windows.Forms.Button btnAddDelo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem redactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}