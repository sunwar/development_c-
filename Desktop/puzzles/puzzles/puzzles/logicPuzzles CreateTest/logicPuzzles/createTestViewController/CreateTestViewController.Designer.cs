namespace logicPuzzles
{
    partial class CreateTestViewController
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
            this.testNameLabel = new System.Windows.Forms.Label();
            this.testNameTextBox = new System.Windows.Forms.TextBox();
            this.createTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testNameLabel
            // 
            this.testNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testNameLabel.Location = new System.Drawing.Point(12, 37);
            this.testNameLabel.Name = "testNameLabel";
            this.testNameLabel.Size = new System.Drawing.Size(339, 23);
            this.testNameLabel.TabIndex = 0;
            this.testNameLabel.Text = "Введите название теста";
            this.testNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testNameTextBox
            // 
            this.testNameTextBox.Location = new System.Drawing.Point(88, 91);
            this.testNameTextBox.Name = "testNameTextBox";
            this.testNameTextBox.Size = new System.Drawing.Size(188, 20);
            this.testNameTextBox.TabIndex = 1;
            // 
            // createTestButton
            // 
            this.createTestButton.Location = new System.Drawing.Point(88, 141);
            this.createTestButton.Name = "createTestButton";
            this.createTestButton.Size = new System.Drawing.Size(188, 23);
            this.createTestButton.TabIndex = 2;
            this.createTestButton.Text = "Создать тест";
            this.createTestButton.UseVisualStyleBackColor = true;
            this.createTestButton.Click += new System.EventHandler(this.createTestButton_Click);
            // 
            // CreateTestViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 288);
            this.Controls.Add(this.createTestButton);
            this.Controls.Add(this.testNameTextBox);
            this.Controls.Add(this.testNameLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinimizeBox = false;
            this.Name = "CreateTestViewController";
            this.Text = "Создание теста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label testNameLabel;
        private System.Windows.Forms.TextBox testNameTextBox;
        private System.Windows.Forms.Button createTestButton;
    }
}