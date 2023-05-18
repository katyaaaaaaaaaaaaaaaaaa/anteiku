using Anteiku.BLL.Abstractions;

namespace Anteiku.WinForms;

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
            MainMenuForm mainMenuForm = new MainMenuForm(user.PositionTitle, _userService);

            this.Hide();

            mainMenuForm.Show();
        }
    }
}
