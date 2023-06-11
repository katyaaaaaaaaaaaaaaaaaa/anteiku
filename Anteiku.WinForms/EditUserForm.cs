using Anteiku.BLL.Abstractions;
using Anteiku.BLL.Models;
using Anteiku.DAL.Enums;
using Anteiku.WinForms.Models;
using Microsoft.VisualBasic.ApplicationServices;
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
            comment_textbox.Text = user.Comment;
            birthdayDatetimePicker.Value =user.BirthDate;
            SheduleDays_comboBox.Text = user.ScheduleDays.ToString();
            SheduleTime_comboBox.Text = user.ScheduleTime.ToString();
            positionsCombobox.Text = user.PositionTitle;



            var positions = _userService.GetAllPositions();
            positionsCombobox.Items.AddRange(positions.Select(x => x.PositionTitle).ToArray());

            var days = Enum.GetValues(typeof(ScheduleDays))
                .Cast<ScheduleDays>()
                .Select(x => new DaysViewModel(x))
                .ToList();

            SheduleDays_comboBox.Items.AddRange(days.Select(x => x.DayAsString).ToArray());

            var time = Enum.GetValues(typeof(ScheduleTime))
                .Cast<ScheduleTime>()
                .Select(x => new TimeViewModel(x))
                .ToList();

            SheduleTime_comboBox.Items.AddRange(time.Select(x => x.TimeAsString).ToArray());

        }
    

        private void saveButton_Click(object sender, EventArgs e)
        {
            //_userService.UpdateUser(_user.Id, _user.UserName, _user.BirthDate,_user.PositionTitle, _user.Comment, _user.ScheduleDays, _user.ScheduleTime);
            this.Close();
        }
    }
}
