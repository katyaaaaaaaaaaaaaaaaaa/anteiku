namespace Anteiku.WinForms
{
    partial class PurchaseIngridientsForm
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
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.typesCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveIngButton = new System.Windows.Forms.Button();
            this.totalSumLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalSumLabel);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.CountTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.typesCombobox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.saveIngButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 240);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Закупка";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(11, 98);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(102, 20);
            this.priceLabel.TabIndex = 27;
            this.priceLabel.Text = "Введите цену";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(11, 121);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(187, 27);
            this.priceTextBox.TabIndex = 26;
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(231, 121);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(187, 27);
            this.CountTextBox.TabIndex = 25;
            this.CountTextBox.TextChanged += new System.EventHandler(this.CountTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Введите количество";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(11, 53);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(407, 27);
            this.NameTextBox.TabIndex = 6;
            // 
            // typesCombobox
            // 
            this.typesCombobox.FormattingEnabled = true;
            this.typesCombobox.Location = new System.Drawing.Point(448, 53);
            this.typesCombobox.Name = "typesCombobox";
            this.typesCombobox.Size = new System.Drawing.Size(187, 28);
            this.typesCombobox.TabIndex = 14;
            this.typesCombobox.SelectedIndexChanged += new System.EventHandler(this.typesCombobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберите тип ингридиента";
            // 
            // saveIngButton
            // 
            this.saveIngButton.Location = new System.Drawing.Point(448, 183);
            this.saveIngButton.Name = "saveIngButton";
            this.saveIngButton.Size = new System.Drawing.Size(187, 31);
            this.saveIngButton.TabIndex = 0;
            this.saveIngButton.Text = "Купить";
            this.saveIngButton.UseVisualStyleBackColor = true;
            this.saveIngButton.Click += new System.EventHandler(this.saveIngButton_Click);
            // 
            // totalSumLabel
            // 
            this.totalSumLabel.AutoSize = true;
            this.totalSumLabel.Location = new System.Drawing.Point(448, 121);
            this.totalSumLabel.Name = "totalSumLabel";
            this.totalSumLabel.Size = new System.Drawing.Size(125, 20);
            this.totalSumLabel.TabIndex = 28;
            this.totalSumLabel.Text = "Итоговая сумма:";
            // 
            // PurchaseIngridientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 266);
            this.Controls.Add(this.groupBox1);
            this.Name = "PurchaseIngridientsForm";
            this.Text = "Anteiku - ЗАКУПКА ИНГРИДИЕНТОВ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox NameTextBox;
        private ComboBox typesCombobox;
        private Label label1;
        private Label label3;
        private Button saveIngButton;
        private TextBox CountTextBox;
        private Label label4;
        private Label priceLabel;
        private TextBox priceTextBox;
        private Label totalSumLabel;
    }
}