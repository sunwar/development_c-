namespace logicPuzzles
{
    partial class CreateTaskViewController
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
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.groupCountPic = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.createTaskButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupWraper = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.countPageBox = new System.Windows.Forms.ComboBox();
            this.groupCountPic.SuspendLayout();
            this.groupWraper.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskNameLabel.Location = new System.Drawing.Point(38, 18);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(213, 16);
            this.taskNameLabel.TabIndex = 0;
            this.taskNameLabel.Text = "Введите название задания";
            // 
            // taskTextBox
            // 
            this.taskTextBox.Location = new System.Drawing.Point(41, 37);
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(332, 20);
            this.taskTextBox.TabIndex = 1;
            // 
            // groupCountPic
            // 
            this.groupCountPic.Controls.Add(this.radioButton4);
            this.groupCountPic.Controls.Add(this.radioButton3);
            this.groupCountPic.Controls.Add(this.radioButton2);
            this.groupCountPic.Controls.Add(this.radioButton1);
            this.groupCountPic.Location = new System.Drawing.Point(41, 96);
            this.groupCountPic.Name = "groupCountPic";
            this.groupCountPic.Size = new System.Drawing.Size(332, 77);
            this.groupCountPic.TabIndex = 2;
            this.groupCountPic.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(195, 34);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "8";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.countPicCheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(141, 34);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "6";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.countPicCheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(91, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "4";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.countPicCheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(38, 34);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "2";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.countPicCheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите количество элементов";
            // 
            // createTaskButton
            // 
            this.createTaskButton.Location = new System.Drawing.Point(41, 350);
            this.createTaskButton.Name = "createTaskButton";
            this.createTaskButton.Size = new System.Drawing.Size(333, 33);
            this.createTaskButton.TabIndex = 4;
            this.createTaskButton.Text = "Создать задание";
            this.createTaskButton.UseVisualStyleBackColor = true;
            this.createTaskButton.Click += new System.EventHandler(this.createTaskButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите шаблон расположения элементов";
            // 
            // groupWraper
            // 
            this.groupWraper.Controls.Add(this.radioButton7);
            this.groupWraper.Controls.Add(this.radioButton8);
            this.groupWraper.Location = new System.Drawing.Point(41, 210);
            this.groupWraper.Name = "groupWraper";
            this.groupWraper.Size = new System.Drawing.Size(332, 63);
            this.groupWraper.TabIndex = 6;
            this.groupWraper.TabStop = false;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(195, 19);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(99, 17);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Вертикальный";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.wraperCheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Checked = true;
            this.radioButton8.Location = new System.Drawing.Point(38, 19);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(110, 17);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Горизонтальный";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.wraperCheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выберите количество страниц в задании";
            // 
            // countPageBox
            // 
            this.countPageBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.countPageBox.FormattingEnabled = true;
            this.countPageBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.countPageBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.countPageBox.Location = new System.Drawing.Point(41, 306);
            this.countPageBox.Name = "countPageBox";
            this.countPageBox.Size = new System.Drawing.Size(332, 21);
            this.countPageBox.TabIndex = 8;
            this.countPageBox.SelectedValueChanged += new System.EventHandler(this.countPageBox_SelectedValueChanged);
            // 
            // CreateTaskViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 420);
            this.Controls.Add(this.countPageBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupWraper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createTaskButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupCountPic);
            this.Controls.Add(this.taskTextBox);
            this.Controls.Add(this.taskNameLabel);
            this.Name = "CreateTaskViewController";
            this.Text = "createTaskForm";
            this.groupCountPic.ResumeLayout(false);
            this.groupCountPic.PerformLayout();
            this.groupWraper.ResumeLayout(false);
            this.groupWraper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.GroupBox groupCountPic;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createTaskButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupWraper;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox countPageBox;
    }
}