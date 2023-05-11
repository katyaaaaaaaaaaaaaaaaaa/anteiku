using Anteiku.BLL.Abstractions;
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
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;

        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var user = _userService.GetByName(loginTextbox.Text);

            if (user is null)
            {
                MessageBox.Show($"Пользователь с именем {loginTextbox.Text} не найден");
            }
            else
            {
                MainMenuForm mainMenuForm = new MainMenuForm(user.PositionTitle);

                this.Hide();

                mainMenuForm.Show();
            }
        }
    }
}
