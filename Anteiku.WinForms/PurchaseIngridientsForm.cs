using Anteiku.BLL.Abstractions;
using Anteiku.BLL.Helpers;
using Anteiku.BLL.Models;
using Anteiku.BLL.UseCases;
using Anteiku.DAL.Enums;
using Anteiku.WinForms.Models;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Forms;


namespace Anteiku.WinForms
{
    public partial class PurchaseIngridientsForm : Form
    {
        private IngridientOutput _ingridient { get; set; }
        private readonly IDishService _dishService;

        public PurchaseIngridientsForm()
        {
            InitializeComponent();
        }

        public PurchaseIngridientsForm(IDishService dishService)
        {
            InitializeComponent();
            _dishService = dishService;

            var types = Enum.GetValues(typeof(IngridientType))
          .Cast<IngridientType>()
          .Select(x => new IngTypesViewModel(x))
          .ToList();

            typesCombobox.Items.AddRange(types.Select(x => x.TypeAsString).ToArray());
        }

        private void saveIngButton_Click(object sender, EventArgs e)
        {
           
            string title = NameTextBox.Text;
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("название не может быть пустым!");
                return;
            }
            double price = double.Parse(priceTextBox.Text);
            int countForPrice = int.Parse(countPriceTextBox.Text);
            int count = int.Parse(CountTextBox.Text);

            var type = typesCombobox.Text;

            if (string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Не выбран тип!");
                return;
            }

            _dishService.AddNewIng(title,
            price,
            countForPrice,
            count,
            ScheduleHelper.GetTypeAsEnumFromString(type));
            //IngChanged.Invoke();

            MessageBox.Show("Пользователь добавлен!");
        }
    }
}
