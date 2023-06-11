using Anteiku.BLL.Abstractions;

namespace Anteiku.WinForms;

public partial class LoginForm : Form
{
    private readonly IUserService _userService;

    private readonly IDishService _dishService;

    public LoginForm()
    {
        InitializeComponent();
    }

    public LoginForm(IUserService userService, IDishService dishService)
    {
        InitializeComponent();

        _userService = userService;
        _dishService = dishService;
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
            MainMenuForm mainMenuForm = new MainMenuForm(user.PositionTitle, _userService, _dishService);

            mainMenuForm.FormClosed += Action;

            this.Hide();

            mainMenuForm.Show();
        }
    }

    private void Action(object sender, EventArgs e)
    {
        this.Show();
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
