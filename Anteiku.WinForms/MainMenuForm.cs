using Anteiku.BLL.Abstractions;
using Anteiku.BLL.UseCases;
using Anteiku.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anteiku.WinForms
{
    public partial class MainMenuForm : Form
    {
        private readonly IUserService _userService;
        private readonly string _positionTitle;

        public MainMenuForm()
        {
            InitializeComponent();
            ((Control)this.tabPage1).Enabled = false;
        }

        public MainMenuForm(string positionTitle)
        {
            
            InitializeComponent();
            _positionTitle = positionTitle;

            if (_positionTitle != "Administrator")
            {
                ((Control)this.userOperationTabpage).Enabled = false;
            }

            if (_positionTitle != "Cook")
            {
                ((Control)this.kitchenTabpage).Enabled = false;
            }

            ((Control)this.tabPage1).Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            DateTime birthday = Convert.ToDateTime(textBox2.Text);
            int position = Convert.ToInt32(textBox3.Text);
            _userService.AddUser(name, birthday, position);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var user = Convert.ToInt32(textBox4.Text);

            //if (user is null)
            //{
            //    MessageBox.Show($"Пользователь с ID {Convert.ToInt32(textBox4.Text)} не найден");
            //}
            //else
            //{
                _userService.DelUser(user);
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num.Text=Convert.ToString(_userService.GetUsersCount());
        }
    }
}
