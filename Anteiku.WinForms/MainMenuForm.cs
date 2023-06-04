using Anteiku.BLL.Abstractions;
using Anteiku.BLL.Helpers;
using Anteiku.BLL.Models;
using Anteiku.DAL.Enums;
using Anteiku.WinForms.Models;
using System.Data;

namespace Anteiku.WinForms;

public partial class MainMenuForm : Form
{
    private readonly IUserService _userService;
    private readonly string _positionTitle;
    private List<UserOutput> users = new List<UserOutput>();

    private delegate void UsersCountHandler();

    private event UsersCountHandler UsersChanged;

    public MainMenuForm()
    {
        InitializeComponent();
        ((Control)this.productsTabpage).Enabled = false;
    }

    public MainMenuForm(string positionTitle, IUserService userService)
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

        ((Control)this.productsTabpage).Enabled = false;
        _userService = userService;

        var positions = _userService.GetAllPositions();
        positionsCombobox.Items.AddRange(positions.Select(x=>x.PositionTitle).ToArray());

        var days = Enum.GetValues(typeof(ScheduleDays))
            .Cast<ScheduleDays>()
            .Select(x=> new DaysViewModel(x))
            .ToList();

        SheduleDays_comboBox.Items.AddRange(days.Select(x=>x.DayAsString).ToArray());

        var time = Enum.GetValues(typeof(ScheduleTime))
            .Cast<ScheduleTime>()
            .Select(x => new TimeViewModel(x))
            .ToList();

        SheduleTime_comboBox.Items.AddRange(time.Select(x => x.TimeAsString).ToArray());

        num.Text = Convert.ToString(_userService.GetUsersCount());

        users = _userService.GetAllUsers();

        usersDataGridView.DataSource = users;

        UsersChanged += UpdateUsersDataGridView;
        UsersChanged += UpdateUsersCount;
    }

    private void UpdateUsersDataGridView()
    {
        users = _userService.GetAllUsers();
        usersDataGridView.DataSource = users;
    }

    private void UpdateUsersCount()
    {
        num.Text = Convert.ToString(_userService.GetUsersCount());
    }

    //TODO: переименовать
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
            UsersChanged.Invoke();
        //}
    }

    private void addUserButton_Click(object sender, EventArgs e)
    {
        string name = textBox1.Text;

        if (string.IsNullOrEmpty(name))
        {
            MessageBox.Show("Имя не может быть пустым!");
            return;
        }

        DateTime birthday = birthdayDatetimePicker.Value;

        var roleAsString =  positionsCombobox.Text;

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

        string comment = comment_textbox.Text;

        _userService.AddUser(name, 
            birthday, 
            posId, 
            comment, 
            ScheduleHelper.GetDayAsEnumFromString(day),
            ScheduleHelper.GetTimeAsEnumFromString(time));

        UsersChanged.Invoke();

        MessageBox.Show("Пользователь добавлен!");
    }

    private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
    {

    }

    private void editUserButton_Click(object sender, EventArgs e)
    {
        //TODO: проверка
        var editedUser = _userService.GetById(int.Parse(editUserTextBox.Text));

        EditUserForm editUserForm = new EditUserForm(_userService, editedUser);

        editUserForm.FormClosed += Action;

        this.Hide();

        editUserForm.Show();
    }

    private void Action(object sender, EventArgs e)
    {
        this.Show();
        UsersChanged.Invoke();
    }

    private void SheduleDays_comboBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void SheduleTime_comboBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
