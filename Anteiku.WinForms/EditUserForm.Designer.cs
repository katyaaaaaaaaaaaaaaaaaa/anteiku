namespace Anteiku.WinForms
{
    partial class EditUserForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.Birthday_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Day_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Time_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Comment_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Position_textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(74, 493);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(239, 48);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(74, 50);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(239, 27);
            this.userNameTextBox.TabIndex = 1;
            // 
            // Birthday_textBox
            // 
            this.Birthday_textBox.Location = new System.Drawing.Point(74, 121);
            this.Birthday_textBox.Name = "Birthday_textBox";
            this.Birthday_textBox.Size = new System.Drawing.Size(239, 27);
            this.Birthday_textBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "День рождения";
            // 
            // Day_textBox
            // 
            this.Day_textBox.Location = new System.Drawing.Point(74, 197);
            this.Day_textBox.Name = "Day_textBox";
            this.Day_textBox.Size = new System.Drawing.Size(239, 27);
            this.Day_textBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дни работы";
            // 
            // Time_textBox
            // 
            this.Time_textBox.Location = new System.Drawing.Point(74, 273);
            this.Time_textBox.Name = "Time_textBox";
            this.Time_textBox.Size = new System.Drawing.Size(239, 27);
            this.Time_textBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Часы работы";
            // 
            // Comment_textBox
            // 
            this.Comment_textBox.Location = new System.Drawing.Point(74, 352);
            this.Comment_textBox.Name = "Comment_textBox";
            this.Comment_textBox.Size = new System.Drawing.Size(239, 27);
            this.Comment_textBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Комментарий";
            // 
            // Position_textBox5
            // 
            this.Position_textBox5.Location = new System.Drawing.Point(74, 431);
            this.Position_textBox5.Name = "Position_textBox5";
            this.Position_textBox5.Size = new System.Drawing.Size(239, 27);
            this.Position_textBox5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Должность";
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 565);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Position_textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Comment_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Time_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Day_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Birthday_textBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.saveButton);
            this.Name = "EditUserForm";
            this.Text = "Anteiku - РЕДАКТИРОВАНИЕ ПОЛЬЗОВАТЕЛЯ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button saveButton;
        private TextBox userNameTextBox;
        private TextBox Birthday_textBox;
        private Label label1;
        private Label label2;
        private TextBox Day_textBox;
        private Label label3;
        private TextBox Time_textBox;
        private Label label4;
        private TextBox Comment_textBox;
        private Label label5;
        private TextBox Position_textBox5;
        private Label label6;
    }
}