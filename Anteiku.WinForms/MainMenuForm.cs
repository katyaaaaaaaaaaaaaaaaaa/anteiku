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

    private readonly IDishService _dishService;

    private readonly IHistoryService _historyService;

    private readonly string _positionTitle;

    IngridientOutput _ingridient { get; set; }


    private List<UserOutput> users = new List<UserOutput>();

    private List<DishOutput> dishes = new List<DishOutput>();

    private List<IngridientOutput> ingridients = new List<IngridientOutput>();


    private delegate void UsersCountHandler();

    private event UsersCountHandler UsersChanged;

    private delegate void IngCountHandler();

    private event IngCountHandler IngChanged;

    public MainMenuForm()
    {
        InitializeComponent();
        ((Control)this.productsTabpage).Enabled = false;
    }

    public MainMenuForm(string positionTitle, IUserService userService, IDishService dishService, IHistoryService historyService)
    {
        InitializeComponent();

        _positionTitle = positionTitle;

        if (_positionTitle != "Administrator")
        {
            ((Control)this.userOperationTabpage).Enabled = false;
        }

        if (_positionTitle != "Cook")
        {
            ((Control)this.WorkersTabpage).Enabled = false;
        }

        //((Control)this.productsTabpage).Enabled = false;

        #region SERVICES

        _userService = userService;

        _dishService = dishService;

        _historyService = historyService;

        #endregion

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

        num.Text = Convert.ToString(_userService.GetUsersCount());

        users = _userService.GetAllUsers();

        usersDataGridView.DataSource = users;

        UsersChanged += UpdateUsersDataGridView;
        UsersChanged += UpdateUsersCount;

        ingridients = _dishService.GetAllIngridients();

        ingridientsGridView.DataSource = ingridients;

        IngChanged += UpdateIngDataGridView;
        
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
        var editedUser = _userService.GetById(int.Parse(editUserTextBox.Text));

        if (editedUser is null)
        {
            MessageBox.Show($"Пользователь c id {editUserTextBox.Text} не найден!");
        }
        else
        {
            EditUserForm editUserForm = new EditUserForm(_userService, editedUser);

            editUserForm.FormClosed += Action;

            this.Hide();

            editUserForm.Show();
        }         
    }

    private void Action(object sender, EventArgs e)
    {
        this.Show();
        UsersChanged.Invoke();
    }

    private void ActionIng(object sender, EventArgs e)
    {
        this.Show();
        IngChanged.Invoke();
    }

    private void SheduleDays_comboBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void SheduleTime_comboBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void zakup_button_Click(object sender, EventArgs e)
    {
        PurchaseIngridientsForm ZacupIngForm = new PurchaseIngridientsForm(_dishService, _historyService);

        ZacupIngForm.FormClosed += ActionIng;

        this.Hide();

        ZacupIngForm.Show();
    }

    private void zacupButton_Click (object sender, EventArgs e)
    {
        var existIngId = _dishService.GetIngById(int.Parse(existIngIdTextBox.Text));

        if (existIngId is null)
        {
            MessageBox.Show($"Ингридиент c id {existIngIdTextBox.Text} не найден!");
        }
        else
        {
            var col =int.Parse(colTextBox.Text);

            _ingridient = _dishService.UpdateIng(int.Parse(existIngIdTextBox.Text), col);

            //TODO: как получить цену
            //_historyService.CreatePurchaseHistoryItem(existIngId.Title, 
            //    existIngId.PriceForDefaultCountInByn, col);

            IngChanged.Invoke();
        }
    }

    private void UpdateIngDataGridView()
    {
        ingridients = _dishService.GetAllIngridients();
        ingridientsGridView.DataSource = ingridients;
    }

    private void colTextBox_Enter(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(existIngIdTextBox.Text))
        {
            return;
        }

        var findedIng = _dishService.GetIngById(int.Parse(existIngIdTextBox.Text));

        if (findedIng is not null)
        {
            ingridientLabel.Text = findedIng.Title;
        }
        else
        {
            ingridientLabel.ForeColor = Color.Red;
            ingridientLabel.Text = "Ошибка! Ингридиент не найден.";
        }
    }
}
