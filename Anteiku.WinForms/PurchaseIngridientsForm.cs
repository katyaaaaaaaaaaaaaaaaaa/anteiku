using Anteiku.BLL.Abstractions;
using Anteiku.BLL.Helpers;
using Anteiku.BLL.Models;
using Anteiku.DAL.Enums;
using Anteiku.WinForms.Models;
using System.Data;

namespace Anteiku.WinForms
{
    public partial class PurchaseIngridientsForm : Form
    {
        private IngridientOutput _ingridient { get; set; }

        private readonly IDishService _dishService;
        private readonly IHistoryService _historyService;

        public PurchaseIngridientsForm()
        {
            InitializeComponent();
        }

        public PurchaseIngridientsForm(IDishService dishService, IHistoryService historyService)
        {
            InitializeComponent();
            _dishService = dishService;
            _historyService = historyService;

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
            int count = int.Parse(CountTextBox.Text);

            var type = typesCombobox.Text;

            if (string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Не выбран тип!");
                return;
            }

            _dishService.AddNewIng(title,
            price,
            count,
            ScheduleHelper.GetTypeAsEnumFromString(type));

            _historyService.CreatePurchaseHistoryItem(title, price, count);

            MessageBox.Show("Пользователь добавлен!");
        }

        private void typesCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = typesCombobox.SelectedItem.ToString();

            string t = string.Empty;

            switch (ScheduleHelper.GetTypeAsEnumFromString(selectedItem))
            {
                case IngridientType.COUNT:
                    t = "10 шт.";
                    break;
                case IngridientType.GRAMS:
                    t = "1000 гр.";
                    break;
                case IngridientType.MILLILITERS:
                    t = "1000 мл.";
                    break;                    
                default:
                    break;
            }

            priceLabel.Text = $"Введите цену за {t}";
        }

        private void CountTextBox_TextChanged(object sender, EventArgs e)
        {
            var selectedItem = typesCombobox.SelectedItem.ToString();

            int mul = 1;

            switch (ScheduleHelper.GetTypeAsEnumFromString(selectedItem))
            {
                case IngridientType.COUNT:
                    mul = 10;
                    break;
                case IngridientType.GRAMS:
                    mul = 1000;
                    break;
                case IngridientType.MILLILITERS:                    
                    mul = 1000;
                    break;
                default:
                    break;
            }

            double price = double.Parse(priceTextBox.Text); //1000 - 40

            int count = int.Parse(CountTextBox.Text); // 1150 - x

            double total = count * price / mul;

            totalSumLabel.Text = $"Итоговая сумма: {Math.Round(total, 2)} BYN.";
        }
    }
}
