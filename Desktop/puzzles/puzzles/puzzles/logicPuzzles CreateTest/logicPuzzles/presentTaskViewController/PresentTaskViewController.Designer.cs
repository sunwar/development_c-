namespace logicPuzzles
{
    partial class PresentTaskViewController
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
            this.picturesPanel = new System.Windows.Forms.Panel();
            this.namePicLabel = new System.Windows.Forms.Label();
            this.namePicturesPanel = new System.Windows.Forms.Panel();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.pageLabel = new System.Windows.Forms.Label();
            this.backPageButton = new System.Windows.Forms.Button();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.createTaskButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picturesPanel.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // picturesPanel
            // 
            this.picturesPanel.BackColor = System.Drawing.SystemColors.Control;
            this.picturesPanel.Controls.Add(this.namePicLabel);
            this.picturesPanel.Controls.Add(this.namePicturesPanel);
            this.picturesPanel.Location = new System.Drawing.Point(21, 83);
            this.picturesPanel.Name = "picturesPanel";
            this.picturesPanel.Size = new System.Drawing.Size(583, 483);
            this.picturesPanel.TabIndex = 0;
            // 
            // namePicLabel
            // 
            this.namePicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namePicLabel.Location = new System.Drawing.Point(3, 352);
            this.namePicLabel.Name = "namePicLabel";
            this.namePicLabel.Size = new System.Drawing.Size(577, 23);
            this.namePicLabel.TabIndex = 3;
            this.namePicLabel.Text = "Названия изображений";
            this.namePicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // namePicturesPanel
            // 
            this.namePicturesPanel.Location = new System.Drawing.Point(3, 378);
            this.namePicturesPanel.Name = "namePicturesPanel";
            this.namePicturesPanel.Size = new System.Drawing.Size(577, 102);
            this.namePicturesPanel.TabIndex = 1;
            // 
            // navigationPanel
            // 
            this.navigationPanel.Controls.Add(this.pageLabel);
            this.navigationPanel.Controls.Add(this.backPageButton);
            this.navigationPanel.Controls.Add(this.nextPageButton);
            this.navigationPanel.Location = new System.Drawing.Point(21, 24);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(583, 30);
            this.navigationPanel.TabIndex = 0;
            // 
            // pageLabel
            // 
            this.pageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageLabel.Location = new System.Drawing.Point(154, 4);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(272, 23);
            this.pageLabel.TabIndex = 6;
            this.pageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backPageButton
            // 
            this.backPageButton.Location = new System.Drawing.Point(3, 4);
            this.backPageButton.Name = "backPageButton";
            this.backPageButton.Size = new System.Drawing.Size(145, 23);
            this.backPageButton.TabIndex = 5;
            this.backPageButton.Text = "Назад";
            this.backPageButton.UseVisualStyleBackColor = true;
            this.backPageButton.Click += new System.EventHandler(this.backPageButton_Click);
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(432, 4);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(148, 23);
            this.nextPageButton.TabIndex = 4;
            this.nextPageButton.Text = "Вперед";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // createTaskButton
            // 
            this.createTaskButton.Location = new System.Drawing.Point(15, 572);
            this.createTaskButton.Name = "createTaskButton";
            this.createTaskButton.Size = new System.Drawing.Size(586, 48);
            this.createTaskButton.TabIndex = 2;
            this.createTaskButton.Text = "Создать задание";
            this.createTaskButton.UseVisualStyleBackColor = true;
            this.createTaskButton.Click += new System.EventHandler(this.createTaskButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Перечень изображений";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PresentTaskViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 632);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picturesPanel);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.createTaskButton);
            this.DoubleBuffered = true;
            this.Name = "PresentTaskViewController";
            this.Text = "PresentTaskViewController";
            this.picturesPanel.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel picturesPanel;
        private System.Windows.Forms.Panel namePicturesPanel;
        private System.Windows.Forms.Button createTaskButton;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Button backPageButton;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.Label namePicLabel;
        private System.Windows.Forms.Label label1;
    }
}