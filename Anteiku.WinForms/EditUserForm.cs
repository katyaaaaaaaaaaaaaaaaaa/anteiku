using Anteiku.BLL.Abstractions;
using Anteiku.BLL.Models;
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
    public partial class EditUserForm : Form
    {
        private UserOutput _user { get; set; }
        private readonly IUserService _userService;

        public EditUserForm()
        {
            InitializeComponent();
        }

        public EditUserForm(IUserService userService, UserOutput user)
        {
            InitializeComponent();
            _userService = userService;
            _user = user;
            userNameTextBox.Text = user.UserName;
            Comment_textBox.Text = user.Comment;
            Birthday_textBox.Text = Convert.ToString(user.BirthDate);
            Day_textBox.Text = user.ScheduleDays.ToString();
            Time_textBox.Text = user.ScheduleTime.ToString();
            Position_textBox5.Text = user.PositionTitle;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //_userService.UpdateUser(_user.Id, userNameTextBox.Text, Convert.ToDateTime(Birthday_textBox.Text), Position_textBox5.Text, Comment_textBox.Text,Day_textBox.Text, (DAL.Enums.ScheduleTime)Time_textBox.Text);
            this.Close();
        }
    }
}
