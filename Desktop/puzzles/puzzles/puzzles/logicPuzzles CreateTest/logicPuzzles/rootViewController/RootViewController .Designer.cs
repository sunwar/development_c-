﻿namespace logicPuzzles
{
    partial class RootViewController
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.основныеЗадачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьТестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьТестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.основныеЗадачиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // основныеЗадачиToolStripMenuItem
            // 
            this.основныеЗадачиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьТестToolStripMenuItem,
            this.загрузитьТестToolStripMenuItem,
            this.выходИзПрограммыToolStripMenuItem});
            this.основныеЗадачиToolStripMenuItem.Name = "основныеЗадачиToolStripMenuItem";
            this.основныеЗадачиToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.основныеЗадачиToolStripMenuItem.Text = "&Основные задачи";
            // 
            // создатьТестToolStripMenuItem
            // 
            this.создатьТестToolStripMenuItem.Name = "создатьТестToolStripMenuItem";
            this.создатьТестToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.создатьТестToolStripMenuItem.Text = "&Создать тест";
            this.создатьТестToolStripMenuItem.Click += new System.EventHandler(this.создатьТестToolStripMenuItem_Click);
            // 
            // загрузитьТестToolStripMenuItem
            // 
            this.загрузитьТестToolStripMenuItem.Name = "загрузитьТестToolStripMenuItem";
            this.загрузитьТестToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.загрузитьТестToolStripMenuItem.Text = "&Редактировать тест";
            this.загрузитьТестToolStripMenuItem.Click += new System.EventHandler(this.загрузитьТестToolStripMenuItem_Click);
            // 
            // выходИзПрограммыToolStripMenuItem
            // 
            this.выходИзПрограммыToolStripMenuItem.Name = "выходИзПрограммыToolStripMenuItem";
            this.выходИзПрограммыToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.выходИзПрограммыToolStripMenuItem.Text = "&Выход из программы";
            // 
            // RootViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 430);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RootViewController";
            this.Text = "Логические загадки";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem основныеЗадачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьТестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьТестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзПрограммыToolStripMenuItem;
    }
}

