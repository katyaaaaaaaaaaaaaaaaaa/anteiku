﻿namespace Anteiku.WinForms
{
    partial class MainMenuForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.userOperationTabpage = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.editUserButton = new System.Windows.Forms.Button();
            this.editUserTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.positionsCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.birthdayDatetimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.kitchenTabpage = new System.Windows.Forms.TabPage();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SheduleDays_comboBox = new System.Windows.Forms.ComboBox();
            this.SheduleTime_comboBox = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.userOperationTabpage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.kitchenTabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.userOperationTabpage);
            this.tabControl.Controls.Add(this.kitchenTabpage);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(12, 44);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1017, 595);
            this.tabControl.TabIndex = 0;
            // 
            // userOperationTabpage
            // 
            this.userOperationTabpage.Controls.Add(this.groupBox4);
            this.userOperationTabpage.Controls.Add(this.groupBox3);
            this.userOperationTabpage.Controls.Add(this.groupBox2);
            this.userOperationTabpage.Controls.Add(this.groupBox1);
            this.userOperationTabpage.Location = new System.Drawing.Point(4, 29);
            this.userOperationTabpage.Name = "userOperationTabpage";
            this.userOperationTabpage.Padding = new System.Windows.Forms.Padding(3);
            this.userOperationTabpage.Size = new System.Drawing.Size(1009, 562);
            this.userOperationTabpage.TabIndex = 0;
            this.userOperationTabpage.Text = "Управление пользователями";
            this.userOperationTabpage.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.editUserButton);
            this.groupBox4.Controls.Add(this.editUserTextBox);
            this.groupBox4.Location = new System.Drawing.Point(42, 418);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(912, 116);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Изменение пользователей";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Введите Id работника";
            // 
            // editUserButton
            // 
            this.editUserButton.Location = new System.Drawing.Point(263, 62);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(146, 29);
            this.editUserButton.TabIndex = 19;
            this.editUserButton.Text = "Редактировать";
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // editUserTextBox
            // 
            this.editUserTextBox.Location = new System.Drawing.Point(33, 64);
            this.editUserTextBox.Name = "editUserTextBox";
            this.editUserTextBox.Size = new System.Drawing.Size(160, 27);
            this.editUserTextBox.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(46, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 116);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Удаление пользователей";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(291, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 37);
            this.button4.TabIndex = 1;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(50, 57);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(160, 27);
            this.textBox4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Введите Id работника";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.num);
            this.groupBox2.Location = new System.Drawing.Point(541, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 116);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Статистика";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Количество работников:";
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Location = new System.Drawing.Point(208, 49);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(0, 20);
            this.num.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.SheduleTime_comboBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.SheduleDays_comboBox);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.positionsCombobox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.birthdayDatetimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.addUserButton);
            this.groupBox1.Location = new System.Drawing.Point(42, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 203);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание пользователя";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Введите часы работы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Введите дни работы";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(450, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 27);
            this.textBox2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Введите комментарий";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 27);
            this.textBox1.TabIndex = 6;
            // 
            // positionsCombobox
            // 
            this.positionsCombobox.FormattingEnabled = true;
            this.positionsCombobox.Location = new System.Drawing.Point(450, 52);
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
            this.birthdayDatetimePicker.Location = new System.Drawing.Point(236, 53);
            this.birthdayDatetimePicker.Name = "birthdayDatetimePicker";
            this.birthdayDatetimePicker.Size = new System.Drawing.Size(173, 27);
            this.birthdayDatetimePicker.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите дату рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите должность";
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(716, 88);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(134, 31);
            this.addUserButton.TabIndex = 0;
            this.addUserButton.Text = "Добавить";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // kitchenTabpage
            // 
            this.kitchenTabpage.Controls.Add(this.usersDataGridView);
            this.kitchenTabpage.Location = new System.Drawing.Point(4, 29);
            this.kitchenTabpage.Name = "kitchenTabpage";
            this.kitchenTabpage.Padding = new System.Windows.Forms.Padding(3);
            this.kitchenTabpage.Size = new System.Drawing.Size(1009, 562);
            this.kitchenTabpage.TabIndex = 1;
            this.kitchenTabpage.Text = "График работы";
            this.kitchenTabpage.UseVisualStyleBackColor = true;
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Location = new System.Drawing.Point(6, 6);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.RowHeadersWidth = 51;
            this.usersDataGridView.RowTemplate.Height = 29;
            this.usersDataGridView.Size = new System.Drawing.Size(909, 309);
            this.usersDataGridView.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1009, 562);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Наличие и закупка продуктов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1009, 562);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Ежедневные планы продаж";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1009, 562);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Оформление отчетов";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SheduleDays_comboBox
            // 
            this.SheduleDays_comboBox.FormattingEnabled = true;
            this.SheduleDays_comboBox.Location = new System.Drawing.Point(11, 153);
            this.SheduleDays_comboBox.Name = "SheduleDays_comboBox";
            this.SheduleDays_comboBox.Size = new System.Drawing.Size(151, 28);
            this.SheduleDays_comboBox.TabIndex = 17;
            this.SheduleDays_comboBox.SelectedIndexChanged += new System.EventHandler(this.SheduleDays_comboBox_SelectedIndexChanged);
            // 
            // SheduleTime_comboBox
            // 
            this.SheduleTime_comboBox.FormattingEnabled = true;
            this.SheduleTime_comboBox.Location = new System.Drawing.Point(236, 153);
            this.SheduleTime_comboBox.Name = "SheduleTime_comboBox";
            this.SheduleTime_comboBox.Size = new System.Drawing.Size(151, 28);
            this.SheduleTime_comboBox.TabIndex = 19;
            this.SheduleTime_comboBox.SelectedIndexChanged += new System.EventHandler(this.SheduleTime_comboBox_SelectedIndexChanged);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 651);
            this.Controls.Add(this.tabControl);
            this.Name = "MainMenuForm";
            this.Text = "Anteiku - ГЛАВНОЕ МЕНЮ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenuForm_FormClosed);
            this.tabControl.ResumeLayout(false);
            this.userOperationTabpage.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.kitchenTabpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage userOperationTabpage;
        private TabPage kitchenTabpage;
        private TabPage tabPage1;
        private Button addUserButton;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button4;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label4;
        private TextBox textBox4;
        private Label num;
        private Label label5;
        private DateTimePicker birthdayDatetimePicker;
        private GroupBox groupBox1;
        private ComboBox positionsCombobox;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private DataGridView usersDataGridView;
        private Label label6;
        private Button editUserButton;
        private TextBox editUserTextBox;
        private GroupBox groupBox4;
        private TextBox textBox2;
        private Label label7;
        private Label label9;
        private Label label8;
        private ComboBox SheduleTime_comboBox;
        private ComboBox SheduleDays_comboBox;
    }
}