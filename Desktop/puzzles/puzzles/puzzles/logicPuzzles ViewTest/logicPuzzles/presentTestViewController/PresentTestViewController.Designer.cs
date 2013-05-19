namespace logicPuzzles
{
    partial class PresentTestViewController
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.основныеЗадачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьЗаданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИхТестаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.основныеЗадачиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(386, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // основныеЗадачиToolStripMenuItem
            // 
            this.основныеЗадачиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьЗаданиеToolStripMenuItem,
            this.выходИхТестаToolStripMenuItem});
            this.основныеЗадачиToolStripMenuItem.Name = "основныеЗадачиToolStripMenuItem";
            this.основныеЗадачиToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.основныеЗадачиToolStripMenuItem.Text = "&Основные задачи";
            // 
            // создатьЗаданиеToolStripMenuItem
            // 
            this.создатьЗаданиеToolStripMenuItem.Name = "создатьЗаданиеToolStripMenuItem";
            this.создатьЗаданиеToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.создатьЗаданиеToolStripMenuItem.Text = "&Открыть задание";
            this.создатьЗаданиеToolStripMenuItem.Click += new System.EventHandler(this.открытьЗаданиеToolStripMenuItem_Click);
            // 
            // выходИхТестаToolStripMenuItem
            // 
            this.выходИхТестаToolStripMenuItem.Name = "выходИхТестаToolStripMenuItem";
            this.выходИхТестаToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.выходИхТестаToolStripMenuItem.Text = "&Выход их теста";
            // 
            // PresentTestViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 333);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PresentTestViewController";
            this.Text = "PresentTestViewController";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem основныеЗадачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьЗаданиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИхТестаToolStripMenuItem;
    }
}