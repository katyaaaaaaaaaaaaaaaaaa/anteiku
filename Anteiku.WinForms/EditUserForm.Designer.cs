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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SheduleDays_comboBox = new System.Windows.Forms.ComboBox();
            this.SheduleTime_comboBox = new System.Windows.Forms.ComboBox();
            this.comment_textbox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.positionsCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.birthdayDatetimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveUserButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.comment_textbox);
            this.groupBox1.Controls.Add(this.userNameTextBox);
            this.groupBox1.Controls.Add(this.positionsCombobox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.birthdayDatetimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.saveUserButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 337);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание пользователя";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.SheduleDays_comboBox);
            this.groupBox5.Controls.Add(this.SheduleTime_comboBox);
            this.groupBox5.Location = new System.Drawing.Point(11, 88);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(249, 170);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Расписание";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Дни работы";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Часы работы";
            // 
            // SheduleDays_comboBox
            // 
            this.SheduleDays_comboBox.FormattingEnabled = true;
            this.SheduleDays_comboBox.Location = new System.Drawing.Point(42, 57);
            this.SheduleDays_comboBox.Name = "SheduleDays_comboBox";
            this.SheduleDays_comboBox.Size = new System.Drawing.Size(151, 28);
            this.SheduleDays_comboBox.TabIndex = 17;
            // 
            // SheduleTime_comboBox
            // 
            this.SheduleTime_comboBox.FormattingEnabled = true;
            this.SheduleTime_comboBox.Location = new System.Drawing.Point(42, 119);
            this.SheduleTime_comboBox.Name = "SheduleTime_comboBox";
            this.SheduleTime_comboBox.Size = new System.Drawing.Size(151, 28);
            this.SheduleTime_comboBox.TabIndex = 19;
            // 
            // comment_textbox
            // 
            this.comment_textbox.Location = new System.Drawing.Point(312, 102);
            this.comment_textbox.Multiline = true;
            this.comment_textbox.Name = "comment_textbox";
            this.comment_textbox.Size = new System.Drawing.Size(369, 156);
            this.comment_textbox.TabIndex = 16;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(11, 53);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(249, 27);
            this.userNameTextBox.TabIndex = 6;
            // 
            // positionsCombobox
            // 
            this.positionsCombobox.FormattingEnabled = true;
            this.positionsCombobox.Location = new System.Drawing.Point(530, 53);
            this.positionsCombobox.Name = "positionsCombobox";
            this.positionsCombobox.Size = new System.Drawing.Size(151, 28);
            this.positionsCombobox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите имя";
            // 
            // birthdayDatetimePicker
            // 
            this.birthdayDatetimePicker.Location = new System.Drawing.Point(312, 53);
            this.birthdayDatetimePicker.Name = "birthdayDatetimePicker";
            this.birthdayDatetimePicker.Size = new System.Drawing.Size(173, 27);
            this.birthdayDatetimePicker.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите дату рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите должность";
            // 
            // saveUserButton
            // 
            this.saveUserButton.Location = new System.Drawing.Point(540, 287);
            this.saveUserButton.Name = "saveUserButton";
            this.saveUserButton.Size = new System.Drawing.Size(134, 31);
            this.saveUserButton.TabIndex = 0;
            this.saveUserButton.Text = "Сохранить";
            this.saveUserButton.UseVisualStyleBackColor = true;
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 367);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditUserForm";
            this.Text = "Anteiku - РЕДАКТИРОВАНИЕ ПОЛЬЗОВАТЕЛЯ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox5;
        private Label label8;
        private Label label9;
        private ComboBox SheduleDays_comboBox;
        private ComboBox SheduleTime_comboBox;
        private TextBox comment_textbox;
        private TextBox userNameTextBox;
        private ComboBox positionsCombobox;
        private Label label1;
        private DateTimePicker birthdayDatetimePicker;
        private Label label2;
        private Label label3;
        private Button saveUserButton;
    }
}