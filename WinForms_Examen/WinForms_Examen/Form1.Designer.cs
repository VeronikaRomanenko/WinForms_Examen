namespace WinForms_Examen
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.делоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спискиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.делToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проектовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.делToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.проектовToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.спискиToolStripMenuItem,
            this.поискToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1153, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.делоToolStripMenuItem,
            this.проектToolStripMenuItem});
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.создатьToolStripMenuItem.Text = "&Создать";
            // 
            // делоToolStripMenuItem
            // 
            this.делоToolStripMenuItem.Name = "делоToolStripMenuItem";
            this.делоToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.делоToolStripMenuItem.Text = "&Дело";
            this.делоToolStripMenuItem.Click += new System.EventHandler(this.newDeloToolStripMenuItem_Click);
            // 
            // проектToolStripMenuItem
            // 
            this.проектToolStripMenuItem.Name = "проектToolStripMenuItem";
            this.проектToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.проектToolStripMenuItem.Text = "&Проект";
            this.проектToolStripMenuItem.Click += new System.EventHandler(this.newProektToolStripMenuItem_Click);
            // 
            // спискиToolStripMenuItem
            // 
            this.спискиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.делToolStripMenuItem,
            this.проектовToolStripMenuItem});
            this.спискиToolStripMenuItem.Name = "спискиToolStripMenuItem";
            this.спискиToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.спискиToolStripMenuItem.Text = "Сп&иски";
            // 
            // делToolStripMenuItem
            // 
            this.делToolStripMenuItem.Name = "делToolStripMenuItem";
            this.делToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.делToolStripMenuItem.Text = "&Дел";
            this.делToolStripMenuItem.Click += new System.EventHandler(this.spisokDelToolStripMenuItem_Click);
            // 
            // проектовToolStripMenuItem
            // 
            this.проектовToolStripMenuItem.Name = "проектовToolStripMenuItem";
            this.проектовToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.проектовToolStripMenuItem.Text = "&Проектов";
            this.проектовToolStripMenuItem.Click += new System.EventHandler(this.spisokProektovToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.делToolStripMenuItem1,
            this.проектовToolStripMenuItem1});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "&Поиск";
            // 
            // делToolStripMenuItem1
            // 
            this.делToolStripMenuItem1.Name = "делToolStripMenuItem1";
            this.делToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.делToolStripMenuItem1.Text = "&Дел";
            this.делToolStripMenuItem1.Click += new System.EventHandler(this.poiskDelToolStripMenuItem_Click);
            // 
            // проектовToolStripMenuItem1
            // 
            this.проектовToolStripMenuItem1.Name = "проектовToolStripMenuItem1";
            this.проектовToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.проектовToolStripMenuItem1.Text = "&Проектов";
            this.проектовToolStripMenuItem1.Click += new System.EventHandler(this.poiskProektovToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 696);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem делоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спискиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem делToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проектовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem делToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem проектовToolStripMenuItem1;
    }
}

