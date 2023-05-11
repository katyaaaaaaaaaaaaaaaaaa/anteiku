namespace Anteiku.WinForms
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
            this.kitchenTabpage = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.userOperationTabpage.SuspendLayout();
            this.kitchenTabpage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.userOperationTabpage);
            this.tabControl.Controls.Add(this.kitchenTabpage);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(12, 55);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(915, 404);
            this.tabControl.TabIndex = 0;
            // 
            // userOperationTabpage
            // 
            this.userOperationTabpage.Controls.Add(this.button3);
            this.userOperationTabpage.Location = new System.Drawing.Point(4, 29);
            this.userOperationTabpage.Name = "userOperationTabpage";
            this.userOperationTabpage.Padding = new System.Windows.Forms.Padding(3);
            this.userOperationTabpage.Size = new System.Drawing.Size(907, 371);
            this.userOperationTabpage.TabIndex = 0;
            this.userOperationTabpage.Text = "Управление пользователями";
            this.userOperationTabpage.UseVisualStyleBackColor = true;
            // 
            // kitchenTabpage
            // 
            this.kitchenTabpage.Controls.Add(this.button2);
            this.kitchenTabpage.Location = new System.Drawing.Point(4, 29);
            this.kitchenTabpage.Name = "kitchenTabpage";
            this.kitchenTabpage.Padding = new System.Windows.Forms.Padding(3);
            this.kitchenTabpage.Size = new System.Drawing.Size(907, 371);
            this.kitchenTabpage.TabIndex = 1;
            this.kitchenTabpage.Text = "Кухня";
            this.kitchenTabpage.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(907, 371);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(70, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 497);
            this.Controls.Add(this.tabControl);
            this.Name = "MainMenuForm";
            this.Text = "Anteiku - ГЛАВНОЕ МЕНЮ";
            this.tabControl.ResumeLayout(false);
            this.userOperationTabpage.ResumeLayout(false);
            this.kitchenTabpage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage userOperationTabpage;
        private TabPage kitchenTabpage;
        private TabPage tabPage1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}