using Anteiku.BLL.Abstractions;
using Anteiku.BLL.Helpers;
using Anteiku.BLL.Models;
using Anteiku.DAL.Enums;
using Anteiku.WinForms.Models;
using System.Data;

namespace Anteiku.WinForms;

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

    private void saveUserButton_Click(object sender, EventArgs e)
    {
        var roleAsString = positionsCombobox.Text;

        if (string.IsNullOrEmpty(roleAsString))
        {
            MessageBox.Show("Не выбрана должность!");
            return;
        }

        int posId = _userService.GetRoleIdByRoleName(roleAsString);

        string? day = SheduleDays_comboBox.Text;

        if (string.IsNullOrEmpty(day))
        {
            MessageBox.Show("Не выбрано расписание!");
            return;
        }

        var time = SheduleTime_comboBox.Text;

        if (string.IsNullOrEmpty(time))
        {
            MessageBox.Show("Не выбрано расписание!");
            return;
        }

        try
        {
            _userService.UpdateUser(_user.Id, userNameTextBox.Text, birthdayDatetimePicker.Value, posId,
            comment_textbox.Text,
            ScheduleHelper.GetDayAsEnumFromString(day),
            ScheduleHelper.GetTimeAsEnumFromString(time));

            MessageBox.Show("Изменения сохранены успешно!");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка : {ex.Message}");
        }        

        this.Close();
    }
}
