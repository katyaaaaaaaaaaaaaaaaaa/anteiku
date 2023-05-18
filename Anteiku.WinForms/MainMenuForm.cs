using Anteiku.BLL.Abstractions;
using System.Data;

namespace Anteiku.WinForms;

public partial class MainMenuForm : Form
{
    private readonly IUserService _userService;
    private readonly string _positionTitle;

    public MainMenuForm()
    {
        InitializeComponent();
        ((Control)this.tabPage1).Enabled = false;
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

        ((Control)this.tabPage1).Enabled = false;
        _userService = userService;

        var positions = _userService.GetAllPositions();
        positionsCombobox.Items.AddRange(positions.Select(x=>x.PositionTitle).ToArray());

        num.Text = Convert.ToString(_userService.GetUsersCount());
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

    private void addUserButton_Click(object sender, EventArgs e)
    {
        string name = textBox1.Text;

        if (string.IsNullOrEmpty(name))
        {
            //TODO: проверять все вводимые данные на каждой форме и показывать MessageBox
        }

        DateTime birthday = birthdayDatetimePicker.Value;

        var roleAsString =  positionsCombobox.Text;

        int posId = _userService.GetRoleIdByRoleName(roleAsString);

        _userService.AddUser(name, birthday, posId);
    }
}
