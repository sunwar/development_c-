namespace logicPuzzles
{
    partial class OpenTaskViewController
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
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.createTaskButton = new System.Windows.Forms.Button();
            this.taskComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskNameLabel.Location = new System.Drawing.Point(134, 124);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(148, 16);
            this.taskNameLabel.TabIndex = 0;
            this.taskNameLabel.Text = "Выберите задание";
            // 
            // createTaskButton
            // 
            this.createTaskButton.Location = new System.Drawing.Point(41, 198);
            this.createTaskButton.Name = "createTaskButton";
            this.createTaskButton.Size = new System.Drawing.Size(333, 33);
            this.createTaskButton.TabIndex = 4;
            this.createTaskButton.Text = "Открыть задание";
            this.createTaskButton.UseVisualStyleBackColor = true;
            this.createTaskButton.Click += new System.EventHandler(this.openTaskButton_Click);
            // 
            // taskComboBox
            // 
            this.taskComboBox.FormattingEnabled = true;
            this.taskComboBox.Location = new System.Drawing.Point(41, 157);
            this.taskComboBox.Name = "taskComboBox";
            this.taskComboBox.Size = new System.Drawing.Size(332, 21);
            this.taskComboBox.TabIndex = 5;
            // 
            // OpenTaskViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 420);
            this.Controls.Add(this.taskComboBox);
            this.Controls.Add(this.createTaskButton);
            this.Controls.Add(this.taskNameLabel);
            this.Name = "OpenTaskViewController";
            this.Text = "createTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.Button createTaskButton;
        private System.Windows.Forms.ComboBox taskComboBox;
    }
}