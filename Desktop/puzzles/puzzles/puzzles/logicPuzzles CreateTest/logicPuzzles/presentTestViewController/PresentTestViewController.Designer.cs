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
            this.ToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИхТестаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTaskButton = new System.Windows.Forms.Button();
            this.changeTaskButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ToolStripMenu});
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
            // ToolStripMenu
            // 
            this.ToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходИхТестаToolStripMenuItem});
            this.ToolStripMenu.Name = "ToolStripMenu";
            this.ToolStripMenu.Size = new System.Drawing.Size(116, 20);
            this.ToolStripMenu.Text = "&Основные задачи";
            // 
            // выходИхТестаToolStripMenuItem
            // 
            this.выходИхТестаToolStripMenuItem.Name = "выходИхТестаToolStripMenuItem";
            this.выходИхТестаToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.выходИхТестаToolStripMenuItem.Text = "&Выход их теста";
            // 
            // createTaskButton
            // 
            this.createTaskButton.Location = new System.Drawing.Point(23, 116);
            this.createTaskButton.Name = "createTaskButton";
            this.createTaskButton.Size = new System.Drawing.Size(351, 33);
            this.createTaskButton.TabIndex = 1;
            this.createTaskButton.Text = "Создать задание ";
            this.createTaskButton.UseVisualStyleBackColor = true;
            this.createTaskButton.Click += new System.EventHandler(this.createTaskButton_Click);
            // 
            // ChangeTaskButton
            // 
            this.changeTaskButton.Location = new System.Drawing.Point(23, 156);
            this.changeTaskButton.Name = "ChangeTaskButton";
            this.changeTaskButton.Size = new System.Drawing.Size(351, 36);
            this.changeTaskButton.TabIndex = 2;
            this.changeTaskButton.Text = "Редактировать задание";
            this.changeTaskButton.UseVisualStyleBackColor = true;
            this.changeTaskButton.Click += new System.EventHandler(this.ChangeTaskButton_Click);
            // 
            // PresentTestViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 333);
            this.Controls.Add(this.changeTaskButton);
            this.Controls.Add(this.createTaskButton);
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
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem выходИхТестаToolStripMenuItem;
        private System.Windows.Forms.Button createTaskButton;
        private System.Windows.Forms.Button changeTaskButton;
    }
}