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
            this.label2 = new System.Windows.Forms.Label();
            this.countPriceTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.typesCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveIngButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.CountTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.countPriceTextBox);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.typesCombobox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.saveIngButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 183);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Закупка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Введите количество за цену";
            // 
            // countPriceTextBox
            // 
            this.countPriceTextBox.Location = new System.Drawing.Point(6, 125);
            this.countPriceTextBox.Name = "countPriceTextBox";
            this.countPriceTextBox.Size = new System.Drawing.Size(187, 27);
            this.countPriceTextBox.TabIndex = 22;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(11, 53);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(187, 27);
            this.NameTextBox.TabIndex = 6;
            // 
            // typesCombobox
            // 
            this.typesCombobox.FormattingEnabled = true;
            this.typesCombobox.Location = new System.Drawing.Point(269, 53);
            this.typesCombobox.Name = "typesCombobox";
            this.typesCombobox.Size = new System.Drawing.Size(187, 28);
            this.typesCombobox.TabIndex = 14;
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
            this.label3.Location = new System.Drawing.Point(269, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите тип ингридиента";
            // 
            // saveIngButton
            // 
            this.saveIngButton.Location = new System.Drawing.Point(507, 121);
            this.saveIngButton.Name = "saveIngButton";
            this.saveIngButton.Size = new System.Drawing.Size(187, 31);
            this.saveIngButton.TabIndex = 0;
            this.saveIngButton.Text = "Купить";
            this.saveIngButton.UseVisualStyleBackColor = true;
            this.saveIngButton.Click += new System.EventHandler(this.saveIngButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Введите количество";
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(269, 125);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(187, 27);
            this.CountTextBox.TabIndex = 25;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(507, 53);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(187, 27);
            this.priceTextBox.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Введите цену";
            // 
            // PurchaseIngridientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 215);
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
        private Label label2;
        private TextBox countPriceTextBox;
        private TextBox CountTextBox;
        private Label label4;
        private Label label5;
        private TextBox priceTextBox;
    }
}